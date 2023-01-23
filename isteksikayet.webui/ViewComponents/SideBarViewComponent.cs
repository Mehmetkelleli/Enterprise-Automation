using isteksikayet.Data.Abstract;
using isteksikayet.Data.Context;
using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using isteksikayet.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace isteksikayet.webui.ViewComponents
{
    public class SideBarViewComponent:ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _Context = new DataContext();
            var user =  _Context.Users.FirstOrDefault(i => i.UserName == User.Identity.Name);
            var model = new UserViewModel()
            {
                Name = user.Name,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };

            return View(model);
        }
    }
}
