using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace MaxBachat21.Services
{
  public static class OutlookEmail
    {
        public static void SendEmail(string Receiver,string Obj,string path,string OrderID)
        {
            try
            {
               
                Outlook.Application oApp = new Outlook.Application();

           
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add(Receiver);
                oRecip.Resolve();


                oMsg.Subject = Obj;
                oMsg.Body = "Dear Supplier,\nPlease find our Purchase Order attached. In case of any questions / concerns, please contact me.";

                //Add an attachment.
                // TODO: change file path where appropriate
                String sSource = path;
                String sDisplayName = "PO_" + OrderID;
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

                // If you want to, display the message.
                oMsg.Display(true);  //modal

                //Send the message.
              
                //Explicitly release objects.
                oRecip = null;
                oAttach = null;
                oMsg = null;
                oApp = null;
            }

            // Simple error handler.
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
