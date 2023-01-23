using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Data.Abstract
{
    public interface IComplaintRepository:IGenericRepository<Complaint>
    {
        List<Complaint> GetComplaintDepartment(string UserId);
        Complaint GetComlaintDepartById(int id);
        void ComplaintsReplay(Complaint Coomplaint, string Answer,string UserReplyId);
        List<Complaint> GetComplaintDepartmentAll();
        Complaint GetByUser(int id);
    }
}
