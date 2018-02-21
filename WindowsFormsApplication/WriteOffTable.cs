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
    public partial class WriteOffTable : Form
    {
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dal_set = new DAL_SET();

        public WriteOffTable()
        {
            InitializeComponent();
            dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
        }

        private void button_New_data_Click(object sender, EventArgs e)
        {

        }
    }
}
