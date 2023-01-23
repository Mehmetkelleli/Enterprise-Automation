using isteksikayet.webui.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Entity
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public state State { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string FileUrl { get; set; }
        public string CreatedUserId { get; set; }
        public User CreatedUser  { get; set; }
        public string TaskUserId { get; set; }
        public User TaskUser { get; set; }
    }
    public enum state
    {
        Waiting =0,
        Task = 1,
        Ok = 2
    }
}
