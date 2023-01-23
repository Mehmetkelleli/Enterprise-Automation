using isteksikayet.Business.Abstract;
using isteksikayet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Business.Concrete
{
    public class DataAdd : IDataAdd
    {
        private ISİteConfigService _Config;
        public DataAdd(ISİteConfigService Config)
        {
            _Config = Config;
        }
        public void DataInitializer()
        {
           
            if (_Config.GetById(1) == null)
            {
                var config = new SiteConfig();
                config.Smtp = "smtp-mail.outlook.com";
                config.SmtpPort = 587;
                config.SmtpUser = "kelleli_mehmet@hotmail.com";
                config.SmtpPassword = "Aslanlar123";
                _Config.Create(config);
            }
        }
    }
}
