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
    public partial class NewItemsHW : Form
    {
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();    
        
        public NewItemsHW()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
            comboBox_Hardware_TypeDevice.DataSource = dal_get.Get_Data_From_Table_From_Colunm("TypeHardWare", "TypeHardWare");
            comboBox_Hardware_TypeDevice.DisplayMember = "TypeHardWare";
            comboBox_Hardware_TypeDevice.ValueMember = "TypeHardWare";
            
            comboBox_Hardware_jira.DataSource = dal_get.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_Hardware_jira.DisplayMember = "JiraTask";
            comboBox_Hardware_jira.ValueMember = "JiraTask";

            set_checkBox_and_set_Combobox(checkBox_Hardware_TypeDevice, textBox_Hardware_TypeDevice, comboBox_Hardware_TypeDevice);
            set_checkBox_and_set_Combobox(checkBox_Hardware_jira, textBox_Hardware_jira, comboBox_Hardware_jira);
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
                        if ((n+1) == Convert.ToInt16(textBox_Sum.Text))
                            sn.button.Text = "Все!";
                        else
                            sn.button.Text = "Дальше";

                        sn.ShowDialog(this);

                        textBox_Hardware_SN.Text = BLL.SerNum;
                    }         
                }          
                    

                New_devices new_devices = new New_devices();

                if (textBox_Hardware_TypeDevice.Enabled == true)
                    new_devices.HardwareType = textBox_Hardware_TypeDevice.Text;
                else
                {
                    if (comboBox_Hardware_TypeDevice.SelectedValue != null)
                        new_devices.HardwareType = comboBox_Hardware_TypeDevice.SelectedValue.ToString();
                    else
                        new_devices.HardwareType = "";
                }

                if (textBox_Hardware_jira.Enabled == true)
                    new_devices.JiraTask = textBox_Hardware_jira.Text;
                else
                {
                    if (comboBox_Hardware_jira.SelectedValue != null)
                        new_devices.JiraTask = comboBox_Hardware_jira.SelectedValue.ToString();
                    else
                        new_devices.JiraTask = "";
                }

                if (textBox_NumberInv.Text != null && textBox_NumberInv.Text != "")
                {
                    string staticPartInv = Regex.Match(textBox_NumberInv.Text, @"^\d{8}").ToString();
                    string dynamicPartInv = Regex.Replace(textBox_NumberInv.Text, @"^\d{8}", @"");

                    dynamicPartInv = Convert.ToString(Convert.ToInt16(dynamicPartInv) + n);
                    new_devices.NumberINV = staticPartInv + dynamicPartInv;
                }
                else
                {
                    MessageBox.Show("Поле с инвентарным номером пустое! ", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    test = false;
                    break;
                }
                new_devices.Model = textBox_Hardware_Model.Text;
                new_devices.SN = textBox_Hardware_SN.Text;
                new_devices.Note = textBox_Note.Text;
                new_devices.Sumaint =  1;

                new_devices.AddHWStockRoom();                
            }
            textBox_NumberInv.Text = "";
            textBox_Sum.Text = "0";
            update();

            if (test == true)
                MessageBox.Show("Все в базе!");
        }

        private void textBox_NumberInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) & (ch != '\u0018') & (ch != '\u0003') & (ch != '\u0016') & (ch != '\b') & (ch != '\u0001'))
            {
                e.Handled = true;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void checkBox_SN_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_SN.Checked == true)
                groupBox_Hardware_SN.Enabled = false;
            else
                groupBox_Hardware_SN.Enabled = true;
        }
    }
}
