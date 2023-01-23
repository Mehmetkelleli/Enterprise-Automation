using isteksikayet.Business.Abstract;
using isteksikayet.webui.EMailSend;
using isteksikayet.webui.Identity;
using isteksikayet.webui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace isteksikayet.webui.Controllers
{
    public class AccountController : Controller

    {
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IdentityError> Errors { get; }
        private UserManager<User> _User;
        private SignInManager<User> _Sign;
        private RoleManager<IdentityRole> _Role;
        private IEMailSend _Mail;
        private IDataAdd _Data;
        public AccountController(UserManager<User> User, SignInManager<User> Sign, IEMailSend Mail, IDataAdd Data, RoleManager<IdentityRole> Role)
        {
            _Data = Data;
            _User = User;
            _Sign = Sign;
            _Mail = Mail;
            _Role = Role;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new Sign { });
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _Sign.SignOutAsync();
            return RedirectToAction("login");

        }
        [HttpPost]
        public async Task<IActionResult> Login(Sign Sign)
        {
            if (Sign.UserName == null || Sign.Password == null)
            {
                TempData["Message"] = "Kullanıcı Adı veya Sifreniz Boş";
                return RedirectToAction("login");
            }
            var user_mail = await _User.FindByEmailAsync(Sign.UserName);
            var user_UserName = await _User.FindByNameAsync(Sign.UserName);
            if (user_mail == null && user_UserName == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı Bulunmamaktadır";
                return RedirectToAction("login");
            }
            if (user_mail != null)
            {

                if (!await _User.IsEmailConfirmedAsync(user_mail))
                {
                    TempData["Message"] = "Lütfen Kullanıcıyı Onaylayınız";
                    return RedirectToAction("login");
                }
                if (user_mail.Active == false)
                {
                    TempData["Message"] = "Hesabınız Banlanmıştır";
                    return RedirectToAction("login");
                }
                var result = await _Sign.PasswordSignInAsync(user_mail, Sign.Password, false, false);
                if (result.Succeeded)
                {
                    TempData["User"] = JsonSerializer.Serialize(user_mail);
                    HttpContext.Session.SetString("Name", user_mail.Name);
                    HttpContext.Session.SetString("LastName", user_mail.LastName);
                    HttpContext.Session.SetString("ImgUrl", user_mail.ImgUrl);
                    HttpContext.Session.SetString("IsRoot", user_mail.Root.ToString());
                    if (await _User.IsInRoleAsync(user_mail, "Personel"))
                    {
                        return Redirect($"/root/DepartmantUpdate/{user_mail.DepartmentId}");
                    }
                    if (await _User.IsInRoleAsync(user_mail, "Admin"))
                    {
                        return RedirectToAction("index", "root");
                    }
                    return RedirectToAction("index", "Home");
                }
                TempData["Message"] = "Yanlış Kullanıcı Adı veya Sifre";
                return RedirectToAction("login");

            }
            else
            {
                if (!await _User.IsEmailConfirmedAsync(user_UserName))
                {
                    TempData["Message"] = "Lütfen Kullanıcıyı Onaylayınız";
                    return RedirectToAction("login");
                }
                if (user_UserName.Active == false)
                {
                    TempData["Message"] = "Hesabınız Banlanmıştır";
                    return RedirectToAction("login");
                }
                var result = await _Sign.PasswordSignInAsync(user_UserName, Sign.Password, false, false);
                if (result.Succeeded)
                {
                    TempData["User"] = JsonSerializer.Serialize(user_UserName);
                    TempData["User"] = JsonSerializer.Serialize(user_mail);
                    HttpContext.Session.SetString("Name", user_UserName.Name);
                    HttpContext.Session.SetString("LastName", user_UserName.LastName);
                    HttpContext.Session.SetString("ImgUrl", user_UserName.ImgUrl);
                    HttpContext.Session.SetString("IsRoot", user_UserName.Root.ToString());
                    if (await _User.IsInRoleAsync(user_UserName, "Personel"))
                    {
                        return Redirect($"/root/DepartmantUpdate/{user_UserName.DepartmentId}");
                    }
                    if (await _User.IsInRoleAsync(user_UserName, "Admin"))
                    {
                        return RedirectToAction("index", "root");
                    }
                    return RedirectToAction("index", "Home");
                }
                TempData["Message"] = "Yanlış Kullanıcı Adı veya Sifre";
                return RedirectToAction("login");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return View(new Sign { });
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new Register { });
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register Model, IFormFile FileImg)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            if (FileImg == null)
            {
                TempData["Message"] = "Lütfen Resim Seçiniz";
                return View(Model);
            }
            var aa = await _User.FindByEmailAsync(Model.EMail);
            if (aa != null)
            {
                TempData["Message"] = "Bu eposta kullanılmakta";
                return View(Model);
            }

            //resim upload
            var random = $"{DateTime.Now.Ticks}.jpg";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await FileImg.CopyToAsync(stream);
            }
            var user = new User()
            {
                Name = Model.Name,
                LastName = Model.LastName,
                Email = Model.EMail,
                ImgUrl = random,
                UserName = Model.UserName,
                DepartmentId = 4,
                Active = true
            };
            var result = await _User.CreateAsync(user, Model.Password);
            if (result.Succeeded)
            {
                //generata confirm mail token
                var code = await _User.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmMail", "account", new
                {
                    UserId = user.Id,
                    UserToken = code
                });
                TempData["Message"] = "Confirm E-Mail Account";
                _Data.DataInitializer();
                await _Mail.Send(user.Email, "Confirm Mail", $"Click to confirm your account<br><br> <a href='http://localhost:22039{url}'>Confirm</>");
                return RedirectToAction("Login");
            }
            TempData["Message"] = result.Errors;
            return View(new Register { });
        }
        public async Task<IActionResult> ConfirmMail(string UserId, string UserToken)
        {
            if (UserId == null || UserToken == null)
            {
                TempData["Message"] = "Bir Hata Oluştu";
                return RedirectToAction("Login");
            }
            var user = await _User.FindByIdAsync(UserId);
            if (user == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı Bulunmamaktadır";
                return RedirectToAction("Login");
            }
            var result = await _User.ConfirmEmailAsync(user, UserToken);
            if (result.Succeeded)
            {
                TempData["Message"] = "İşlem Tamamlandı";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return RedirectToAction("Login");
        }
        //forgot password
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string EMail)
        {
            if (String.IsNullOrEmpty(EMail))
            {
                TempData["Message"] = "E Mail Alanı Boş Bırakılamaz";
                return View();
            }
            var user = await _User.FindByEmailAsync(EMail);
            if (user == null)
            {
                TempData["Message"] = "E postaya ait kullanıcı bulunamadı";
                return View();
            }
            var token = await _User.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "account", new
            {
                UserId = user.Id,
                UserToken = token
            });
            await _Mail.Send(user.Email, "Sifre Sıfırlama", $"Sifrenizi yenilemek için <a href='http://localhost:22039/" +
                $"{url}'>Tıklayınız</a>");
            TempData["Message"] = "E Postanızı Doğrulamak için kontrol ediniz";
            return RedirectToAction("login");
        }
        // reset password with token
        [HttpGet]
        public IActionResult ResetPassword(string UserId, string UserToken)
        {
            if (UserId == null || UserToken == null)
            {
                TempData["Message"] = "Yetkisiz Erişim";
                return RedirectToAction("login");
            }
            var user = _User.FindByIdAsync(UserId);
            if (user == null)
            {
                TempData["Message"] = "Yetkisiz Erişim Böyle bir kullanıcı bulunmamaktadır";
                return RedirectToAction("login");
            }
            var resetpassword = new ResetPassword()
            {
                UserId = UserId,
                UserToken = UserToken
            };
            return View(resetpassword);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPassword Reset)
        {
            if (!ModelState.IsValid)
            {
                return View(Reset);
            }
            if (Reset == null)
            {
                TempData["Message"] = "Nesne Boş Dönmektedir";
                return View(Reset);
            }
            var user = await _User.FindByIdAsync(Reset.UserId);
            if (user == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı Bulunmamaktadır";
            }
            var result = await _User.ResetPasswordAsync(user, Reset.UserToken, Reset.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = "Sifreniz Güncellendi";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Sifreniz Güncellendi";
            return RedirectToAction("Login");
        }
        //accessdenied View()
        public IActionResult AccessDenied()
        {
            TempData["Message"] = "Yetkisiz Erişim";
            return RedirectToAction("login");
        }
    }
}
