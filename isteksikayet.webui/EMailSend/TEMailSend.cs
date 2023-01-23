using isteksikayet.Business.Abstract;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace isteksikayet.webui.EMailSend
{
    public class TEMailSend : IEMailSend
    {
        private ISİteConfigService _Setting;

        public TEMailSend(ISİteConfigService Setting)
        {
            _Setting = Setting;
        }
        public Task Send(string Mail, string Subject, string Html)
        {
            var setting = _Setting.GetById(1);
            var client = new SmtpClient(setting.Smtp, setting.SmtpPort)
            {
                Credentials = new NetworkCredential(setting.SmtpUser, setting.SmtpPassword),
                EnableSsl = true
            };
            return client.SendMailAsync(
                new MailMessage(setting.SmtpUser, Mail, Subject, Html)
                {
                    IsBodyHtml = true

                }
                );
        }
    }
}
