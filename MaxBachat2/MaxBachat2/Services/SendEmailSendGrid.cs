using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.Controls.StatusBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxBachat2.Services
{
    class SendEmailSendGrid
    {
        static public bool Send(string sendername, string to, string subj, string files, string SuccessMsg)
        {
            try {
                MailMessage mail = new MailMessage("ateeb.i@Maxbachat.com", to);

                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.Host = "smtp.sendgrid.net";
                client.Credentials = new System.Net.NetworkCredential("apikey", "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");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                Attachment attachment = new Attachment(files);
                mail.Attachments.Add(attachment);
                mail.Subject = subj;
                mail.Body = "Purchase Order";
                client.Send(mail);
                return true;
            }
            catch { return false; }
            }
    }
}
