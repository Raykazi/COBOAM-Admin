using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;
using COBOAM_Admin.UserControls.WebAdmin;

namespace COBOAM_Admin.Classes
{
    class Mail
    {
        private readonly SmtpClient _client = new SmtpClient
        {
            UseDefaultCredentials = false,
            Host = Program.sHost,
            Port = Program.sPort,
            Credentials = new NetworkCredential(Program.sUN, Program.sPW)
        };

        public bool Status { get; private set; }
        private string Subject { get; set; }
        private string Message { get; set; }
        private string Address { get; set; }
        private string[] Addresses { get; set; }

        public delegate void OnSent(bool status, int i = 0, Exception e = null);
        public event OnSent Sent;

        protected Mail(string toEmail, string subject, string message)
        {
            Address = toEmail;
            Subject = subject;
            Message = message;
        }

        protected Mail(string[] to, string subject, string message)
        {
            Addresses = to;
            Subject = subject;
            Message = message;
        }

        internal void Send()
        {
            Status = false;
            using (MailMessage message = new MailMessage())
            {
                message.To.Add(Address); // BREAKPOINT will be here
                message.IsBodyHtml = true;
                message.Subject = Subject;
                message.Body = Message;
                try
                {
                    _client.Send(message);
                    if (Sent != null)
                        Sent(true);
                }
                catch (SmtpException ex)
                {
                    if (Sent != null)
                        Sent(false, 0, ex);
                }
            }

        }

        internal ManualResetEvent Send(int i, ManualResetEvent doneEvent)
        {
            using (MailMessage message = new MailMessage())
            {
                message.IsBodyHtml = true;
                message.Body = Message;
                message.Subject = Subject;
                message.To.Add(Addresses[i]);
                try
                {
                    _client.Send(message);
                    if (Sent != null)
                        Sent(true, i);
                }
                catch (SmtpException ex)
                {
                    if (Sent != null)
                        Sent(false, 0, ex);
                }
                return doneEvent;
            }
        }
    }

    class Email : Mail
    {
        public Email(string to, string subject, string message)
            : base(to, subject, message)
        {

        }
    }
    class BulkEmail : Mail
    {
        private ManualResetEvent _doneEvent;
        private int TotalMail { get; set; }
        private int MailCount { get; set; }
        private int AddCount { get; set; }
        private int Counter { get; set; }
        private int AssignI { get; set; }
        private readonly int _nThreads;


        public BulkEmail(int totalMail, int threads, string[] address, string subject, string message)
            : base(address, subject, message)
        {
            TotalMail = totalMail;
            _nThreads = threads;
            MailCount = TotalMail / _nThreads;
            AddCount = MailCount;
        }

        internal void Start()
        {
            ManualResetEvent[] doneEvents = new ManualResetEvent[MailCount];
            for (int i = AssignI; i < MailCount; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);
                _doneEvent = Send(i, doneEvents[i]);
                ThreadPool.QueueUserWorkItem(ThreadPoolCallback, i);
            }
            Counter = Counter + 1;
            CheckBatchMailProcess();
        }
        void CheckBatchMailProcess()
        {
            if (Counter >= _nThreads) return;
            MailCount += AddCount;
            AssignI = MailCount - AddCount;
            Start();
        }
        private void ThreadPoolCallback(Object threadContext)
        {
            _doneEvent.Set();
        }
    }
}
