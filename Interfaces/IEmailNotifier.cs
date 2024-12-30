using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupujemProdajemWebScraping.Interfaces
{
    public interface IEmailNotifier
    {
        Task SendEmailAsync(string recipient, string subject, string body);
    }
}
