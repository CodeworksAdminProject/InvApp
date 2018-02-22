using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace WindowsFormsApplication
{
    public partial class Delete : Form
    {
        
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();
        ArrayList DataINV = new ArrayList();


        public Delete()
        {
            InitializeComponent();
                      
            DataINV = dal_get.GetForSetForms();

            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            
            dataGridView1.DataSource = DataINV;
            if (BLL.Data.Count > 0)
            {
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["dateCreated"].Visible = false;
                dataGridView1.Columns["NameLAN"].Visible = false;
                dataGridView1.Columns["NameRes"].Visible = false;
                dataGridView1.Columns["floorNambe"].Visible = false;
                dataGridView1.Columns["NameRoom"].Visible = false;
            }
        }
      
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            label_TD.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            label_NS.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            label_M.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
         
        private void button_Dell_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    DialogResult dialogResult = MessageBox.Show(("Инвентарный номер:\t" + row.Cells[1].Value.ToString() +
                          "\nТип устройства:\t\t" + row.Cells[6].Value.ToString() +
                          "\nСерийный номер:\t\t" + row.Cells[7].Value.ToString() +
                          "\nМодель:\t\t\t" + row.Cells[8].Value.ToString())  +
                          "\nпричине:\t\t\t" + textBox_Reason.Text, "Подтверждение отметка о снятии с учета", MessageBoxButtons.OKCancel);

                    if (dialogResult == DialogResult.OK)
                    {
                        bll.Delete(row.Cells[2].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(), textBox_Reason.Text);

                       // dalSet.WrittenOff(row.Cells[0].Value.ToString());
                    }
                    else if (dialogResult == DialogResult.No) { }                                        
                }
            }

            DataINV = dal_get.GetForSetForms();
            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            dataGridView1.DataSource = DataINV;
        }

        private void Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.Data.Clear();
        }
    }
}
