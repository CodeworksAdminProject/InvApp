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
        BLL bll = new BLL();

        public WriteOffTable()
        {
            InitializeComponent();
            dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
        }

        private void button_New_data_Click(object sender, EventArgs e)
        {
            WriteOff set = new WriteOff();
            set.Owner = this;
            set.button_OK.Text = "Снять отметку";
            set.ShowDialog();

            if (BLL.flag == true)
            {
                string AddId = null;

                foreach (DataGridViewRow row in dataGridView_WriteOffTable.Rows)
                {
                    if (row.Selected == true)
                    {
                        dal_set.WrittenOff(row.Cells[0].Value.ToString(), "" , "0");
                        if (AddId != null)
                            AddId += "," + row.Cells[0].Value.ToString();
                        else
                            AddId += row.Cells[0].Value.ToString();
                        dal_set.AddFDB(Environment.UserName, 2, BLL.ReasonWriteOff, row.Cells["NumberINV"].Value.ToString(),
                            row.Cells["NameDevice"].Value.ToString(), row.Cells["SN"].Value.ToString(),
                            row.Cells["Model"].Value.ToString(), row.Cells["ID"].Value.ToString());
                    }
                }

                BLL.sHtmlTableTakeAwayWriteOffForReport = BLL.sHtmlTableTakeAwayWriteOffForReport +  bll.WrittenOff_And_Delete(AddId, BLL.sHtmlTableTakeAwayWriteOffForReport, "TakeAway");                
                BLL.ReasonWriteOff = null;
                BLL.flag = false;
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
            }
        }

        private void button_deleteDataBase_Click(object sender, EventArgs e)
        {
            WriteOff set = new WriteOff();
            set.Owner = this;
            set.button_OK.Text = "Улалить";
            set.ShowDialog();

            if (BLL.flag == true)
            {
                string AddId = null;

                foreach (DataGridViewRow row in dataGridView_WriteOffTable.Rows)
                {
                    if (row.Selected == true)
                    {
                        BLL.sHtmlTableDeleteReport = BLL.sHtmlTableDeleteReport + bll.WrittenOff_And_Delete(row.Cells["ID"].Value.ToString(), BLL.sHtmlTableDeleteReport, "Delete");

                        AddId += row.Cells[0].Value.ToString();
                        dal_set.AddFDB(Environment.UserName, 3, BLL.ReasonWriteOff, row.Cells["NumberINV"].Value.ToString(),
                            row.Cells["NameDevice"].Value.ToString(), row.Cells["SN"].Value.ToString(),
                            row.Cells["Model"].Value.ToString(), row.Cells["ID"].Value.ToString());

                        dal_set.Delete("MainTB", row.Cells[0].Value.ToString());
                    }
                }
                BLL.ReasonWriteOff = null;
                BLL.flag = false;

            }
            dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
        }
    }
}

