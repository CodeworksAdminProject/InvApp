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
    public partial class SetNewDataBase : Form
    {
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();



        ArrayList list = new ArrayList();
        int n = 0;


        public SetNewDataBase()
        {
            InitializeComponent();

            groupBox_Hardware_LanName.Enabled = false;
             
            update();
        }

        private void update()
        {
            comboBox_Room.DataSource = dal_get.Get_Data_From_Table_From_Colunm("Room", "NameRoom");
            comboBox_Room.DisplayMember = "NameRoom";
            comboBox_Room.ValueMember = "NameRoom";

            comboBox_Responsible.DataSource = dal_get.Get_Data_From_Table_From_Colunm("NameRes", "NameRes");
            comboBox_Responsible.DisplayMember = "NameRes";
            comboBox_Responsible.ValueMember = "NameRes";

            comboBox_Floor.DataSource = dal_get.Get_Data_From_Table_From_Colunm("[Floor]", "floorNambe");
            comboBox_Floor.DisplayMember = "floorNambe";
            comboBox_Floor.ValueMember = "floorNambe";

            comboBox_LanName.DataSource = dal_get.Get_Data_From_Table_From_Colunm("NameLAN", "NameLAN");
            comboBox_LanName.DisplayMember = "NameLAN";
            comboBox_LanName.ValueMember = "NameLAN";

            comboBox_TypeDevice.DataSource = dal_get.Get_Data_From_Table_From_Colunm("TypeDevice", "NameDevice");
            comboBox_TypeDevice.DisplayMember = "NameDevice";
            comboBox_TypeDevice.ValueMember = "NameDevice";

            comboBox_Hardware_TypeDevice.DataSource = dal_get.Get_Data_From_Table_From_Colunm("TypeHardWare", "TypeHardWare");
            comboBox_Hardware_TypeDevice.DisplayMember = "TypeHardWare";
            comboBox_Hardware_TypeDevice.ValueMember = "TypeHardWare";

            comboBox_Hardware_LanName.DataSource = dal_get.Get_Data_From_Table_From_Colunm("NameLAN", "NameLAN");
            comboBox_Hardware_LanName.DisplayMember = "NameLAN";
            comboBox_Hardware_LanName.ValueMember = "NameLAN";

            comboBox_Hardware_jira.DataSource = dal_get.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_Hardware_jira.DisplayMember = "JiraTask";
            comboBox_Hardware_jira.ValueMember = "JiraTask";

            comboBox_Jira.DataSource = dal_get.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_Jira.DisplayMember = "JiraTask";
            comboBox_Jira.ValueMember = "JiraTask";

            set_checkBox_and_set_Combobox(checkBox_Account, textBox_TypeAccount, comboBox_TypeAccount);
            set_checkBox_and_set_Combobox(checkBox_Responsible, textBox_Responsible, comboBox_Responsible);
            set_checkBox_and_set_Combobox(checkBox_LanName, textBox_LanName, comboBox_LanName);
            set_checkBox_and_set_Combobox(checkBox_Floor, textBox_Floor, comboBox_Floor);
            set_checkBox_and_set_Combobox(checkBox_Room, textBox_Room, comboBox_Room);
            set_checkBox_and_set_Combobox(checkBox_TypeDevice, textBox_TypeDevice, comboBox_TypeDevice);
            set_checkBox_and_set_Combobox(checkBox_Hardware_TypeDevice, textBox_Hardware_TypeDevice, comboBox_Hardware_TypeDevice);
            set_checkBox_and_set_Combobox(checkBox_Hardware_LanName, textBox_Hardware_LanName, comboBox_Hardware_TypeDevice);
            set_checkBox_and_set_Combobox(checkBox_Jira, textBox_jira, comboBox_Jira);
            set_checkBox_and_set_Combobox(checkBox_Hardware_jira,textBox_Hardware_jira,comboBox_Hardware_jira);


        }

        private void set_checkBox_and_set_Combobox(CheckBox checkBox, TextBox textBox, ComboBox comboBox)
        {
            checkBox.Checked = false;
            if (textBox.Text != "")
            {
                comboBox.SelectedValue = textBox.Text;
                textBox.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NumberInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) & (ch != '\u0018') & (ch != '\u0003') & (ch != '\u0016') & (ch != '\b') & (ch != '\u0001'))
            {
                e.Handled = true;
            }
               
        }

        private void textBox_NumberSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void checkBox_Account_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Account.Checked == true)
            {
                textBox_TypeAccount.Enabled = true;
                comboBox_TypeAccount.Enabled = false;
            }

            else
            {
                textBox_TypeAccount.Enabled = false;
                comboBox_TypeAccount.Enabled = true;
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

        private void checkBox_TypeDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_TypeDevice.Checked == true)
            {
                textBox_TypeDevice.Enabled = true;
                comboBox_TypeDevice.Enabled = false;
            }

            else
            {
                textBox_TypeDevice.Enabled = false;
                comboBox_TypeDevice.Enabled = true;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string messega;
            DialogResult dialogResult;

            if (checkBox_MainAcount.Checked == true)
            {
                string typedevise;
                if (textBox_TypeDevice.Enabled == true)
                    typedevise = textBox_TypeDevice.Text;
                else { typedevise = comboBox_TypeDevice.SelectedValue.ToString(); }

                string Responsible;
                if (textBox_Responsible.Enabled)
                    Responsible = textBox_Responsible.Text;
                else { Responsible = comboBox_Responsible.SelectedValue.ToString(); }

                string LanName;
                if (textBox_LanName.Enabled == true)
                    LanName = textBox_LanName.Text;
                else { LanName = comboBox_LanName.SelectedValue.ToString(); }

                string Floor;
                if (textBox_Floor.Enabled == true)
                    Floor = textBox_Floor.Text;
                else { Floor = comboBox_Floor.SelectedValue.ToString(); }

                string Room;
                if (textBox_Room.Enabled == true)
                    Room = textBox_Room.Text;
                else { Room = comboBox_Room.SelectedValue.ToString(); }

                string Jira;
                if (textBox_jira.Enabled == true)
                    Jira = textBox_jira.Text;
                else { Jira = comboBox_Jira.SelectedValue.ToString(); }

                dialogResult = MessageBox.Show(("Инвентарный номер:\t" + textBox_NumberInv.Text +
                               "\nНазвание в сети:\t\t" + LanName +
                               "\nОтветственный\t\t" + Responsible +
                               "\nМестоположение:\t\t" + Floor + " этаж, " + Room + " комната" +
                               "\nТип устройства:\t\t" + typedevise +
                               "\nСерийный номер:\t\t" + textBox_NumberSN.Text +
                               "\nМодель:\t\t\t" + textBox_Model.Text +
                               "\nЗадача в JIRA:\t\t\t" + Jira), "Подтверждение отправки", MessageBoxButtons.OKCancel);               

                if (dialogResult == DialogResult.OK)
                {
                    dalSet.SetNewPosition("NULL", bll.Get_ID("TypeDevice", "NameDevice", typedevise).ToString(),
                        textBox_Model.Text,
                        textBox_NumberSN.Text, bll.Get_ID("NameRes",
                        "NameRes", Responsible).ToString(),
                        bll.Get_ID("NameLAN", "NameLAN",
                        LanName).ToString(), bll.Get_ID("Floor",
                        "floorNambe", Floor).ToString(),
                        bll.Get_ID("Room", "NameRoom",
                        Room).ToString(), textBox_NumberInv.Text,
                        bll.Get_ID("JiraTask", "JiraTask", Jira).ToString());
                    

                    bll.BodyMailNew(textBox_NumberInv.Text, LanName, Responsible, Floor, Room, typedevise, textBox_NumberSN.Text, textBox_Model.Text);

                    dalSet.AddFDB(Environment.UserName, 4, "Устройства комната:"+Room + " приписан к PC " + LanName, textBox_NumberInv.Text,
                           typedevise, textBox_Hardware_SN.Text, textBox_Hardware_Model.Text, dal_get.get_max_ID("[dbo].[MainTB]"));

                    update();
                    
                }
                else if (dialogResult == DialogResult.No)
                { }
            }
            else 
            {
                string typedevise;
                if (textBox_Hardware_TypeDevice.Enabled == true)
                    typedevise = textBox_Hardware_TypeDevice.Text;
                else { typedevise = comboBox_Hardware_TypeDevice.SelectedValue.ToString(); }

                string LanName;
                if (textBox_Hardware_LanName.Enabled == true)
                    LanName = textBox_Hardware_LanName.Text;
                else { LanName = comboBox_Hardware_LanName.SelectedValue.ToString(); }

                string Jira;
                if (textBox_Hardware_jira.Enabled == true)
                    Jira = textBox_Hardware_jira.Text;
                else { Jira = comboBox_Hardware_jira.SelectedValue.ToString(); }

                if (checkBox_SetHardware.Checked == true)
                {
                    messega = @"Инвентарный номер:\t" + textBox_NumberInv.Text +
                               "\nНазвание в сети:\t\t" + LanName +
                               "\nТип устройства:\t\t" + typedevise +
                               "\nСерийный номер:\t\t" + textBox_Hardware_SN.Text +
                               "\nМодель:\t\t\t" + textBox_Hardware_Model.Text +
                               "\nЗадача в JIRA:\t\t\t" + Jira;

                    dialogResult = MessageBox.Show(messega, "Подтверждение отправки", MessageBoxButtons.OKCancel);                   

                    if (dialogResult == DialogResult.OK)
                    {
                        //  
                        dalSet.SetNewPosition(bll.Get_ID("TypeDevice", "NameDevice", typedevise).ToString(),
                            textBox_Model.Text,
                            textBox_NumberSN.Text, 
                            bll.Get_ID("NameLAN", "NameLAN", LanName).ToString(),
                            textBox_NumberInv.Text,
                            bll.Get_ID("JiraTask", "JiraTask", Jira).ToString());

                        bll.new_Hardware_Into_PC(textBox_NumberInv.Text, typedevise, textBox_Hardware_SN.Text,
                        textBox_Hardware_Model.Text, Jira, LanName);

                        dalSet.AddFDB(Environment.UserName, 4, "Расходники или железо, для PC: " + LanName, textBox_NumberInv.Text,
                           typedevise, textBox_Hardware_SN.Text, textBox_Hardware_Model.Text, dal_get.get_max_ID("[dbo].[HardWare]"));

                    }
                    else if (dialogResult == DialogResult.No)
                    { }
                }
                else
                {
                    messega = @"Инвентарный номер:\t" + textBox_NumberInv.Text +
                                "\nТип устройства:\t\t" + typedevise +
                                "\nСерийный номер:\t\t" + textBox_Hardware_SN.Text +
                                "\nМодель:\t\t" + textBox_Hardware_Model.Text +
                                "\nЗадача в JIRA:\t\t\t" + Jira +
                                "\nКоличество :\t\t" + textBox_Hardware_Sum.Text;
                                

                    dialogResult = MessageBox.Show(messega, "Подтверждение отправки", MessageBoxButtons.OKCancel);


                    if (dialogResult == DialogResult.OK)
                    {
                        //  
                        dalSet.SetNewPosition(bll.Get_ID("TypeDevice", "NameDevice", typedevise).ToString(),
                            textBox_Model.Text,
                            textBox_NumberSN.Text,
                            Convert.ToInt16(textBox_Hardware_Sum.Text),
                            textBox_NumberInv.Text,
                            bll.Get_ID("JiraTask", "JiraTask", Jira).ToString());

                        bll.new_Hardware_Into_StockRoom(textBox_NumberInv.Text, typedevise, textBox_Hardware_SN.Text,
                        textBox_Hardware_Model.Text, Jira, textBox_Hardware_Sum.Text);

                        dalSet.AddFDB(Environment.UserName, 4, "Расходники или железо, на склад, " + textBox_Hardware_Sum.Text +" шт.", textBox_NumberInv.Text,
                           typedevise, textBox_Hardware_SN.Text, textBox_Hardware_Model.Text, dal_get.get_max_ID("[dbo].[HardwareStockRoom]"));

                    }
                    else if (dialogResult == DialogResult.No)
                    { }
                }


            }
        }        

        private void checkBox_Hardware_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Hardware.Checked == true)
            {
                if (checkBox_MainAcount.Checked ==true)
                    checkBox_MainAcount.Checked = false;
                panel_Hardware.Visible = true;
                panel_MainAcount.Visible = false;
            }
            else 
            {
                if (checkBox_MainAcount.Checked == false)
                    checkBox_MainAcount.Checked = true;
                panel_Hardware.Visible = false;
                panel_MainAcount.Visible = true;
            }
        }

        private void checkBox_MainAcount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MainAcount.Checked == true)
            {
                if(checkBox_Hardware.Checked == true)
                    checkBox_Hardware.Checked = false;
                panel_Hardware.Visible = false;
                panel_MainAcount.Visible = true;
            }
            else
            {
                if (checkBox_Hardware.Checked == false)
                    checkBox_Hardware.Checked = true;
                panel_Hardware.Visible = true;
                panel_MainAcount.Visible = false;
            }
        }

        private void checkBox_Hardware_TypeDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Hardware_TypeDevice.Checked == true)
            {
                textBox_Hardware_TypeDevice.Enabled = true;
                comboBox_Hardware_TypeDevice.Enabled = false;
            }

            else
            {
                textBox_Hardware_TypeDevice.Enabled = false;
                comboBox_Hardware_TypeDevice.Enabled = true;
            }
        }

        private void checkBox_Hardware_LanName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Hardware_LanName.Checked == true)
            {
                textBox_Hardware_LanName.Enabled = true;
                comboBox_Hardware_LanName.Enabled = false;
            }

            else
            {
                textBox_Hardware_LanName.Enabled = false;
                comboBox_Hardware_LanName.Enabled = true;
            }
        }

        private void checkBox_SetHardware_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SetHardware.Checked == true)
            {
                groupBox_Hardware_LanName.Enabled = true;                
                groupBox_Hardware_Sum.Enabled = false;
                checkBox_Stockroom.Checked = false;
                groupBox_Hardware_jira.Enabled = false;

            }
            else
            {
                groupBox_Hardware_LanName.Enabled = false;                
                groupBox_Hardware_Sum.Enabled = true;
                checkBox_Stockroom.Checked = true;
                groupBox_Hardware_jira.Enabled =true;
            }

        }

        private void checkBox_Jira_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Jira.Checked == true)
            {
                textBox_jira.Enabled = true;
                comboBox_Jira.Enabled = false;
            }

            else
            {
                textBox_jira.Enabled = false;
                comboBox_Jira.Enabled = true;
            }
        }

        private void checkBox_Hardware_jira_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Hardware_jira.Checked == true)
            {
                textBox_Hardware_jira.Enabled = true;
                comboBox_Hardware_jira.Enabled = false;
            }

            else
            {
                textBox_Hardware_jira.Enabled = false;
                comboBox_Hardware_jira.Enabled = true;
            }
        }

        private void checkBox_Stockroom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Stockroom.Checked == true)
            {
                checkBox_SetHardware.Checked = false;
            }
            else { checkBox_SetHardware.Checked = true; }
        }
    }
}
