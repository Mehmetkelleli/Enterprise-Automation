using isteksikayet.webui.Identity;
using System.Collections.Generic;

namespace isteksikayet.webui.Models
{
    public class UserContact
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
