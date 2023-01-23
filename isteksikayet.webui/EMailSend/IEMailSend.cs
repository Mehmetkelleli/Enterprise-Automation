using System.Threading.Tasks;

namespace isteksikayet.webui.EMailSend
{
    public interface IEMailSend
    {
        Task Send(string Mail, string Subject, string Html);  
    }
}
