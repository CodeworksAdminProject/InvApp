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
    public partial class SN : Form
    {
        public string SNum;

        public SN()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.SerNum = textBox.Text;
            this.Close();
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button.PerformClick();
            }
        }
    }
}
