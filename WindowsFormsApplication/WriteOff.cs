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
    public partial class WriteOff : Form
    {


        public WriteOff()
        {
            InitializeComponent();

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            int chars;
            string resons;
            int origin;

            if (info.Text == "До 120 символов")
            {
                chars = 120;
                resons = "Более " + chars + " символов";
                origin = -1;
            }
            else
            {
                chars = 50;
                resons = "Причина  не указана или  более " + chars + " символов";
                origin = 0;
            }

            if (this.reason.Text.Length == origin || this.reason.Text.Length > chars)
            {
                MessageBox.Show(resons);
            }
            else
            {
                BLL.flag = true;
                BLL.ReasonWriteOff = this.reason.Text;
                this.Close();
            }            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

  