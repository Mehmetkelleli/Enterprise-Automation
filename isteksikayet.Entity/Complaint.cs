

using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Identity;

namespace isteksikayet.Entity
{
    public class Complaint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string FileUrl { get; set; }
        public bool Approval { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int  DepartmentId { get; set; }
        public Department Department { get; set; }
        public ComplaintReply ComplaintReply { get; set; }
    }
}
