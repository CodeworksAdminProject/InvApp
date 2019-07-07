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
    public partial class Move_Hardware : Form
    {

        BLL bll = new BLL();
        DAL_GET dalGet = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();

        public string ID;
        public string NumberINV;
        public string TypeHardWare;
        public string Model;        
        public string SN;
        public string jira;
        public string Old_NameLan;
        public string Note;



        public Move_Hardware()
        {
            InitializeComponent();
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

        private void button_shearch_Click(object sender, EventArgs e)
        {            
            Data_from_DataGrid(dataGridView);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string Type_Jira;
            if (textBox_jira.Enabled == true)
                Type_Jira = textBox_jira.Text;
            else
            {
                if (comboBox_jira.SelectedValue.ToString() != null)
                    Type_Jira = comboBox_jira.SelectedValue.ToString();
                else
                    Type_Jira = "";
            }

            if (dataGridView.SelectedRows.Count <= Convert.ToInt16(sum.Text))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (
                       row.Selected == true ||
                       row.Cells["ID"].Selected == true ||
                       row.Cells["NumberINV"].Selected == true ||
                       row.Cells["NameLAN"].Selected == true ||
                       row.Cells["NameRes"].Selected == true ||
                       row.Cells["floorNambe"].Selected == true ||
                       row.Cells["NameRoom"].Selected == true ||
                       row.Cells["NameDevice"].Selected == true
                       )
                    {
                        if (button_stockroom.Enabled == true)
                        {
                            dalSet.Move_Hardware(ID, row.Cells["ID"].Value.ToString());

                            dalSet.AddFDB(Environment.UserName, 8, "Снято с " + Old_NameLan + " и установлено на " + row.Cells["NameLAN"].Value.ToString(),
                            NumberINV, TypeHardWare, SN, Model, ID);

                            bll.Move_Hardware(NumberINV, TypeHardWare, SN, Model, Type_Jira, row.Cells["NameLAN"].Value.ToString(), Old_NameLan, "PC_PC");
                        }

                        else
                        {
                            dalSet.SetNewPosition(bll.Get_ID("[TypeHardWare]", "[TypeHardWare]", TypeHardWare).ToString(),
                            Model, SN, NumberINV, bll.Get_ID("JiraTask", "JiraTask", Type_Jira).ToString(),
                            Convert.ToInt16(row.Cells["ID"].Value.ToString()), Note);

                            dalSet.remove_one_unit_stockroom(ID);

                            dalSet.AddFDB(Environment.UserName, 8, "Взято со склада " + " и установлено на " + row.Cells["NameLAN"].Value.ToString(),
                            NumberINV, TypeHardWare, SN, Model, ID);

                            bll.Move_Hardware(NumberINV, TypeHardWare, SN, Model, Type_Jira, row.Cells["NameLAN"].Value.ToString(), Old_NameLan, "S_PC");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Количество выбранных объектов превышает допустимое значение (возможно выбрать не более " + sum.Text + ")",
                    "Боливар не вынесет двоих", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }   

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_stockroom_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= Convert.ToInt16(sum.Text))
            {
                string Type_Jira;
                if (textBox_jira.Enabled == true)
                    Type_Jira = textBox_jira.Text;
                else
                {
                    if (comboBox_jira.SelectedValue.ToString() != null)
                        Type_Jira = comboBox_jira.SelectedValue.ToString();
                    else
                        Type_Jira = "";
                }

                
            dalSet.SetNewPosition(bll.Get_ID("[TypeHardWare]", "[TypeHardWare]", TypeHardWare).ToString(),
                Model, SN, 1, NumberINV, bll.Get_ID("JiraTask", "JiraTask", Type_Jira).ToString());

            bll.Move_Hardware(NumberINV, TypeHardWare, SN, Model, Type_Jira, null, Old_NameLan, "PC_S");

            dalSet.AddFDB(Environment.UserName, 8, "Снято с " + Old_NameLan + " и отправлено на склад",NumberINV, TypeHardWare, SN, Model, ID);
            }
        }

        private void Data_from_DataGrid(DataGridView dataGridView)
        {
            dataGridView.DataSource = dalGet.Get_LanName_Haradware(textBox_inv.Text, textBox_LanNam.Text, textBox_Res.Text);
            if (dataGridView.DataSource != null)
            {
                dataGridView.Columns["ID"].Visible = Properties.Settings.Default.setDataBase_mainTB_Reason;
                dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_InvNum;
                dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_LanName;
                dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";

                dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_ResName;
                dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";

                dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_Floor;
                dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";

                dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_Room;
                dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";

                dataGridView.Columns["NameDevice"].Visible = Properties.Settings.Default.changeFormTwo_mainTB_TypeDiv;
                dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";

                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);
            }
        }
    }
}
