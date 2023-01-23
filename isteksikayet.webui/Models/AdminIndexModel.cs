using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using System.Collections.Generic;
using System.Linq;

namespace isteksikayet.webui.Models
{
    public class AdminIndexModel
    {
        public List<Department> Departmants { get; set; }
        public IEnumerable<User> Users { get; set; }
        public List<Complaint> Complaints { get; set; }
        
    }
}
