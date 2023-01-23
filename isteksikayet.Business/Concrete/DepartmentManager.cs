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
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentRepository _Department;
        public DepartmentManager(IDepartmentRepository Department)
        {
            _Department = Department;
        }
        public void Create(Department t)
        {
            _Department.Create(t);
        }

        public void Delete(Department t)
        {
            _Department.Delete(t);
        }

        public List<Department> GetAll()
        {
            return _Department.GetAll();
        }

        public Department GetById(int Id)
        {
            return _Department.GetById(Id);
        }

        public Department GetByIdWidthDepartmant(int id)
        {
            return _Department.GetByIdWidthDepartmant(id);
        }

        public void Update(Department t)
        {
            _Department.Update(t);
        }
    }
}
