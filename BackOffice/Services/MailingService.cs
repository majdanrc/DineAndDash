using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using DaD.DAL.Dto;

namespace DaD.BackOffice.Services
{
    public class MailingService
    {
        public bool SendOrder(OrderDto orderDto)
        {
            try
            {
                var mailFrom = ConfigurationManager.AppSettings["mailFrom"];
                var mailTo = ConfigurationManager.AppSettings["mailTo"];
                var smtpServer = ConfigurationManager.AppSettings["smtpServer"];
                int smtPort;
                int.TryParse(ConfigurationManager.AppSettings["smtpPort"], out smtPort);
                var mailPassword = ConfigurationManager.AppSettings["mailPassword"];

                var fromAddress = new MailAddress(mailFrom, "");
                var toAddress = new MailAddress(mailTo, "");
                var subject = string.Format("{0} {1} - {2}",
                    "Zamówienie nr ",
                    orderDto.Id,
                    orderDto.CreatedOn.ToString(CultureInfo.InvariantCulture));
                var body = BuildBody(orderDto);

                using (
                    var smtp = new SmtpClient
                    {
                        Host = smtpServer,
                        Port = smtPort,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, mailPassword)
                    })
                {
                    var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    smtp.Send(message);
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                return false;
            }

            return true;
        }

        private string BuildBody(OrderDto orderDto)
        {
            var sb = new StringBuilder();

            sb.Append("<h2>Zamówienie:</h2>");

            sb.Append("<ul>");
            foreach (var orderItem in orderDto.OrderItems.Where(o => !o.Extra))
            {
                sb.Append(string.Format("<li>{0}", orderItem.ItemName));

                if (orderItem.Extras.Any())
                {
                    sb.Append("<ul>");
                    foreach (var orderItemExtra in orderItem.Extras)
                    {
                        sb.Append(string.Format("<li>{0}</li>", orderItemExtra.ItemName));
                    }
                    sb.Append("</ul>");
                }

                sb.Append("</li>");
            }
            sb.Append("</ul>");

            if (!string.IsNullOrWhiteSpace(orderDto.Notes))
            {
                sb.Append("<br /><h3>uwagi</h3>");
                sb.Append(orderDto.Notes);
            }

            return sb.ToString();
        }
    }
}
