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
    public partial class JBD : Form
    {
        DAL_GET dal = new DAL_GET();
        public JBD()
        {
            InitializeComponent();
        }

        private void button_Room_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB();
        }
    }
}
