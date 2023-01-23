using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace isteksikayet.webui.Models
{
    public class RoleDetails
    {
     
        public IdentityRole Role { get; set; }
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<User> NonMermbers { get; set; }

    }
}
