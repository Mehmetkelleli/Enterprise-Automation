using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Business.Abstract
{
    public interface IComplaintService
    {
        void Create(Complaint t);
        void Update(Complaint t);
        List<Complaint> GetAll();
        Complaint GetById(int Id);
        void Delete(Complaint t);
        List<Complaint> GetComplaintDepartment(string UserId);
        Complaint GetComlaintDepartById(int id);
        void ComplaintsReplay(Complaint Complaint, string Answer,string ReplyId);
        List<Complaint> GetComplaintDepartmentAll();
        Complaint GetByUser(int id);
    }
}
