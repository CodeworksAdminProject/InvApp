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
    public partial class HardWare : Form
    {
        DAL_GET getDAL = new DAL_GET();
        BLL_Buttoms bllButtoms = new BLL_Buttoms();
        
        public HardWare()
        {
            InitializeComponent();           
            dataGridView_HardWare.DataSource = getDAL.GetHardWare(MainFrorm.index);
            dataGridView_HardWare.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView_HardWare.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic); //жирный курсив размера 16 FontStyle.Italic
            if (dataGridView_HardWare.DataSource != null)
            {
                dataGridView_HardWare.Columns["ID"].Visible = false;
                dataGridView_HardWare.Columns["SN"].Visible = false;
                dataGridView_HardWare.Columns["TypeHardWare"].HeaderCell.Value = "Наименование:";
                dataGridView_HardWare.Columns["Model"].HeaderCell.Value = "Модель устройства:";
            }


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string AddId = null;

            foreach (DataGridViewRow row in dataGridView_HardWare.Rows)
            {
                if (row.Selected == true)
                {

                    if (AddId != null)
                        AddId += "," + row.Cells["ID"].Value.ToString();
                    else
                        AddId += row.Cells[0].Value.ToString();
                }
            }

            if (AddId != null)
            {
                bllButtoms.Writtenoff(AddId, "HardWare");                
            }
        }

        private void button_New_data_Click(object sender, EventArgs e)
        {
            SetNewDataBase setNewData = new SetNewDataBase();
            setNewData.checkBox_MainAcount.Checked = false;
            setNewData.checkBox_Stockroom.Checked = false;
            setNewData.checkBox_MainAcount.Enabled = false;
            setNewData.checkBox_Stockroom.Enabled = false;
            setNewData.checkBox_Hardware.Checked = true;
            setNewData.checkBox_SetHardware.Checked = true;
            setNewData.checkBox_Hardware.Enabled = false;
            setNewData.checkBox_SetHardware.Enabled = false;


           setNewData.ShowDialog();
        }
    }
}
