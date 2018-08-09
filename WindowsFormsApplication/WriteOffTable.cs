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

        string flag_button;

        public WriteOffTable()
        {
            InitializeComponent();
            button_MainTB_Click(null, null);

        }

        private void button_New_data_Click(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
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
                            dal_set.WrittenOff(row.Cells[0].Value.ToString(), "", "0");
                            if (AddId != null)
                                AddId += "," + row.Cells[0].Value.ToString();
                            else
                                AddId += row.Cells[0].Value.ToString();
                            dal_set.AddFDB(Environment.UserName, 2, BLL.ReasonWriteOff, row.Cells["NumberINV"].Value.ToString(),
                                row.Cells["NameDevice"].Value.ToString(), row.Cells["SN"].Value.ToString(),
                                row.Cells["Model"].Value.ToString(), row.Cells["ID"].Value.ToString());
                        }
                    }

                    BLL.sHtmlTableTakeAwayWriteOffForReport = BLL.sHtmlTableTakeAwayWriteOffForReport + bll.WrittenOff_And_Delete(AddId, BLL.sHtmlTableTakeAwayWriteOffForReport, "TakeAway");
                    BLL.ReasonWriteOff = null;
                    BLL.flag = false;
                    dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable();
                }
            }

            else if (flag_button == "HardWare")
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
                            dal_set.WrittenOff(row.Cells[0].Value.ToString(), "", "0");
                            if (AddId != null)
                                AddId += "," + row.Cells[0].Value.ToString();
                            else
                                AddId += row.Cells[0].Value.ToString();
                            dal_set.AddFDB(Environment.UserName, 2, BLL.ReasonWriteOff, row.Cells["NumberINV"].Value.ToString(),
                                row.Cells["NameDevice"].Value.ToString(), row.Cells["SN"].Value.ToString(),
                                row.Cells["Model"].Value.ToString(), row.Cells["ID"].Value.ToString());
                        }
                    }

                    BLL.sHtmlTableTakeAwayWriteOffForReport = BLL.sHtmlTableTakeAwayWriteOffForReport + bll.WrittenOff_And_Delete(AddId, BLL.sHtmlTableTakeAwayWriteOffForReport, "TakeAway");
                    BLL.ReasonWriteOff = null;
                    BLL.flag = false;
                    dataGridView_WriteOffTable.DataSource = dal_get.getWrateOffTable_HW();
                }
            }

            else if (flag_button == "HardwareStockRoom")
            {

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

