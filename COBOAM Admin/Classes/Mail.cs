using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace COBOAM_Admin.Classes
{
    class Mail
    {
        private bool _mailSent;
        public void SendEmail(string toEmail, string subject, string body)
        {
            _mailSent = false;
            using (SmtpClient client = new SmtpClient { UseDefaultCredentials = false })
            {
                client.Credentials = new NetworkCredential("webmaster@channelofblessings.com","asshole23");
                client.SendCompleted += ClientOnSendCompleted;
                using (MailMessage message = new MailMessage())
                {

                    message.To.Add(toEmail); // BREAKPOINT will be here
                    message.IsBodyHtml = true;
                    message.Subject = subject;
                    message.Body = body;
                    try
                    {
                        client.Send(message);
                    }
                    catch (SmtpException ex)
                    {
                        throw new Exception(ex.Message, ex.InnerException);
                    }
                    //return smtp.
                }
            }
        }

        public bool Status
        {
            get { return _mailSent;}

        }
        private void ClientOnSendCompleted(object sender, AsyncCompletedEventArgs asyncCompletedEventArgs)
        {
            _mailSent = true;
        }
    }
}
