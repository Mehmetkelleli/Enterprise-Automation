using isteksikayet.Data.Abstract;
using isteksikayet.Data.Context;
using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Data.Concrete
{
    public class EfDepartmentRepository : EfGenericRepository<Department, DataContext>, IDepartmentRepository
    {
        public Department GetByIdWidthDepartmant(int id)
        {
            using(var db = new DataContext())
            {
                return db.Departments.Include(i => i.Complaint).FirstOrDefault(i => i.Id == id);
            }
        }
    }
}
