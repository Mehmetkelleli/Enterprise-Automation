using isteksikayet.Business.Abstract;
using isteksikayet.Data.Abstract;
using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Business.Concrete
{
    public class ComplaintManager:IComplaintService
    {
        private IComplaintRepository _Complaint;
        public ComplaintManager(IComplaintRepository Complaint)
        {
            _Complaint = Complaint;
        }

        public void ComplaintsReplay(Complaint Complaint, string Answer,string ReplyUserID)
        {
            _Complaint.ComplaintsReplay(Complaint, Answer,ReplyUserID);
        }

        public void Create(Complaint t)
        {
            _Complaint.Create(t);
        }

        public void Delete(Complaint t)
        {
            _Complaint.Delete(t);
        }

        public List<Complaint> GetAll()
        {
            return _Complaint.GetAll();
        }

        public Complaint GetById(int Id)
        {
            return _Complaint.GetById(Id);
        }

        public Complaint GetByUser(int id)
        {
            return _Complaint.GetByUser(id);
        }

        public Complaint GetComlaintDepartById(int id)
        {
            return _Complaint.GetComlaintDepartById(id);
        }

        public List<Complaint> GetComplaintDepartment(string UserId)
        {
            return _Complaint.GetComplaintDepartment(UserId);
        }

        public List<Complaint> GetComplaintDepartmentAll()
        {
            return _Complaint.GetComplaintDepartmentAll();
        }

        public void Update(Complaint t)
        {
            _Complaint.Update(t);
        }
    }
}
