using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelNO_Analyzer
{
    class SendEmail
    {
     static public void Send(string sendername,string to,string subj,string body,string SuccessMsg)
        {

            // Replace sender@example.com with your "From" address. 
            // This address must be verified with Amazon SES.
            String FROM = "ateeb@MaxBachat.com";
            String FROMNAME = sendername;

            // Replace recipient@example.com with a "To" address. If your account 
            // is still in the sandbox, this address must be verified.
            String TO = to; 

            // Replace smtp_username with your Amazon SES SMTP user name.
            String SMTP_USERNAME = "zeesi@toptenseo.de";

            // Replace smtp_password with your Amazon SES SMTP user name.
            String SMTP_PASSWORD = "G+jevtwa4c0zT-";

            // (Optional) the name of a configuration set to use for this message.
            // If you comment out this line, you also need to remove or comment out
            // the "X-SES-CONFIGURATION-SET" header below.
            String CONFIGSET = "ConfigSet";

            // If you're using Amazon SES in a region other than US West (Oregon), 
            // replace email-smtp.us-west-2.amazonaws.com with the Amazon SES SMTP  
            // endpoint in the appropriate AWS Region.
            //smtp.1und1.de
            String HOST = "smtp.1und1.de";

            // The port you will connect to on the Amazon SES SMTP endpoint. We
            // are choosing port 587 because we will use STARTTLS to encrypt
            // the connection.
            int PORT = 25;

            // The subject line of the email
            String SUBJECT = subj;

            // The body of the email
            String BODY = body;
          
            // Create and build a new MailMessage object
            MailMessage message = new MailMessage();
            message.IsBodyHtml = false;
            message.From = new MailAddress(FROM, FROMNAME);
            message.To.Add(new MailAddress(TO));
            message.Subject = SUBJECT;
            message.Body = BODY;
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("Order.pdf");
            message.Attachments.Add(attachment);
            // Comment or delete the next line if you are not using a configuration set
            message.Headers.Add("X-SES-CONFIGURATION-SET", CONFIGSET);

            using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Pass SMTP credentials
                client.Credentials =
                    new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                // Enable SSL encryption
                client.EnableSsl = true;

                // Try to send the message. Show status in console.
                try
                {
   //                  MailAddress copy = new MailAddress("jobarchiv@toptenseo.de"); //emailCC
//                    message.CC.Add(copy);
              
                    client.Send(message);
                 
                 //   AutoClosingMessageBox.Show(SuccessMsg, "Email Sent", 10000);
                 
                // MessageBox.Show(SuccessMsg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The email was not sent.");
                    MessageBox.Show("Error message: " + ex.Message);
                }
            }


        }

    }
}
