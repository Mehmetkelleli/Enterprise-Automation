using isteksikayet.Business.Abstract;
using isteksikayet.Data.Context;
using isteksikayet.Entity;
using isteksikayet.webui.EMailSend;
using isteksikayet.webui.Identity;
using isteksikayet.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace isteksikayet.webui.Controllers
{
    [Authorize(Roles ="Admin,Personel")]
    [AutoValidateAntiforgeryToken]
    public class RootController : Controller
    {
        private IComplaintService _Complaint;
        private IDepartmentService _Department;
        private ISİteConfigService _Setting;
        private RoleManager<IdentityRole> _Role;
        private UserManager<User> _User;
        private IEMailSend _Mail;
        private DataContext _Context;
        public RootController(
            IComplaintService Complaint, 
            IDepartmentService Department, 
            ISİteConfigService Setting, 
            RoleManager<IdentityRole> Role, 
            UserManager<User> user,
            IEMailSend Mail,
            DataContext Context
            )
        {
            
            _Complaint = Complaint;
            _Department = Department;
            _Setting = Setting;
            _Role = Role;
            _User = user;
            _Mail = Mail;
            _Context = Context;

        }
        public async Task<IActionResult> Index()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            var liste = new List<User>();
            foreach (var item in _User.Users.Include(i=>i.Department))
            {
                liste.Add(item);
            }

            var adminpage = new AdminIndexModel();
            adminpage.Complaints = _Complaint.GetComplaintDepartmentAll();
            adminpage.Departmants = _Department.GetAll();
            adminpage.Users = liste;
            
            return View(adminpage);
        
        }
        //departman işlemleri
        [HttpGet]
        public async Task<IActionResult> DepartmantAdd()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            var userlist = _User.Users.Where(i=>i.DepartmentId !=4);
            var list = new DepartmantAddRoot()
            {
                Department = new Department(),
                Users = userlist
            };
            return View(list);
        }
        [HttpPost]
        public async Task<IActionResult> DepartmantAdd(DepartmantAddRoot Model ,string? RootId)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            if (!string.IsNullOrEmpty(RootId))
            {
                var user = await _User.FindByIdAsync(RootId);
                user.Root = true;
                await _User.UpdateAsync(user);
            }
            TempData["User"] = JsonSerializer.Serialize(users);
            TempData["Message"] = "Departman Eklendi";
            _Department.Create(new Department
            {
                Name = Model.Department.Name,
                
            }) ;
            return RedirectToAction("DepartmantList");
        }
        [HttpGet]
        public async Task<IActionResult> DepartmantUpdate(int id)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            var userlist = _User.Users.Include(i=>i.Department).Where(i=>i.DepartmentId ==id);
            var list = new DepartmantAddRoot()
            {
                Department = _Department.GetByIdWidthDepartmant(id),
                Users = userlist,
                Tasks = _Context.Tasks.Include(i=>i.CreatedUser).Include(i=>i.TaskUser).Where(i=>i.DepartmentId == id).ToList()
            };
            return View(list);
        }
    
        [HttpPost]
        public async Task<IActionResult> DepartmantUpdate(Department Departman)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            TempData["Message"] = "Departman Güncellendi";
            _Department.Update(Departman);
            return RedirectToAction("DepartmantList");
        }
        public async Task<IActionResult> DepartmantList()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            return View(_Department.GetAll());
        }
        [HttpGet]

        public IActionResult DepartmantDelete(int id)
        {
            if(id != null)
            {
                var Departman = _Department.GetById(id);
                _Department.Delete(Departman);
                TempData["Message"] = "Departman Silindi";

                return RedirectToAction("DepartmantList");
            }
            TempData["Message"] = "Geçersiz işlem";

            return RedirectToAction("DepartmantList");
        }
        //site ayar kısımı
        [HttpGet]
        public async Task<IActionResult> Setting()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            return View(_Setting.GetById(1));
        }
        [HttpPost]
        public async Task<IActionResult> Setting(SiteConfig Setting)
        {
            _Setting.Update(Setting);
            TempData["Message"] = "Ayarlar Güncellendi";
            return View(_Setting.GetById(1));
        }
        // Complaints Sikayet ve oneri cevaplama kısım
        [HttpGet]
        public async Task<IActionResult> ComplaintsReplay(int id)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            ViewBag.Department = new SelectList(_Department.GetAll(), "Id", "Name");
            return View(_Complaint.GetByUser(id));
        }
        [HttpPost]
        public async Task<IActionResult> ComplaintsReplay(Complaint Complaint,string Answer)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            Complaint.Approval = true;
            _Complaint.ComplaintsReplay(Complaint, Answer,users.Id);
            var html = $"Cevabı ileten kişi :<br00>" +
                $"{users.Name} {users.LastName}<br>" +
                $"{Answer}";
            var user = _Complaint.GetByUser(Complaint.Id);
            Console.WriteLine(user.User.Email);
            await _Mail.Send(user.User.Email, "Görüş Cevaplandı",html);
            TempData["Message"] = "Görüş Cevaplandı";
            return Redirect($"/Root/DepartmantUpdate/{Complaint.DepartmentId}");
        }
        ///role process
        
        public async Task<IActionResult> RoleList()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            return View(_Role.Roles);
        }
        [HttpGet]
        public async Task<IActionResult> RoleAdd()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleAdd(string RoleName)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            if (string.IsNullOrEmpty(RoleName)){
                TempData["Message"] = "Role Kısmı Boş Bırakılamaz";
                return View();
            }
            var result = await _Role.CreateAsync(new IdentityRole(RoleName));
            if (result.Succeeded)
            {
                TempData["Message"] = "Role Eklendi";
                return RedirectToAction("RoleList");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> RoleUpdate(string id)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            if (string.IsNullOrEmpty(id))
            {
                TempData["Message"] = "Yetkisiz erişim";
                return RedirectToAction("RoleList");
            }
            var role =await _Role.FindByIdAsync(id);
            if(role == null)
            {
                TempData["Message"] = "Role Bulunamadı";
                return RedirectToAction("RoleList");
            }
            var members = new List<User>();
            var nonmember = new List<User>();
            foreach (var item in _User.Users)
            {
                if(await _User.IsInRoleAsync(item, role.Name))
                {
                    members.Add(item);
                }

                else
                {
                    nonmember.Add(item);
                }
            }
            var RoleModel = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMermbers = nonmember
            };
            return View(RoleModel);
        }
        [HttpPost]
        public async Task<IActionResult> RoleUpdate(RoleDetails Model, string[] MembersAdd, string[] MembersDelete)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            if (Model.Role.Id == null || Model.Role.Name == null)
            {
                TempData["Message"] = "Role Adı veya Id'si Boş Bırakılamaz";
                return Redirect($"/root/RoleUpdate/{Model.Role.Id}");
            }
            var role = await _Role.FindByIdAsync(Model.Role.Id);
            if(role == null)
            {
                TempData["Message"] = "Role Bulunamadı";
                return Redirect($"/root/RoleUpdate/{Model.Role.Id}");
            }
            foreach (var item in MembersAdd)
            {
                var user =await _User.FindByIdAsync(item);
                if(user != null)
                {
                    var result =await _User.AddToRoleAsync(user,role.Name);
                }
                
            }
            foreach (var item in MembersDelete)
            {
                var user = await _User.FindByIdAsync(item);
                if (user != null)
                {
                    var result = await _User.RemoveFromRoleAsync(user, role.Name);
                    
                    
                }
                
            }
            TempData["Message"] = "Role Yetkileri Güncellendi";
            return Redirect($"/root/RoleUpdate/{Model.Role.Id}");

        }
        public async Task<IActionResult> GetContact()
        {
            var list = new List<UserContact>();
            foreach (var item in _User.Users.Include(i=>i.Department))
            {
                if(await _User.GetRolesAsync(item) != null)
                {
                    var contact = new UserContact()
                    {
                        User = item,
                        Roles = await _User.GetRolesAsync(item)
                    };
                    list.Add(contact);
                }
            }
            return View(list);
        }
        public async Task<IActionResult> GetUsers()
        {
            return View(_User.Users);
        }
        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            var random = new Random();
            var password = "";
            string[] alpha = { "a.", "A." ,"B.","b!","C*","c-","D!","d.","E*","*Z","-*z","-I*","*i*"};
            for (int i = 0; i < 7; i++)
            {
                password += random.Next(0, 15);
                password += alpha[random.Next(0, 12)];
            }

            var model = new AdminUserAddModel()
            {
                Roles = _Role.Roles,
                Departmants = _Department.GetAll().ToList(),
                Password = password
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(AdminUserAddModel Model)
        {
            Model.Roles = _Role.Roles;
            Model.Departmants = _Department.GetAll().ToList();
            //model state durum işlem kontrolu 
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            // kulanıcı kontrol işlemleri
            var user_email = await _User.FindByEmailAsync(Model.EMail);
            var user_username = await _User.FindByNameAsync(Model.UserName);
            if (user_email != null )
            {
                TempData["Message"] = "Kullanıcı E Postası Kullanılmaktadır";
                return View(Model);
            }
            if (user_username != null)
            {
                TempData["Message"] = "Kullanıcı Adı Kullanılmaktadır";
                return View(Model);
            }
            // form resim uzantı kontrol
            if(Path.GetExtension(Model.ImgUrl.FileName) != ".jpg")
            {
                TempData["Message"] = "Sadece Jpg Uzantılı Resim Ekleyiniz";
                return View(Model);
            }
            // resim ekleme işlemleri
            var random = $"{DateTime.Now.Ticks}.jpg";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", random);
            using (var stream = System.IO.File.Create(path))
            {
                await Model.ImgUrl.CopyToAsync(stream);
            }
            var user = new User()
            {
                Name = Model.Name,
                LastName = Model.LastName,
                Active = Model.Active,
                UserName = Model.UserName,
                Email = Model.EMail,
                EmailConfirmed = true,
                DepartmentId = Model.SelectDepartment,
                ImgUrl = random
            };
            var result = await _User.CreateAsync(user, Model.Password);
            var state = true;
            foreach (var item in Model.roles)
            {
                var states = await _User.AddToRoleAsync(user,item);
                if (!states.Succeeded)
                {
                    state = false;
                }
            }
            if(result.Succeeded && state == true)
            {
                TempData["Message"] = "Kullanıcı Oluşturuldu";
                return RedirectToAction("GetUsers");
            }
            var message = "Bir Hata Meydana Geldi";
            foreach (var item in result.Errors)
            {
                message += $"{item.Description}<br>";
            }
            TempData["Message"] = message;
            return View(Model);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await _User.FindByIdAsync(id);
            if(user == null)
            {
                TempData["Message"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("GetUsers");
            }
            var liste = new List<string>();
            foreach (var item in _Role.Roles)
            {
                liste.Add(item.ToString());
            }
            var Model = new AdminUserUpdateModel()
            {
                Name = user.Name,
                LastName = user.LastName,
                StringImgUrl = user.ImgUrl,
                UserName = user.UserName,
                Active = user.Active,
                LocalNumber = user.LocalNumber,
                Roles = liste,
                roles = await _User.GetRolesAsync(user),
                Departmants = new SelectList(_Department.GetAll(), "Id", "Name"),
                SelectDepartment = user.DepartmentId,
                Id = user.Id,
                EMailConfirm = user.EmailConfirmed,
                EMail = user.Email,
            };
            return View(Model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(AdminUserUpdateModel Model)
        {
            if(!ModelState.IsValid)
            {
                return View(Model);
            }
            
            var user =await _User.FindByIdAsync(Model.Id);
            var user_mail = await _User.FindByEmailAsync(Model.EMail);
            var user_name = await _User.FindByNameAsync(Model.UserName);

            if(user == null)
            {
                TempData["Message"] = "Kullanıcı bulunamadı";
                return View(Model);
            }
            if(user_mail != null)
            {
                if(user_mail == user)
                {
                    user.Email = Model.EMail;
                }
                if(user_mail != user)
                {
                    if(user_mail.Email == user.Email)
                    {
                        TempData["Message"] = "Bu kullanıcı E postası Kullanılmaktadır";
                        return View(Model);
                    }
                    user.Email = Model.EMail;
                }
            }else
            {
                user.Email = Model.EMail;
            }
            if (user_name != null)
            {
                if (user_name == user)
                {
                    user.UserName = Model.UserName;
                }
                if (user_mail != user)
                {
                    if (user_mail.Email == user.Email)
                    {
                        TempData["Message"] = "Bu kullanıcı Adı Kullanılmaktadır";
                        return View(Model);
                    }
                    user.UserName = Model.UserName;
                }
            }
            else
            {
                user.UserName = Model.UserName;
            }
            if (Model.ImgUrl != null)
            {
                if (Path.GetExtension(Model.ImgUrl.FileName) != ".jpg")
                {
                    TempData["Message"] = "Sadece Jpg Uzantılı Resim Ekleyiniz";
                    return View(Model);
                }
                // resim ekleme işlemleri
                var random = $"{DateTime.Now.Ticks}.jpg";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", random);
                using (var stream = System.IO.File.Create(path))
                {
                    await Model.ImgUrl.CopyToAsync(stream);
                }
                user.ImgUrl = random;
            }
            else
            {
                user.ImgUrl = user.ImgUrl;
            }
            if(user.DepartmentId != Model.SelectDepartment)
            {
                user.Root = false;
            }
            user.Id = Model.Id;
            user.Name = Model.Name;
            user.LastName = Model.LastName;
            user.Active = Model.Active;
            user.LocalNumber = Model.LocalNumber;
            user.DepartmentId = Model.SelectDepartment;
            user.EmailConfirmed = Model.EMailConfirm;

            var result = await _User.UpdateAsync(user);
            if (!result.Succeeded)
            {
                var message = "";
                foreach (var item in result.Errors)
                {
                    message += $"{item.Description}<br>";
                }
                TempData["Message"] = message;
                return View(Model);
            }
           //password güüncelleme
            if (!string.IsNullOrEmpty(Model.Password) && !string.IsNullOrEmpty(Model.RePassword))
            {
               var resultp = await _User.ChangePasswordAsync(user, Model.Password, Model.RePassword);
                if (!resultp.Succeeded)
                {
                    var message = "";
                    foreach (var item in resultp.Errors)
                    {
                        message += $"{item.Description}<br>";
                    }
                    TempData["Message"] = message;
                    return View(Model);
                }
            }
            // role işlemleri
            await _User.RemoveFromRolesAsync(user, await _User.GetRolesAsync(user));
            foreach (var item in Model.roles)
            {
                await _User.AddToRoleAsync(user, item);
            }
            TempData["Message"] = "Kullanıcı Güncellendi";
            return RedirectToAction("GetUsers");
        }
        [HttpGet]
        public  IActionResult AddTask()
        {
            ViewBag.Departments = new SelectList(_Department.GetAll(),"Id","Name");
            return View(new TaskDto { });
        }
        [HttpPost]
        public async Task<IActionResult> AddTask(TaskDto Model)
        {
            var user = await _User.FindByNameAsync(User.Identity.Name);
            if(user == null)
            {
                TempData["Message"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("Login", "Account");
            }
            var FileUrl = "";
            if(Model.File != null)
            {
                if(Path.GetExtension(Model.File.FileName) != ".exe" && Path.GetExtension(Model.File.FileName) != ".cshtml" && Path.GetExtension(Model.File.FileName) != ".cs")
                {
                    var random = $"{DateTime.Now.Ticks}{Path.GetExtension(Model.File.FileName)}";
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", random);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await Model.File.CopyToAsync(stream);
                    }
                    FileUrl = random;
                }

            }
            var state = await _Context.Tasks.AddAsync(new Entity.Task
            {
                DepartmentId = Model.DepartmentId,
                Title = Model.Title,
                Description = Model.Description,
                FileUrl = FileUrl,
                CreatedUserId = user.Id,
            });
            _Context.SaveChanges();
            TempData["Message"] = "İş Oluşturuldu";
            return Redirect($"/Root/DepartmantUpdate/{Model.DepartmentId}");
        }
        public async Task<IActionResult> DetailTask(int Id)
        {   var Task = _Context.Tasks.Include(i=>i.CreatedUser).Include(i=>i.TaskUser).Include(i=>i.Department).FirstOrDefault(i => i.Id == Id);
            if(Task == null)
            {
                return Redirect($"/Root/UpdateDepartment/{Id}");
            }
            var TaskDto = new TaskDto
            {
                Title = Task.Title,
                Description = Task.Description,
                DepartmentId = Task.DepartmentId,
                Department = Task.Department,
                CreatedUser = Task.CreatedUser,
                TaskUser = Task.TaskUser,
                State = Task.State,
                FileUrl = Task.FileUrl,
                TaskId = Task.Id
            };
            return View(TaskDto);
        }
        public async Task<IActionResult> TaskUserAdd(int? TaskId,int? DepartmentId)
        {
            if(TaskId == null || DepartmentId == null)
            {
                return RedirectToAction("DepartmentList");
            }
            var Task = _Context.Tasks.FirstOrDefault(i => i.Id == TaskId);
            var user = await _User.FindByNameAsync(User.Identity.Name);
            if(Task == null || user == null)
            {
                return RedirectToAction("DepartmentList");
            }
            Task.State = state.Task;
            Task.TaskUserId = user.Id;
            Task.TaskUser = user;
            _Context.SaveChanges();
            TempData["Message"] = "İş Alındı";
             return Redirect($"/root/DepartmantUpdate/{DepartmentId}");
        }
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = _Context.Tasks.FirstOrDefault(i => i.Id == id);
            if(task == null)
            {
                TempData["Message"] = "Böyle bir iş bulunamadı";
                return RedirectToAction("DepartmantList");
            }
            var entity  = _Context.Tasks.Remove(task);
            var state = entity.State == EntityState.Deleted;
            if (state)
            {
                TempData["Message"] = "İş Silindi";
                return RedirectToAction("DepartmantList");
            }
            TempData["Message"] = "Bir sistem sorunu meydana geldi";
            return RedirectToAction("DepartmantList");
        }
        public async Task<IActionResult> FinishTask(int? TaskId,int? DepartmantId)

        {
            if(TaskId == null || DepartmantId == null)
            {
                TempData["Message"] = "Departman Id yada Task Id Bulunamadı";
                return RedirectToAction("DepartmantList");
            }
            var Task = _Context.Tasks.FirstOrDefault(i => i.Id == TaskId);
            if(Task == null)
            {
                TempData["Message"] = "Böyle bir iş bulunamadı";
                return RedirectToAction("DepartmantList");
            }
            Task.State = state.Ok;
            _Context.SaveChanges();
            return Redirect($"/root/departmantupdate/{DepartmantId}");
        }
        public async Task<IActionResult> ListTask()
        {
            return View(_Context.Tasks.Include(i=>i.Department).Include(i=>i.CreatedUser).ToList());
        }
    }
}
