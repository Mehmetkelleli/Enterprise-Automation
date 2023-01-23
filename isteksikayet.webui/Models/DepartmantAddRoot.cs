using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using System.Collections.Generic;
using System.Linq;

namespace isteksikayet.webui.Models
{
    public class DepartmantAddRoot
    {
        public Department Department { get; set; }
        public IQueryable<User> Users { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
