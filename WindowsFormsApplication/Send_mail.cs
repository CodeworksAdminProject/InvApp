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
    public partial class Send_mail : Form
    {
        SMTP_CLIENT smtp = new SMTP_CLIENT();
        string filename;
        

        public Send_mail()
        {
            InitializeComponent();
        }

        private void button_AddFile_Click(object sender, EventArgs e)
        {
            //окно выбара файла   (window select file img )
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            newFile.FilterIndex = 1;
            newFile.RestoreDirectory = true;
            try
            {
                if (newFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_Image.Image = Image.FromFile(newFile.FileName);
                    filename = newFile.FileName;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
        }

        private void button_sentEmail_Click(object sender, EventArgs e)
        {
            string body =null;
            if (richTextBox1.Lines.Count() > 1)
            {
                for (int n = 0; n < richTextBox1.Lines.Count(); n++)
                {
                    body = body + richTextBox1.Lines[n].ToString() + "</br>";                    
                }
               
            }
            else {
                
                body = richTextBox1.Text.ToString();
               
            }
            smtp.SentMail(body, "to_cdw@codeworks.by", textBox1.Text, filename);            
        }
    }
}
