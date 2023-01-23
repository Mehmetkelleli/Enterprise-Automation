using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Business.Abstract
{
    public interface ISİteConfigService
    {
        void Create(SiteConfig t);
        void Update(SiteConfig t);
        List<SiteConfig> GetAll();
        SiteConfig GetById(int Id);
        void Delete(SiteConfig t);
    }
}
