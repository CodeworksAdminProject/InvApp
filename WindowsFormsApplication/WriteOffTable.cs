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
        BLL_Buttoms bllButtoms = new BLL_Buttoms();

        string flag_button;

        public WriteOffTable()
        {
            InitializeComponent();
            button_MainTB_Click(null, null);

        }

        private void button_New_data_Click(object sender, EventArgs e)
        {

                string AddId = null;

                foreach (DataGridViewRow row in dataGridView_WriteOffTable.Rows)
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
                    bllButtoms.TakeAway(AddId, flag_button);
                }


            if (flag_button == "MainTB")
            {
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
                Update_Grid(dataGridView_WriteOffTable, flag_button);
            }
            else if (flag_button == "HardWare")
            {
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_HW();
                Update_Grid(dataGridView_WriteOffTable, flag_button);
            }
            else if (flag_button == "HardwareStockRoom")
            {
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_SR();
                Update_Grid(dataGridView_WriteOffTable, flag_button);
            }
        }

        private void button_deleteDataBase_Click(object sender, EventArgs e)
        {
            string AddId = null;

            foreach (DataGridViewRow row in dataGridView_WriteOffTable.Rows)
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
                bllButtoms.Delete(AddId, flag_button);
            }

            if (flag_button == "MainTB")
            {
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
                Update_Grid(dataGridView_WriteOffTable, flag_button);
            }
            else if (flag_button == "HardWare")
            {
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_HW();
                Update_Grid(dataGridView_WriteOffTable, flag_button);
            }
            else if (flag_button == "HardwareStockRoom")
            {
                dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_SR();
                Update_Grid(dataGridView_WriteOffTable, flag_button);
            }
        }

        private void button_MainTB_Click(object sender, EventArgs e)
        {
            flag_button = "MainTB";

            button_hardwarePC.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
            button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            button_MainTB.BackColor = Color.LightGray;
            button_MainTB.ForeColor = Color.Black;

            dataGridView_WriteOffTable.DataSource = null;
            dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();            
            Update_Grid(dataGridView_WriteOffTable, flag_button);
            
        }

        private void button_Hardware_Stockroom_Click(object sender, EventArgs e)
        {
            flag_button = "HardwareStockRoom";

            button_MainTB.ForeColor = button_hardwarePC.ForeColor = Color.MidnightBlue;
            button_MainTB.BackColor = button_hardwarePC.BackColor = Color.White;
            button_Hardware_Stockroom.BackColor = Color.LightGray;
            button_Hardware_Stockroom.ForeColor = Color.Black;

            dataGridView_WriteOffTable.DataSource = null;
            dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_SR();
            Update_Grid(dataGridView_WriteOffTable, flag_button);
        }

        private void button_hardwarePC_Click(object sender, EventArgs e)
        {
            flag_button = "HardWare";

            button_MainTB.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
            button_MainTB.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            button_hardwarePC.BackColor = Color.LightGray;
            button_hardwarePC.ForeColor = Color.Black;

            dataGridView_WriteOffTable.DataSource = null;
            dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_HW();
            Update_Grid(dataGridView_WriteOffTable, flag_button);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (flag_button == "MainTB")
            {
                button_hardwarePC.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
                button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            }
            else if (flag_button == "HardWare")
            {
                button_MainTB.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
                button_MainTB.BackColor = button_Hardware_Stockroom.BackColor = Color.White;

            }
            else if (flag_button == "HardwareStockRoom")
            {
                button_MainTB.ForeColor = button_hardwarePC.ForeColor = Color.MidnightBlue;
                button_MainTB.BackColor = button_hardwarePC.BackColor = Color.White;

            }

            button.ForeColor = Color.Black;
            button.BackColor = Color.LightGray;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (flag_button == "MainTB")
            {
                button_hardwarePC.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
                button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;

            }
            else if (flag_button == "HardWare")
            {
                button_MainTB.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
                button_MainTB.BackColor = button_Hardware_Stockroom.BackColor = Color.White;

            }
            else if (flag_button == "HardwareStockRoom")
            {
                button_MainTB.ForeColor = button_hardwarePC.ForeColor = Color.MidnightBlue;
                button_MainTB.BackColor = button_hardwarePC.BackColor = Color.White;

            }
            else
            {
                button_MainTB.ForeColor = button_hardwarePC.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
                button_MainTB.BackColor = button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;

            }
        }

        private void Update_Grid(DataGridView dataGridView, string tableName)
        {
            if (dataGridView.Rows.Count != 0)
            {

                if (tableName == "MainTB")
                {
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                    dataGridView.Columns["TypeAC"].HeaderCell.Value = "Вид учёта";
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";
                    dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";
                    dataGridView.Columns["Note"].HeaderCell.Value = "Примеччание";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

                else if (tableName == "HardWare")
                {
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";
                    dataGridView.Columns["Note"].HeaderCell.Value = "Примечание";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

                else if (tableName == "HardwareStockRoom")
                {
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";
                    dataGridView.Columns["quantity"].HeaderCell.Value = "Количество";
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";
                    dataGridView.Columns["Note"].HeaderCell.Value = "Примичание";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

            }
        }
    }
}

