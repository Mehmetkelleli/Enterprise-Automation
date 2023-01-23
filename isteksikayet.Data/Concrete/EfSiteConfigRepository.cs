using isteksikayet.Data.Abstract;
using isteksikayet.Data.Context;
using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Data.Concrete
{
    public class EfSiteConfigRepository:EfGenericRepository<SiteConfig,DataContext>,ISiteConfigRepository
    {

    }
}
