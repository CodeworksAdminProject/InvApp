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
    public partial class Search : Form
    {
        BLL_Buttoms bllButtoms = new BLL_Buttoms();
        BLL_Search bllSearch = new BLL_Search();
        DAL_GET dalGet = new DAL_GET();
        DAL_SEARCH dalSearch = new DAL_SEARCH();
        BLL bll = new BLL();
        DAL_SET dalSet = new DAL_SET();
       

        string flag_button;

        public Search()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today.AddDays(-365);
            button_MainTB_Click(null, null);
            ValumeComboBox();
        }

        private void button_New_data_Click(object sender, EventArgs e)
        {
            SetNewDataBase setNewData = new SetNewDataBase();
            setNewData.checkBox_MainAcount.Checked = true;
            setNewData.checkBox_Stockroom.Checked = true;
            setNewData.ShowDialog();
            bllSearch.Update_Grid(dataGridView, flag_button);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string AddId = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Selected == true)
                {

                    if (AddId != null)
                        AddId += "," + row.Cells[0].Value.ToString();
                    else
                        AddId += row.Cells[0].Value.ToString();
                }
            }

            if (AddId != null)
            {
                bllButtoms.Writtenoff(AddId, flag_button);
                bllSearch.Update_Grid(dataGridView, flag_button);
            }
        }

        private void button_MainTB_Click(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            ValumeComboBox();
            groupBox_TypeAC.Enabled = true;
            groupBox_namePC.Enabled = true;
            groupBox_res_name.Enabled = true;
            groupBox_romm_and_floor.Enabled = true;

            button_hardwarePC.ForeColor= button_Hardware_Stockroom.ForeColor= Color.MidnightBlue;
            button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            button_MainTB.BackColor = Color.LightGray;
            button_MainTB.ForeColor = Color.Black;

            dataGridView.DataSource = null;
            dataGridView.DataSource = dalSearch.dataMainTB();
            bllSearch.Update_Grid(dataGridView, flag_button);
            label_sum.Text = dataGridView.Rows.Count.ToString();
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
                button_MainTB.ForeColor=button_hardwarePC.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
                button_MainTB.BackColor = button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;

            }
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

        private void button_Hardware_Stockroom_Click(object sender, EventArgs e)
        {
            flag_button = "HardwareStockRoom";
            ValumeComboBox();
            groupBox_TypeAC.Enabled = false;
            groupBox_namePC.Enabled = false;
            groupBox_res_name.Enabled = false;
            groupBox_romm_and_floor.Enabled = false;

            button_MainTB.ForeColor = button_hardwarePC.ForeColor = Color.MidnightBlue;
            button_MainTB.BackColor = button_hardwarePC.BackColor = Color.White;
            button_Hardware_Stockroom.BackColor = Color.LightGray;
            button_Hardware_Stockroom.ForeColor = Color.Black;

            dataGridView.DataSource = null;
            dataGridView.DataSource = dalSearch.dataStockroom();
            bllSearch.Update_Grid(dataGridView, flag_button);
            label_sum.Text = dataGridView.Rows.Count.ToString();
        }

        private void button_hardwarePC_Click(object sender, EventArgs e)
        {
            flag_button = "HardWare";
            ValumeComboBox();
            groupBox_TypeAC.Enabled = false;
            groupBox_namePC.Enabled = true;
            groupBox_res_name.Enabled = true;
            groupBox_romm_and_floor.Enabled = true;

            button_MainTB.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
            button_MainTB.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            button_hardwarePC.BackColor = Color.LightGray;
            button_hardwarePC.ForeColor = Color.Black;

            dataGridView.DataSource = null;
            dataGridView.DataSource = dalSearch.dataHardware();
            bllSearch.Update_Grid(dataGridView, flag_button);
            label_sum.Text = dataGridView.Rows.Count.ToString();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (flag_button == null)
                flag_button = "MainTB";

            SearchParm();
            dalSearch.search(dataGridView, flag_button);
            bllSearch.Update_Grid(dataGridView, flag_button);
            label_sum.Text = dataGridView.Rows.Count.ToString();
        }

        private void SearchParm()
        {
            dalSearch.date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            dalSearch.date_now = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            dalSearch.Floor = comboBox_Floor.SelectedValue.ToString();
            dalSearch.Room = comboBox_Room.SelectedValue.ToString();
            dalSearch.namePC = comboBox_namePC.SelectedValue.ToString();
            dalSearch.Res_name = comboBox_Res_name.SelectedValue.ToString();
            dalSearch.InvNum = textBox_InvNum.Text;
            dalSearch.Model = textBox_Model.Text;
            dalSearch.SN = textBox_SN.Text;
            dalSearch.checke = checkBox_Writtenoff.Checked;
            dalSearch.Jira = comboBox_JIRA.SelectedValue.ToString();
            dalSearch.TypeAC = comboBox_TypeAC.SelectedValue.ToString();

            if (flag_button == "MainTB")
            {
                dalSearch.TypeDevice = comboBox_TypeDevice.SelectedValue.ToString();
                dalSearch.TypeHardware = "Для всех"; 
                dalSearch.ID_mnTB = textBox_ID.Text;
                dalSearch.ID_HW = null;
                dalSearch.ID_SR = null;
            }
           else if (flag_button == "HardWare")
            {
                dalSearch.TypeDevice = "Для всех";
                dalSearch.TypeHardware = comboBox_TypeDevice.SelectedValue.ToString();
                dalSearch.ID_mnTB = null;
                dalSearch.ID_HW = textBox_ID.Text;
                dalSearch.ID_SR = null;
            }
            else if (flag_button == "HardwareStockRoom")
            {
                dalSearch.TypeDevice = "Для всех";
                dalSearch.TypeHardware = comboBox_TypeDevice.SelectedValue.ToString();
                dalSearch.ID_mnTB = null;
                dalSearch.ID_HW = null;
                dalSearch.ID_SR = textBox_ID.Text;
            }

        }

        private void ValumeComboBox()
        {
            bllSearch.DataComboBox(comboBox_Room, "Room", "NameRoom");
            bllSearch.DataComboBox(comboBox_Floor, "[Floor]", "floorNambe");
            bllSearch.DataComboBox(comboBox_Res_name,"NameRes", "NameRes");
            bllSearch.DataComboBox(comboBox_JIRA,  "JiraTask", "JiraTask");
            bllSearch.DataComboBox(comboBox_TypeAC, "TypeAC", "TypeAC");

            if (flag_button == "MainTB")
            {
                bllSearch.DataComboBox(comboBox_namePC, "NameLAN", "NameLAN");
                bllSearch.DataComboBox(comboBox_TypeDevice, "TypeDevice", "NameDevice");
            }

            else
            {
                bllSearch.DataComboBox(comboBox_TypeDevice, "TypeHardWare", "TypeHardWare");
                bllSearch.DataComboBox(comboBox_namePC);
            }           
        }

        private void AddItems(ComboBox box, System.Collections.ArrayList array)
        {
            

            box.Items.Add(new { Text = "Для всех", Value = "0" });            
        }

        private void PRINT_LABEL_ALL_Click(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
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
        }

        private void button_deleteDataBase_Click(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
                WriteOff set = new WriteOff();
                set.Owner = this;
                set.button_OK.Text = "Улалить";
                set.ShowDialog();

                if (BLL.flag == true)
                {
                    string AddId = null;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Selected == true)
                        {
                            BLL.sHtmlTableDeleteReport = BLL.sHtmlTableDeleteReport + bll.WrittenOff_And_Delete(row.Cells["ID"].Value.ToString(), BLL.sHtmlTableDeleteReport, "Delete");

                            AddId += row.Cells[0].Value.ToString();
                            dalSet.AddFDB(Environment.UserName, 3, BLL.ReasonWriteOff, row.Cells["NumberINV"].Value.ToString(),
                                row.Cells["NameDevice"].Value.ToString(), row.Cells["SN"].Value.ToString(),
                                row.Cells["Model"].Value.ToString(), row.Cells["ID"].Value.ToString());

                            dalSet.Delete("MainTB", row.Cells[0].Value.ToString());
                        }
                    }

                    BLL.ReasonWriteOff = null;
                    BLL.flag = false;                    
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = dalSearch.dataMainTB();
                bllSearch.Update_Grid(dataGridView, flag_button);
                label_sum.Text = dataGridView.Rows.Count.ToString();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
                string AddId = null;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Selected == true)
                    {
                        bll.AddDataNew(row.Cells["ID"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(), row.Cells["NameRes"].Value.ToString(), row.Cells["floorNambe"].Value.ToString(), row.Cells["NameRoom"].Value.ToString());
                        if (AddId != null)
                            AddId += "," + row.Cells["ID"].Value.ToString();
                        else
                            AddId += row.Cells["ID"].Value.ToString();
                    }
                }



                if (AddId != null)
                {
                    bllButtoms.Change_data(AddId, flag_button);
                }
            }
        }
    }
}
