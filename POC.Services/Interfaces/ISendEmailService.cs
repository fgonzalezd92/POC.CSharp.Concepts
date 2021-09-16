using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Services.Interfaces
{
    public interface ISendEmailService
    {
        public Task<bool> SendEmail(string To, string Subject, string Body, bool IsHtml, string Cc = "", string Bcc = "");
    }
}
