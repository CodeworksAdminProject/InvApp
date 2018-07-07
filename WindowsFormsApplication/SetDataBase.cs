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
    public partial class setDataBase : Form

    {
        public static string flag_button;
        public static string addId;
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();
        ArrayList DataINV = new ArrayList();
        BLL_Buttoms bllButtoms = new BLL_Buttoms();

        public setDataBase()
        {
            InitializeComponent();
                       
            comboBox_Room.DataSource = dal_get.Get_Data_From_Table_From_Colunm("Room", "NameRoom");
            comboBox_Room.DisplayMember = "NameRoom";
            comboBox_Room.ValueMember = "NameRoom";

            comboBox_Responsible.DataSource = dal_get.Get_Data_From_Table_From_Colunm("NameRes", "NameRes");
            comboBox_Responsible.DisplayMember = "NameRes";
            comboBox_Responsible.ValueMember = "NameRes";

            comboBox_Floor.DataSource = dal_get.Get_Data_From_Table_From_Colunm("[Floor]", "floorNambe");
            comboBox_Floor.DisplayMember = "floorNambe";
            comboBox_Floor.ValueMember = "floorNambe";

            View_and_data();

            Data_from_DataGrid(dataGridView1);            
        }

        private void View_and_data()
        {
            if (flag_button == "MainTB")
            {
                comboBox_LanName.DataSource = dal_get.Get_Data_From_Table_From_Colunm("NameLAN", "NameLAN");
                comboBox_LanName.DisplayMember = "NameLAN";
                comboBox_LanName.ValueMember = "NameLAN";

                groupBox_Responsible.Enabled = true;
                groupBox_LanName.Enabled = true;
                Location.Enabled = true;
                groupBox_room.Enabled = true;
            }

            else if (flag_button == "HardwareStockRoom")
            {
                comboBox_LanName.DataSource = dal_get.Get_PC_name_Hardware();
                comboBox_LanName.DisplayMember = "NameLAN";
                comboBox_LanName.ValueMember = "NameLAN";

                groupBox_Responsible.Enabled = false;
                groupBox_LanName.Enabled = true;
                Location.Enabled = false;
                groupBox_room.Enabled = false;
            }

            else if (flag_button == "HardWare")
            {
                comboBox_LanName.DataSource = dal_get.Get_PC_name_Hardware();
                comboBox_LanName.DisplayMember = "NameLAN";
                comboBox_LanName.ValueMember = "NameLAN";

                groupBox_Responsible.Enabled = false;
                groupBox_LanName.Enabled = true;
                Location.Enabled = false;
                groupBox_room.Enabled = false;
            }

            else
            {
                DataINV = null;
                groupBox_Responsible.Enabled = false;
                groupBox_LanName.Enabled = false;
                Location.Enabled = false;
                groupBox_room.Enabled = false;
            }

        }

        private void Data_from_DataGrid(DataGridView dataGridView)
        {
            if (flag_button == "MainTB")
            {
                dataGridView.DataSource = dal_get.Get_For_SetForms_MaintTB(addId);

                if (dataGridView.DataSource != null)
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.setDataBase_mainTB_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.setDataBase_mainTB_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["TypeAC"].Visible = Properties.Settings.Default.setDataBase_mainTB_TypeAC;
                    dataGridView.Columns["TypeAC"].HeaderCell.Value = "Вид учёта";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.setDataBase_mainTB_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.setDataBase_mainTB_LanName;
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";

                    dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.setDataBase_mainTB_ResName;
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";

                    dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.setDataBase_mainTB_Floor;
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";

                    dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.setDataBase_mainTB_Room;
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";

                    dataGridView.Columns["NameDevice"].Visible = Properties.Settings.Default.setDataBase_mainTB_TypeDiv;
                    dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.setDataBase_mainTB_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.setDataBase_mainTB_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.setDataBase_mainTB_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.setDataBase_mainTB_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.setDataBase_mainTB_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);
                }
            }

            else if (flag_button == "HardwareStockRoom")
            {
                dataGridView.DataSource = dal_get.Get_For_SetForms_HardwareStockRoom(addId);
            }

            else if (flag_button == "HardWare")
            {
                dataGridView.DataSource = dal_get.Get_For_SetForms_HardWare(addId);
            }

            else
            {
                DataINV = null;
            }

            
        }


        private void checkBox_Responsible_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Responsible.Checked == true)
            {
                textBox_Responsible.Enabled = true;
                comboBox_Responsible.Enabled = false;
            }

            else
            {
                textBox_Responsible.Enabled = false;
                comboBox_Responsible.Enabled = true;
            }
        }

        private void checkBox_LanName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_LanName.Checked == true)
            {
                textBox_LanName.Enabled = true;
                comboBox_LanName.Enabled = false;
            }

            else
            {
                textBox_LanName.Enabled = false;
                comboBox_LanName.Enabled = true;
            }
        }

        private void checkBox_Floor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Floor.Checked == true)
            {
                textBox_Floor.Enabled = true;
                comboBox_Floor.Enabled = false;
            }

            else
            {
                textBox_Floor.Enabled = false;
                comboBox_Floor.Enabled = true;
            }
        }

        private void checkBox_Room_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Room.Checked == true)
            {
                textBox_Room.Enabled = true;
                comboBox_Room.Enabled = false;
            }

            else
            {
                textBox_Room.Enabled = false;
                comboBox_Room.Enabled = true;
            }
        }      


        private void comboBox_TypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
              //  update("TypeAC_ID", "TypeAC", "TypeAC", comboBox_TypeAccount.SelectedValue.ToString()); 
            }

            else if (flag_button == "HardwareStockRoom")
            {
               
            }

            else if (flag_button == "HardWare")
            {
                
            }

                      

        }

        private void comboBox_LanName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (flag_button == "MainTB")
            {
                update("NameLAN_ID", "NameLAN", "NameLAN", comboBox_LanName.SelectedValue.ToString());
            }

            else if (flag_button == "HardwareStockRoom")
            {

            }

            else if (flag_button == "HardWare")
            {

            }
            
        }
        
        private void comboBox_Responsible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
                update("NameRes_ID", "NameRes", "NameRes", comboBox_Responsible.SelectedValue.ToString());

            }

            else if (flag_button == "HardwareStockRoom")
            {

            }

            else if (flag_button == "HardWare")
            {

            }           
        }
                
        private void comboBox_Floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
                update("Floor_ID", "Floor", "floorNambe", comboBox_Floor.SelectedValue.ToString());

            }

            else if (flag_button == "HardwareStockRoom")
            {

            }

            else if (flag_button == "HardWare")
            {

            }            
        }

        private void comboBox_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
                update("Room_ID", "Room", "NameRoom", comboBox_Room.SelectedValue.ToString());

            }

            else if (flag_button == "HardwareStockRoom")
            {

            }

            else if (flag_button == "HardWare")
            {

            }
            
        }


        private void textBox_TypeAccount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (flag_button == "MainTB")
                {
                   // update("TypeAC_ID", "TypeAC", "TypeAC", textBox_TypeAccount.Text);

                }

                else if (flag_button == "HardwareStockRoom")
                {

                }

                else if (flag_button == "HardWare")
                {

                }
                              
            }
        }

        private void textBox_Responsible_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (flag_button == "MainTB")
                {
                    update("NameRes_ID", "NameRes", "NameRes", textBox_Responsible.Text);

                }

                else if (flag_button == "HardwareStockRoom")
                {

                }

                else if (flag_button == "HardWare")
                {

                }
                
            }
        }

        private void textBox_Floor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (flag_button == "MainTB")
                {
                    update("Floor_ID", "Floor", "floorNambe", textBox_Floor.Text);

                }

                else if (flag_button == "HardwareStockRoom")
                {

                }

                else if (flag_button == "HardWare")
                {

                }
                
            }
        }

        private void textBox_Room_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (flag_button == "MainTB")
                {
                    update("Room_ID", "Room", "NameRoom", textBox_Room.Text);

                }

                else if (flag_button == "HardwareStockRoom")
                {

                }

                else if (flag_button == "HardWare")
                {

                }
            }
        }

        private void textBox_LanName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (flag_button == "MainTB")
                {
                    update("NameLAN_ID", "NameLAN", "NameLAN", textBox_LanName.Text);

                }

                else if (flag_button == "HardwareStockRoom")
                {

                }

                else if (flag_button == "HardWare")
                {

                }

            }
            
        }


        private void setDataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                bll.Compere(
                    row.Cells["ID"].Value.ToString(),
                    row.Cells["NumberINV"].Value.ToString(),
                    row.Cells["NameLAN"].Value.ToString(),
                    row.Cells["NameRes"].Value.ToString(),
                    row.Cells["floorNambe"].Value.ToString(),
                    row.Cells["NameRoom"].Value.ToString(),
                    row.Cells["NameDevice"].Value.ToString(),
                    row.Cells["Model"].Value.ToString(),
                    row.Cells["SN"].Value.ToString()
                    );

            flag_button = null;
            addId =null;
            BLL.Data.Clear();
            BLL.DataOld.Clear();

        }

        private void update(string maintb_id_name, string table_name,string Column, string value )
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
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
                    dalSet.SetChangeData(maintb_id_name, bll.Get_ID(table_name, Column, value).ToString(),
                        row.Cells["ID"].Value.ToString());
                }
            }

            Data_from_DataGrid(dataGridView1);
        }



        private void button_print_all_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                        row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                        row.Cells["SN"].Value.ToString(), row.Cells["Model"].Value.ToString());
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    bll.Add_Data_ArrayChancge(row.Cells["ID"].Value.ToString(),
                              row.Cells["dateCreated"].Value.ToString(),
                              row.Cells["TypeAC"].Value.ToString(),
                              row.Cells["NumberINV"].Value.ToString(),
                              row.Cells["NameDevice"].Value.ToString(),
                              row.Cells["SN"].Value.ToString(),
                              row.Cells["Model"].Value.ToString(),
                              row.Cells["JiraTask"].Value.ToString(),
                              row.Cells["NameLAN"].Value.ToString(),
                              row.Cells["NameRes"].Value.ToString(),
                              row.Cells["floorNambe"].Value.ToString(),
                              row.Cells["NameRoom"].Value.ToString());
                }

            }
            bllButtoms.Change_unique_data();
        }



        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (flag_button == "MainTB")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString() != "")
                    model.Text = dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                else
                    model.Text = "";

                if (dataGridView1.Rows[e.RowIndex].Cells["NameDevice"].Value.ToString() != "")
                    typeDiv.Text =  dataGridView1.Rows[e.RowIndex].Cells["NameDevice"].Value.ToString();
                else
                    typeDiv.Text = "";

            }

            else if (flag_button == "HardwareStockRoom")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString() != "")
                    model.Text = dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                else
                    model.Text = "";

                if (dataGridView1.Rows[e.RowIndex].Cells["TypeHardWare"].Value.ToString() != "")
                    typeDiv.Text = dataGridView1.Rows[e.RowIndex].Cells["TypeHardWare"].Value.ToString();
                else
                    typeDiv.Text = "";
            }

            else if (flag_button == "HardWare")
            {
                label_type_div.Text = "Имя ПК:";
                label_model.Text = "";
                typeDiv.Text = dataGridView1.Rows[e.RowIndex].Cells["NameLAN"].Value.ToString();
                model.Text = "";
            }
        }

        private void button_print_select_str_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Selected == true)
                {
                    bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                        row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                        row.Cells["SN"].Value.ToString(), row.Cells["Model"].Value.ToString());
                }
        }
    }
}


