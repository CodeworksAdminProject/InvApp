using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApplication
{
    public partial class Settings : Form
    {
      
        public Settings()
        {
            InitializeComponent();
            textBox_SqlServer.Text = Properties.Settings.Default.SqlServer;
            textBox_SqlPort.Text = Properties.Settings.Default.SqlPort;
            textBox_Mail.Text = Properties.Settings.Default.Email;
            textBox_LogatipPath.Text = Properties.Settings.Default.ImgPath;
            textBox_NameDB.Text = Properties.Settings.Default.SqlDataBase;
            comboBox_navigation.SelectedIndex = Properties.Settings.Default.int_navigation;
            comboBox__print_BarKod.SelectedIndex = Properties.Settings.Default.inr_barcod;

            if (Properties.Settings.Default.ImgPath != "")
                pictureBox_Image.Image = Image.FromFile(Properties.Settings.Default.ImgPath);
            
        }

        private void button_NewImaje_Click(object sender, EventArgs e)
        {
            //окно выбара файла   (window select file img )
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            newFile.FilterIndex = 1;
            newFile.RestoreDirectory = true;
            try
            {
                if(newFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_Image.Image = Image.FromFile(newFile.FileName);
                    textBox_LogatipPath.Text = newFile.FileName;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SqlServer = textBox_SqlServer.Text ;
            Properties.Settings.Default.SqlPort = textBox_SqlPort.Text;
            Properties.Settings.Default.Email =textBox_Mail.Text ;
            Properties.Settings.Default.ImgPath= textBox_LogatipPath.Text;
            Properties.Settings.Default.SqlDataBase = textBox_NameDB.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Настройки сохранены");
            Properties.Settings.Default.int_navigation = comboBox_navigation.SelectedIndex;
            Properties.Settings.Default.inr_barcod = comboBox__print_BarKod.SelectedIndex;

        }
    }
}
