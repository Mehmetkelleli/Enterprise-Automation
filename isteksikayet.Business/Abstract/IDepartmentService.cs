using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Business.Abstract
{
    public interface IDepartmentService
    {
        void Create(Department t);
        void Update(Department t);
        List<Department> GetAll();
        Department GetById(int Id);
        void Delete(Department t);
        Department GetByIdWidthDepartmant(int id);
    }
}
