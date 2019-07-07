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
        public string ID;
        public string INV;
        public string NAME;
        public string SN;
        public string RES;



        public HardWare()
        {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData()
        {
            dataGridView_HardWare.DataSource = getDAL.GetHardWare(MainFrorm.index);
            dataGridView_HardWare.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView_HardWare.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic); //жирный курсив размера 16 FontStyle.Italic
            if (dataGridView_HardWare.DataSource != null)
            {
                dataGridView_HardWare.Columns["ID"].Visible = false;
                // dataGridView_HardWare.Columns["SN"].Visible = false;
                dataGridView_HardWare.Columns["NameLAN"].Visible = false;
                dataGridView_HardWare.Columns["NumberINV"].HeaderCell.Value = "Инвинтарный номер:";
                dataGridView_HardWare.Columns["TypeHardWare"].HeaderCell.Value = "Наименование:";
                dataGridView_HardWare.Columns["Model"].HeaderCell.Value = "Модель устройства:";
                dataGridView_HardWare.Columns["SN"].HeaderCell.Value = "SN:";
                dataGridView_HardWare.Columns["Note"].HeaderCell.Value = "Примечание:";
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
            setNewData.groupBox_Hardware_LanName.Enabled = false;
            setNewData.label_ID.Visible = true;
            setNewData.ID.Visible = true;
            setNewData.label_ID.Text = ID;
            setNewData.label_NAME.Visible = true;
            setNewData.NAME.Visible = true;
            setNewData.label_NAME.Text = NAME;
            setNewData.label_INV.Visible = true;
            setNewData.INV.Visible = true;
            setNewData.label_INV.Text = INV;
            setNewData.label_SN.Visible = true;
            setNewData.SN.Visible = true;
            setNewData.label_SN.Text = SN;
            setNewData.label_RES.Visible = true;
            setNewData.RES.Visible = true;
            setNewData.label_RES.Text = RES;

            setNewData.ShowDialog();
        }

        private void button_deleteDataBase_Click(object sender, EventArgs e)
        {
            string AddId = null;

            foreach (DataGridViewRow row in dataGridView_HardWare.Rows)
            {
                if (row.Selected == true)
                {

                    if (AddId != null)
                        AddId += "," + row.Cells["ID"].Value.ToString();
                    else
                        AddId += row.Cells["ID"].Value.ToString();
                }
            }

            if (AddId != null)
            {
                bllButtoms.Delete(AddId, "HardWare");
            }
            UpdateData();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_HardWare.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGridView_HardWare.Rows)
                {
                    string Lan = null;
                    Lan = row.Cells["NameLAN"].Value.ToString();

                    if (row.Selected == true)
                    {

                        bllButtoms.Move_Hardware(row.Cells["ID"].Value.ToString(),
                            row.Cells["NumberINV"].Value.ToString(),
                            row.Cells["TypeHardWare"].Value.ToString(),
                            row.Cells["Model"].Value.ToString(),
                            row.Cells["SN"].Value.ToString(),
                            row.Cells["JiraTask"].Value.ToString(),
                            Lan, "HardWare",
                            row.Cells["Note"].Value.ToString());
                    }
                }
            }

            else
                MessageBox.Show("Количество выбранных объектов превышает допустимое значение (одна позиции за раз)",
               "Боливар не вынесет двоих", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            UpdateData();
        }
    }
}
