using isteksikayet.Entity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace isteksikayet.webui.Identity
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ImgUrl { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public virtual List<Complaint> Complaint { get; set; }
        public string LocalNumber { get; set; }
        public bool Root { get; set; }
        public bool Active { get; set; }

        public string FullName()
        {
            return Name + " " + LastName; 
        }


    }
}
