using POC.Core.Models;
using POC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Services.Classes
{
    public class SendEmailService : ISendEmailService
    {
        private readonly IHttpService _httpService;
        public SendEmailService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<bool> SendEmail(string To, string Subject, string Body, bool IsHtml, string Cc = "", string Bcc = "")
        {
            EmailData emailData = new()
            {
                To = To,
                Subject = Subject,
                Body = Body,
                IsHtml = IsHtml,
                Cc = string.IsNullOrEmpty(Cc)?"":Cc,
                Bcc = string.IsNullOrEmpty(Bcc)?"":Bcc,
            };

            var result = await _httpService.PostRequest<bool, EmailData>("https://localhost:44373/Email/Send", emailData);

            return result;
        }
    }
}
