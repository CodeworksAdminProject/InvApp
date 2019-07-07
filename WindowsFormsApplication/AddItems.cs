using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication
{
    public partial class AddItems : Form
    {
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();

        public AddItems()
        {
            InitializeComponent();
            update();
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

        private void update()
        {
            comboBox_TypeAccount.DataSource = dal_get.Get_Data_From_Table_From_Colunm("TypeAC", "TypeAC");
            comboBox_TypeAccount.DisplayMember = "TypeAC";
            comboBox_TypeAccount.ValueMember = "TypeAC";

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

            comboBox_Jira.DataSource = dal_get.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_Jira.DisplayMember = "JiraTask";
            comboBox_Jira.ValueMember = "JiraTask";

            set_checkBox_and_set_Combobox(checkBox_Account, textBox_TypeAccount, comboBox_TypeAccount);
            set_checkBox_and_set_Combobox(checkBox_Responsible, textBox_Responsible, comboBox_Responsible);
            set_checkBox_and_set_Combobox(checkBox_LanName, textBox_LanName, comboBox_LanName);
            set_checkBox_and_set_Combobox(checkBox_Floor, textBox_Floor, comboBox_Floor);
            set_checkBox_and_set_Combobox(checkBox_Room, textBox_Room, comboBox_Room);
            set_checkBox_and_set_Combobox(checkBox_TypeDevice, textBox_TypeDevice, comboBox_TypeDevice);
            set_checkBox_and_set_Combobox(checkBox_Jira, textBox_jira, comboBox_Jira);
        }

        private string  Get_value_Comboboks(ComboBox comboBox, TextBox textBox)
        {
            string value;

            if (textBox.Enabled == true)
                value = textBox.Text;
            else
            {
                if (comboBox.SelectedValue != null)
                    value = comboBox.SelectedValue.ToString();
                else
                    value = "";
            }

            return value;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            bool test = false;

            for (int n = 0; n < Convert.ToInt16(textBox_Sum.Text); n++)
            {
                test = true;
                if (this.checkBox_SN.Checked == true)
                {
                    using (SN sn = new SN())
                    {
                        if ((n + 1) == Convert.ToInt16(textBox_Sum.Text))
                            sn.button.Text = "Все!";
                        else
                            sn.button.Text = "Дальше";

                        sn.ShowDialog(this);

                        textBox_NumberSN.Text = BLL.SerNum;
                    }
                }

                New_devices new_devices = new New_devices();
               
                new_devices.TypeAC = Get_value_Comboboks(comboBox_TypeAccount, textBox_TypeAccount);
                new_devices.TypeDevice = Get_value_Comboboks(comboBox_TypeDevice, textBox_TypeDevice);
                new_devices.NameRes = Get_value_Comboboks(comboBox_Responsible, textBox_Responsible);
                new_devices.NameLAN = Get_value_Comboboks(comboBox_LanName, textBox_LanName);
                new_devices.Floor = Get_value_Comboboks(comboBox_Floor, textBox_Floor);
                new_devices.Room = Get_value_Comboboks(comboBox_Room, textBox_Room);
                new_devices.JiraTask = Get_value_Comboboks(comboBox_Jira, textBox_jira);

                if (textBox_NumberInv.Text != null && textBox_NumberInv.Text != "")
                {
                    string staticPartInv = Regex.Match(textBox_NumberInv.Text, @"^\d{8}").ToString();
                    string dynamicPartInv = Regex.Replace(textBox_NumberInv.Text, @"^\d{8}", @"");

                    dynamicPartInv  = Convert.ToString(Convert.ToInt16(dynamicPartInv) + n);
                    new_devices.NumberINV = staticPartInv + dynamicPartInv;
                }
                else
                {
                    MessageBox.Show("Поле с инвентарным номером пустое! ", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    test = false;
                    break;
                }                  
                
                new_devices.Model = textBox_Model.Text;
                new_devices.SN = textBox_NumberSN.Text;

                new_devices.AddMAinInDataBase();
            }
            textBox_NumberInv.Text = "";
            textBox_Sum.Text= "0";
            update();
            if (test==true)
                MessageBox.Show("Все в базе!");
        }

        private void checkBox_SN_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_SN.Checked == true)
                groupBox_NuberSN.Enabled = false;
            else
                groupBox_NuberSN.Enabled = true;
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_NumberInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) & (ch != '\u0018') & (ch != '\u0003') & (ch != '\u0016') & (ch != '\b') & (ch != '\u0001'))
            {
                e.Handled = true;
            }
        }
    }
}
