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
    public class SiteCOnfigManager : ISİteConfigService
    {
        private ISiteConfigRepository _Setting;
        public SiteCOnfigManager(ISiteConfigRepository Setting)
        {
            _Setting = Setting;
        }
        public void Create(SiteConfig t)
        {
            _Setting.Create(t);
        }

        public void Delete(SiteConfig t)
        {
            _Setting.Delete(t);
        }

        public List<SiteConfig> GetAll()
        {
           return _Setting.GetAll();
        }

        public SiteConfig GetById(int Id)
        {
            return _Setting.GetById(Id);
        }

        public void Update(SiteConfig t)
        {
            _Setting.Update(t);
        }
    }
}
