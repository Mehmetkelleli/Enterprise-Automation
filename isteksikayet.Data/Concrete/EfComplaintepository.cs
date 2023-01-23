using isteksikayet.Data.Abstract;
using isteksikayet.Data.Context;
using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Data.Concrete
{
    public class EfComplaintepository : EfGenericRepository<Complaint, DataContext>, IComplaintRepository
    {
        private DataContext _Context;
        public EfComplaintepository(DataContext Context)
        {
            _Context = Context;
        }
        public void ComplaintsReplay(Complaint Coomplaint, string Answer,string UserIdreply)
        {
            using (var db = _Context)
            {
                  
                var complaint = db.Complaints.Include(i=>i.User).Include(a=>a.ComplaintReply).ThenInclude(a=>a.User).FirstOrDefault(i => i.Id == Coomplaint.Id);
                var ComplaintReply = new ComplaintReply()
                {
                    Name = "Cevap",
                    Description = Answer,
                    ComplaintId = complaint.Id,
                    UserId = UserIdreply
                    
                };


                    complaint.Name = Coomplaint.Name;
                    complaint.Description = Coomplaint.Description;
                    complaint.DepartmentId = Coomplaint.DepartmentId;
                    complaint.UserId = Coomplaint.UserId;
                    complaint.Approval = Coomplaint.Approval;
                    complaint.FileUrl = Coomplaint.FileUrl;

                db.ComplaintReplays.Add(ComplaintReply);
                db.SaveChanges();




            }
        }

        public Complaint GetByUser(int id)
        {
             return _Context.Complaints.Include(i => i.User).FirstOrDefault(i => i.Id == id);
        }

        public Complaint GetComlaintDepartById(int id)
        {
            using (var db =  _Context)
            {
                return db.Complaints.
                    Where(i=>i.Id == id).
                    Include(i=>i.User).
                    Include(i => i.Department).
                    Include(a=>a.ComplaintReply).
                    ThenInclude(a=>a.User).
                    FirstOrDefault();
            }
        }

        public List<Complaint> GetComplaintDepartment(string UserId)
        {
            using (var db = _Context)
            {
                return db.Complaints.Include(i => i.Department).Where(i => i.UserId == UserId).ToList();
                //return new List<Complaint> { };
            }
        }

        public List<Complaint> GetComplaintDepartmentAll()
        {
            using (var db = _Context)
            {
                return db.Complaints.Include(i => i.Department).ToList();
                //return new List<Complaint> { };
            }
        }
    }
}
