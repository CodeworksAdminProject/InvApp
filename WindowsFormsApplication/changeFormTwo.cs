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
    public partial class changeFormTwo : Form
    {
        DAL_GET dalGet = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();
        BLL_Buttoms bllButtoms = new BLL_Buttoms();
        string IDs = null;


        public changeFormTwo()
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

            comboBox_Device.DataSource = dalGet.Get_Data_From_Table_From_Colunm("TypeDevice", "NameDevice");
            comboBox_Device.DisplayMember = "NameDevice";
            comboBox_Device.ValueMember = "NameDevice";

            comboBox_AC.DataSource = dalGet.Get_Data_From_Table_From_Colunm("TypeAC", "TypeAC");
            comboBox_AC.DisplayMember = "TypeAC";
            comboBox_AC.ValueMember = "TypeAC";

            comboBox_jira.DataSource = dalGet.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_jira.DisplayMember = "JiraTask";
            comboBox_jira.ValueMember = "JiraTask";

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

        private void checkBox_AC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_AC.Checked == true)
            {
                textBox_AC.Enabled = true;
                comboBox_AC.Enabled = false;
            }

            else
            {
                textBox_AC.Enabled = false;
                comboBox_AC.Enabled = true;
            }
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

        private void Data_from_DataGrid(DataGridView dataGridView)
        {            
                dataGridView.DataSource = dalGet.Table_Change_data(IDs);
                if (dataGridView.DataSource != null)
                {
                dataGridView.Columns["ID"].Visible = Properties.Settings.Default.setDataBase_mainTB_Reason;
                dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                dataGridView.Columns["ID"].ReadOnly = true;
                dataGridView.Columns["ID"].DefaultCellStyle.BackColor = Color.Lavender;


                dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_date;
                dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                dataGridView.Columns["dateCreated"].ReadOnly = true;
                dataGridView.Columns["dateCreated"].DefaultCellStyle.BackColor = Color.Lavender;

                dataGridView.Columns["TypeAC"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_TypeAC;
                dataGridView.Columns["TypeAC"].HeaderCell.Value = "Вид учёта";
                dataGridView.Columns["TypeAC"].ReadOnly = true;
                dataGridView.Columns["TypeAC"].DefaultCellStyle.BackColor = Color.AliceBlue ;

                dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_InvNum;
                dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_LanName;
                dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";
                dataGridView.Columns["NameLAN"].ReadOnly = true;
                dataGridView.Columns["NameLAN"].DefaultCellStyle.BackColor = Color.Lavender;

                dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_ResName;
                dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";
                dataGridView.Columns["NameRes"].ReadOnly = true;
                dataGridView.Columns["NameRes"].DefaultCellStyle.BackColor = Color.Lavender;

                dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_Floor;
                dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";
                dataGridView.Columns["floorNambe"].ReadOnly = true;
                dataGridView.Columns["floorNambe"].DefaultCellStyle.BackColor = Color.Lavender;

                dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_Room;
                dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";
                dataGridView.Columns["NameRoom"].ReadOnly = true;
                dataGridView.Columns["NameRoom"].DefaultCellStyle.BackColor = Color.Lavender;

                dataGridView.Columns["NameDevice"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_TypeDiv;
                dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";
                dataGridView.Columns["NameDevice"].ReadOnly = true;
                dataGridView.Columns["NameDevice"].DefaultCellStyle.BackColor = Color.AliceBlue;

                dataGridView.Columns["Model"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_Model;
                dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                dataGridView.Columns["SN"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_SN;
                dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_JiraTask;
                dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                dataGridView.Columns["JiraTask"].ReadOnly = true;
                dataGridView.Columns["JiraTask"].DefaultCellStyle.BackColor = Color.AliceBlue;

                dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_WrittenOff;
                dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";
                dataGridView.Columns["WrittenOff"].ReadOnly = true;
                dataGridView.Columns["WrittenOff"].DefaultCellStyle.BackColor = Color.Lavender;

                dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_Reason;
                dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";
                
                
                dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);
                }            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            BLL.ArrayChancge.Clear();
            this.Close();
        }

        private void changeFormTwo_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.ArrayChancge.Clear();            
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bll.change(row.Cells["ID"].Value.ToString(),
                   row.Cells["TypeAC"].Value.ToString(),
                   row.Cells["NumberINV"].Value.ToString(),
                   row.Cells["NameDevice"].Value.ToString(),
                   row.Cells["SN"].Value.ToString(),
                   row.Cells["Model"].Value.ToString(),
                   row.Cells["JiraTask"].Value.ToString());

                dalSet.change(row.Cells["ID"].Value.ToString(),
                    bll.Get_ID("TypeAC", "TypeAC", row.Cells["TypeAC"].Value.ToString()).ToString(),
                    row.Cells["NumberINV"].Value.ToString(),
                    bll.Get_ID("TypeDevice", "NameDevice", row.Cells["NameDevice"].Value.ToString()).ToString(),
                    row.Cells["SN"].Value.ToString(),
                    row.Cells["Model"].Value.ToString(),
                    bll.Get_ID("JiraTask", "JiraTask", row.Cells["JiraTask"].Value.ToString()).ToString(),
                    row.Cells["Note"].Value.ToString());

            }

            BLL.ArrayChancge.Clear();
            this.Close();
        }

        private void comboBox_AC_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_tabe(comboBox_AC.SelectedValue.ToString() ,"TypeAC");
        }

        private void comboBox_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_tabe(comboBox_Device.SelectedValue.ToString(), "NameDevice");
        }

        private void comboBox_jira_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_tabe(comboBox_jira.SelectedValue.ToString(), "JiraTask");
        }

        private void textBox_AC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                update_tabe(textBox_AC.Text, "TypeAC");
            }
        }

        private void textBox_Device_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                update_tabe(textBox_Device.Text, "NameDevice");
            }
        }

        private void textBox_jira_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                update_tabe(textBox_jira.Text, "JiraTask");
            }
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
                        AddId += row.Cells["ID"].Value.ToString();
                }
            }

            if (AddId != null)
            {
                bllButtoms.Writtenoff(AddId, "MainTB");
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
                bllButtoms.Delete(AddId, "MainTB");
            }

            Data_from_DataGrid(dataGridView);
        }

        private void button_print_select_str_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Selected == true)
                {
                    bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                        row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                        row.Cells["SN"].Value.ToString(), row.Cells["Model"].Value.ToString());
                }
            }
        }

        private void button_print_all_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
                bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                        row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                        row.Cells["SN"].Value.ToString(), row.Cells["Model"].Value.ToString());
        }

    }

}
