using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using COBOAM_Admin.Classes;
using COBOAM_Admin.Properties;

namespace COBOAM_Admin.UserControls.WebAdmin
{
    public partial class Newsletter : UserControl
    {
        private string _filePath = string.Empty;
        private List<string>[] _dbData;
        private readonly BindingSource _subSource = new BindingSource();

        private BulkEmail _bMail;

        private bool Status
        {
            get;
            set;
        }
        public Newsletter()
        {
            InitializeComponent();
        }

        private void DbLoad()
        {

            _dbData = Program.MySql.ExecuteReader(QueryIndex.Subscribers1);
            if (_subSource.Count > 0)
            {
                _subSource.Clear();
            }
            for (int i = 0; i < _dbData[0].Count; i++)
            {
                _subSource.Add(new DBItem(_dbData[1][i], _dbData[2][i]));
            }

        }
        public void Newsletter_Load(object sender = null, EventArgs e = null)
        {
            DbLoad();
            nudYear.Maximum = DateTime.Now.Year + 5;
            nudYear.Value = DateTime.Now.Year;
            List<DBItem> volumeList = new List<DBItem>
            {
                new DBItem("1st Volume","1st Volume"),
                new DBItem("2nd Volume","2nd Volume"),
                new DBItem("3rd Volume","3rd Volume"),
            };
            cbVolume.DataSource = volumeList;
            cbVolume.DisplayMember = "Text";
            cbVolume.ValueMember = "Value";
            cbVolume.SelectedValue = "1st Volume";
            Status = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int current = cbCI.Checked ? 1 : 0;
            int year = Convert.ToInt32(nudYear.Value);
            string volume = cbVolume.SelectedItem.ToString();
            string path = "/newsletter/" + Path.GetFileName(_filePath);
            if (Program.MySql.ExecuteNonQuery(QueryIndex.Newsletter1, path, year, volume, current) != 1) return;
            if (Program.MySql.ExecuteNonQuery(QueryIndex.Logs3, 5, String.Format("{0} uploaded & saved {1} {2}.", Program.uName, year, volume)) == 1)
            {
                MessageBox.Show(Resources.Newsletter_Saved);
            }
        }

        private void bwUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = _filePath;
            string absoluteFileName = Path.GetFileName(fileName);
            FtpWebRequest request = WebRequest.Create(new Uri(string.Format("ftp://{0}:{1}/{2}/{3}", Program.fHost, Program.fPort, "newsletter", absoluteFileName))) as FtpWebRequest;
            if (request == null) return;
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UseBinary = true;
            request.KeepAlive = true;
            request.UsePassive = true;
            request.Credentials = new NetworkCredential(Program.fUN, Program.fPW);
            using (FileStream fs = File.OpenRead(_filePath))
            {
                request.ContentLength = fs.Length;
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(buffer, 0, buffer.Length);
                    requestStream.Flush();
                    requestStream.Close();
                }
                var response = request.GetResponse() as FtpWebResponse;
                if (response == null) return;
                Status = response.StatusCode == FtpStatusCode.ClosingData;
            }
        }

        private void bwUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, Resources.MB_Caption_Error);
            }
            else
            {
                lblUStatus.Text = Status ? "Upload Sucessful" : "Upload failed";
            }
        }

        private void tbFileLocation_Click(object sender, EventArgs e)
        {
            lblUStatus.Text = string.Empty;
            ofdNewsletter.Filter = @"PDF Files (.pdf)|*.pdf";
            ofdNewsletter.FilterIndex = 1;
            DialogResult result = ofdNewsletter.ShowDialog();
            if (result != DialogResult.OK) return;
            _filePath = ofdNewsletter.FileName;
            tbFileLocation.Text = _filePath;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bwUpload.RunWorkerAsync();
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            pBarDistribute.Visible = true;
            pBarDistribute.Maximum = _subSource.Count;
            bwDistribute.RunWorkerAsync();
        }

        private void bwDistribute_DoWork(object sender, DoWorkEventArgs e)
        {
            int size = _subSource.Count;
            pBarDistribute.Maximum = size;
            int[] nOfThreads = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int threads = Functions.GCD(size, nOfThreads);
            string[] emails = new string[size];
            for (int i = 0; i < size; i++)
            {
                emails[i] = ((DBItem)_subSource[i]).Value.ToString();
            }
            _bMail = new BulkEmail(size, threads, emails, "Trumpet Quarterly Newsletter", Resources.Newsletter_Email);
            _bMail.Sent += _bMail_Sent;
            _bMail.Start();

        }

        private void _bMail_Sent(bool status, int i, Exception e)
        {
            if (status)
            {
                UpdateProgress(1);
                UpdateText(string.Format("{0}/{1} emails sent.{2}", (i+1), _subSource.Count,Environment.NewLine));
            }
            else
            {
                throw new Exception(e.Message);
            }
        }

        private void UpdateText(string text)
        {
            if (InvokeRequired)
                Invoke(new Action<string>(UpdateText), text);
            else
                tbLogs.AppendText(text);
            
        }
        private void UpdateProgress(int i)
        {
            if (InvokeRequired)
                Invoke(new Action<int>(UpdateProgress), i);
            else
                pBarDistribute.Value += i;
        }

        private void bwDistribute_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBarDistribute.Value += e.ProgressPercentage;
        }

        private void bwDistribute_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error==null)
            {
                MessageBox.Show(@"Emails distributed.");
            }
        }
    }
}
