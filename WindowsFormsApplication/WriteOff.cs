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

        private void button1_Click(object sender, EventArgs e)
        {
            MainFrorm main = this.Owner as MainFrorm;

            if (this.reason.Text == "" || this.reason.Text.Length > 50)
            {
                MessageBox.Show("Причина  не указана или  более  50 символов ");
            }
            else
            {
                if (main != null)
                {
                    main.flag = true;
                    main.ReasonWriteOff = this.reason.Text;
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}