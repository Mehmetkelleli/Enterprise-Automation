using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Data.Abstract
{
    public interface IDepartmentRepository:IGenericRepository<Department>
    {
        Department GetByIdWidthDepartmant(int id);
    }
}
