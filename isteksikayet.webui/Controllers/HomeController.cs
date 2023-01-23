using isteksikayet.Business.Abstract;
using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace isteksikayet.webui.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private IComplaintService _Complaint;
        private IDepartmentService _Department;
        private UserManager<User> _User;
        
        public HomeController(IComplaintService Complaint, IDepartmentService Department, UserManager<User> user)
        {
            _Complaint = Complaint;
            _Department = Department;
            _User = user;
            

        }
        public async Task<IActionResult> Index()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("index","root");
            }
            return View(_Complaint.GetComplaintDepartment(users.Id));
        }
        //Comlaint List
        public async Task<IActionResult> ComplaintList()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            if (User.IsInRole("Admin"))
            {
                return View(_Complaint.GetComplaintDepartmentAll());
            }
            else
            {
                return View(_Complaint.GetComplaintDepartment(users.Id));
            }
        }
        //Complaint Add
        [HttpGet]
        public async Task<IActionResult> ComplaintAdd()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            ViewBag.Department = new SelectList(_Department.GetAll(), "Id", "Name");
            return View(new Complaint { });
        }
        [HttpPost]
        public async Task<IActionResult> ComplaintAdd(Complaint T,IFormFile File)
        {
            if(File == null)
            {
                var users = await _User.FindByNameAsync(User.Identity.Name);
                TempData["User"] = JsonSerializer.Serialize(users);
                _Complaint.Create(T);
                return RedirectToAction("index");
            }
            var random = $"{DateTime.Now.Ticks}{Path.GetExtension(File.FileName)}";
            T.FileUrl = random;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await File.CopyToAsync(stream);
            }
            _Complaint.Create(T);
            return RedirectToAction("index");
        }
        [HttpGet]
        public async Task<IActionResult> ComplaintUpdate(int id)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            ViewBag.Department = new SelectList(_Department.GetAll(), "Id", "Name");
            return View(_Complaint.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> ComplaintUpdate(Complaint T, IFormFile File)
        {
            if (File == null)
            {
                _Complaint.Update(T);
                return RedirectToAction("ComplaintList");
            }
            var random = $"{DateTime.Now.Ticks}{Path.GetExtension(File.FileName)}";
            T.FileUrl = random;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await File.CopyToAsync(stream);
            }
            _Complaint.Update(T);
            return RedirectToAction("ComplaintList");
        }
        [HttpGet]
        public async Task<IActionResult> ComplaintDelete(int id)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            if (id == null)
            {
                return RedirectToAction("ComplaintList");
            }
            var Complaint = _Complaint.GetById(id);
            _Complaint.Delete(Complaint);
            return RedirectToAction("ComplaintList");
        }
        [HttpGet]
        public async Task<IActionResult> ComplaintDetails(int id)
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            return View(_Complaint.GetComlaintDepartById(id));
        }
        public async Task<IActionResult> AprovedComplaint()
        {
            var users = await _User.FindByNameAsync(User.Identity.Name);
            TempData["User"] = JsonSerializer.Serialize(users);
            if (User.IsInRole("Admin"))
            {
                return View(_Complaint.GetComplaintDepartmentAll());
            }
            else
            {
                return View(_Complaint.GetComplaintDepartment(users.Id));
            }
        }

    }
}
