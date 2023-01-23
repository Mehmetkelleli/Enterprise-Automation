using isteksikayet.webui.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Complaint> Complaint { get; set; }
        public List<User> Users { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
