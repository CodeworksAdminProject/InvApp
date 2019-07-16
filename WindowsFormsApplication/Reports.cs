using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Reports : Form
    {
        public string[] ids;
        String Data = System.DateTime.Now.ToString("yyyy-MM-dd");
        BLL_REPORTS bll = new BLL_REPORTS();
        string type;
        


        public Reports()
        {
            InitializeComponent();
            textBox_exc_file.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString()+@"\";
            textBox_exc_mail.Text = Properties.Settings.Default.Email;
            
        }



        private void button_exc_file_Click(object sender, EventArgs e)
        {
            type = "files";
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            textBox_exc_file.Enabled = false;
            textBox_exc_mail.Enabled = false;
            backgroundWorker1.RunWorkerAsync(type);
        }


        private void button_exc_mail_Click(object sender, EventArgs e)
        {
            type = "mail";
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            textBox_exc_file.Enabled = false;
            textBox_exc_mail.Enabled = false;
            backgroundWorker1.RunWorkerAsync(type);
        }
         
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                if (type == "mail")
                {
                    SMTP_CLIENT_REPORT email = new SMTP_CLIENT_REPORT();

                    string fileName = System.IO.Path.GetTempPath() + Properties.Settings.Default.namefile + "_" + Data + ".xls";
                    backgroundWorker1.ReportProgress(10);
                    bll.excel(fileName);
                    backgroundWorker1.ReportProgress(75);
                    email.SentMail("EXCEL за " + Data + ", от " + Environment.UserName, textBox_exc_mail.Text, "EXCEL за " + Data, fileName);
                    backgroundWorker1.ReportProgress(100);
                    MessageBox.Show("Письмо отправлено!", "Sent mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    string fileName = textBox_exc_file.Text + Properties.Settings.Default.namefile + "_" + Data + ".xls";
                    backgroundWorker1.ReportProgress(10);
                    bll.excel(fileName);
                    backgroundWorker1.ReportProgress(100);
                    MessageBox.Show("Файл сохранен!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            textBox_exc_file.Enabled = true;
            textBox_exc_mail.Enabled = true;            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
