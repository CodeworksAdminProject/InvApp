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
    public partial class ChangeHardWare : Form
    {
        DAL_GET dalGet = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();
        BLL_Buttoms bllButtoms = new BLL_Buttoms();
        string IDs = null;
        public static string flag;

        public ChangeHardWare()
        {
            InitializeComponent();
            foreach (string[] str in BLL.ArrayChancge)
            {
                if (IDs == null)
                    IDs = str[0];
                else
                    IDs = IDs + "," + str[0];
            }
            if (IDs != null)
                Data_from_DataGrid(dataGridView);

            comboBox_Device.DataSource = dalGet.Get_Data_From_Table_From_Colunm("TypeHardWare", "TypeHardWare");
            comboBox_Device.DisplayMember = "TypeHardWare";
            comboBox_Device.ValueMember = "TypeHardWare";

            comboBox_jira.DataSource = dalGet.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_jira.DisplayMember = "JiraTask";
            comboBox_jira.ValueMember = "JiraTask";


        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (flag == "HardWare")
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    dalSet.change(row.Cells["ID"].Value.ToString(),
                                       row.Cells["NumberINV"].Value.ToString(),
                                       bll.Get_ID("TypeHardWare", "TypeHardWare", row.Cells["TypeHardWare"].Value.ToString()).ToString(),
                                       row.Cells["SN"].Value.ToString(),
                                       row.Cells["Model"].Value.ToString(),
                                       bll.Get_ID("JiraTask", "JiraTask", row.Cells["JiraTask"].Value.ToString()).ToString(),
                                       row.Cells["Note"].Value.ToString());
                }
            }


            else if (flag == "HardwareStockRoom")
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    int number;
                    bool result = Int32.TryParse(row.Cells["quantity"].Value.ToString(), out number);
                    if (result)
                    {
                        dalSet.change(row.Cells["ID"].Value.ToString(),
                                      number,
                                      row.Cells["NumberINV"].Value.ToString(),
                                      bll.Get_ID("TypeHardWare", "TypeHardWare", row.Cells["TypeHardWare"].Value.ToString()).ToString(),
                                      row.Cells["SN"].Value.ToString(),
                                      row.Cells["Model"].Value.ToString(),
                                      bll.Get_ID("JiraTask", "JiraTask", row.Cells["JiraTask"].Value.ToString()).ToString(),
                                      row.Cells["Note"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Строка с ID: " + row.Cells["ID"].Value.ToString() +
                            ", потому как в графу 'Количество' вы вписали вместо числа вот это: " +
                            row.Cells["quantity"].Value.ToString(), "Не то пальто", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                       
                    
                }
            }

            BLL.ArrayChancge.Clear();
            this.Close();
        }

        private void checkBox_Device_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Device.Checked == true)
            {
                textBox_Device.Enabled = true;
                comboBox_Device.Enabled = false;
            }

            else
            {
                textBox_Device.Enabled = false;
                comboBox_Device.Enabled = true;
            }
        }

        private void checkBox_jira_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_jira.Checked == true)
            {
                textBox_jira.Enabled = true;
                comboBox_jira.Enabled = false;
            }

            else
            {
                textBox_jira.Enabled = false;
                comboBox_jira.Enabled = true;
            }
        }
        private void Data_from_DataGrid(DataGridView dataGridView)
        {
            if (flag == "HardWare")
            {
                dataGridView.DataSource = dalGet.Table_Change_data_HW(IDs);
                if (dataGridView.DataSource != null)
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                    dataGridView.Columns["ID"].ReadOnly = true;
                    dataGridView.Columns["ID"].DefaultCellStyle.BackColor = Color.Lavender;


                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                    dataGridView.Columns["dateCreated"].ReadOnly = true;
                    dataGridView.Columns["dateCreated"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_LanName;
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";
                    dataGridView.Columns["NameLAN"].ReadOnly = true;
                    dataGridView.Columns["NameLAN"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_ResName;
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";
                    dataGridView.Columns["NameRes"].ReadOnly = true;
                    dataGridView.Columns["NameRes"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_Floor;
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";
                    dataGridView.Columns["floorNambe"].ReadOnly = true;
                    dataGridView.Columns["floorNambe"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_Room;
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";
                    dataGridView.Columns["NameRoom"].ReadOnly = true;
                    dataGridView.Columns["NameRoom"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["TypeHardWare"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_TypeDiv;
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";
                    dataGridView.Columns["TypeHardWare"].ReadOnly = true;
                    dataGridView.Columns["TypeHardWare"].DefaultCellStyle.BackColor = Color.AliceBlue;

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                    dataGridView.Columns["JiraTask"].ReadOnly = true;
                    dataGridView.Columns["JiraTask"].DefaultCellStyle.BackColor = Color.AliceBlue;

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";
                    dataGridView.Columns["WrittenOff"].ReadOnly = true;
                    dataGridView.Columns["WrittenOff"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.Columns["Note"].Visible = Properties.Settings.Default.ChangeFormTwo_hardware_Note;
                    dataGridView.Columns["Note"].HeaderCell.Value = "Примичание";


                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);
                }
            }

            else if (flag == "HardwareStockRoom")
            {
                dataGridView.DataSource = dalGet.Table_Change_data_SR(IDs);
                if (dataGridView.DataSource != null)
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                    dataGridView.Columns["ID"].ReadOnly = true;
                    dataGridView.Columns["ID"].DefaultCellStyle.BackColor = Color.Lavender;


                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                    dataGridView.Columns["dateCreated"].ReadOnly = true;
                    dataGridView.Columns["dateCreated"].DefaultCellStyle.BackColor = Color.Lavender;


                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["quantity"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_Quantity;
                    dataGridView.Columns["quantity"].HeaderCell.Value = "Количество";

                    dataGridView.Columns["TypeHardWare"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_TypeDiv;
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";
                    dataGridView.Columns["TypeHardWare"].ReadOnly = true;
                    dataGridView.Columns["TypeHardWare"].DefaultCellStyle.BackColor = Color.AliceBlue;


                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                    dataGridView.Columns["JiraTask"].ReadOnly = true;
                    dataGridView.Columns["JiraTask"].DefaultCellStyle.BackColor = Color.AliceBlue;

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";
                    dataGridView.Columns["WrittenOff"].ReadOnly = true;
                    dataGridView.Columns["WrittenOff"].DefaultCellStyle.BackColor = Color.Lavender;

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.Columns["Note"].Visible = Properties.Settings.Default.ChangeFormTwo_stockroom_Note;
                    dataGridView.Columns["Note"].HeaderCell.Value = "Примичание";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);
                }
            }
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            BLL.ArrayChancge.Clear();
            this.Close();
        }

        private void ChangeHardWare_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.ArrayChancge.Clear();
        }

        private void update_tabe(string value, string nameColunm)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (
                   row.Selected == true ||
                   row.Cells["ID"].Selected == true ||
                   row.Cells["dateCreated"].Selected == true ||
                   row.Cells["TypeAC"].Selected == true ||
                   row.Cells["NumberINV"].Selected == true ||
                   row.Cells["NameLAN"].Selected == true ||
                   row.Cells["NameRes"].Selected == true ||
                   row.Cells["floorNambe"].Selected == true ||
                   row.Cells["NameRoom"].Selected == true ||
                   row.Cells["NameDevice"].Selected == true ||
                   row.Cells["Model"].Selected == true ||
                   row.Cells["SN"].Selected == true ||
                   row.Cells["JiraTask"].Selected == true ||
                   row.Cells["WrittenOff"].Selected == true ||
                   row.Cells["ReasonWriteOff"].Selected == true
                   )
                {
                    row.Cells[nameColunm].Value = value;
                }
            }
        }

        private void comboBox_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_tabe(comboBox_Device.SelectedValue.ToString(), "TypeHardWare");
        }

        private void comboBox_jira_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_tabe(comboBox_jira.SelectedValue.ToString(), "JiraTask");
        }

        private void textBox_jira_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                update_tabe(textBox_jira.Text, "JiraTask");
            }
        }

        private void comboBox_Device_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                update_tabe(textBox_Device.Text, "TypeHardWare");
            }
        }

        private void button_writtenoff_Click(object sender, EventArgs e)
        {
            string AddId = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
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
                bllButtoms.Writtenoff(AddId, flag);
            }

            Data_from_DataGrid(dataGridView);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string AddId = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
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
                bllButtoms.Delete(AddId, flag);
            }

            Data_from_DataGrid(dataGridView);
        }
    }
}
