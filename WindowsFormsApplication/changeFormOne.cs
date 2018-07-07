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
    public partial class changeFormOne : Form
    {
        BLL bll =  new BLL();
        DAL_GET dalGet = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        

        public changeFormOne()
        {
            InitializeComponent();

            // заполняем форму  старые значения
            foreach (string[] str in BLL.ArrayChancge)
            {
                label_ID.Text = str[0].ToString();
                label_date.Text = str[1].ToString();
                label_AC_old.Text = str[2].ToString();
                label_inv_old.Text = str[3].ToString();
                label_device_old.Text = str[4].ToString();
                label_SN_old.Text = str[5].ToString();
                label_model_old.Text = str[6].ToString();
                label_Jira_old.Text = str[7].ToString();
                textBox_inv.Text = str[3].ToString();
                textBox_model.Text = str[6].ToString();
                textBox_SN.Text = str[5].ToString();
            }            

            // загружаем данные в  comboboxs 
            comboBox_device.DataSource = dalGet.Get_Data_From_Table_From_Colunm("TypeDevice", "NameDevice");
            comboBox_device.DisplayMember = "NameDevice";
            comboBox_device.ValueMember = "NameDevice";

            comboBox_AC.DataSource = dalGet.Get_Data_From_Table_From_Colunm("TypeAC", "TypeAC");
            comboBox_AC.DisplayMember = "TypeAC";
            comboBox_AC.ValueMember = "TypeAC";

            comboBox_jira.DataSource = dalGet.Get_Data_From_Table_From_Colunm("[JiraTask]", "[JiraTask]");
            comboBox_jira.DisplayMember = "JiraTask";
            comboBox_jira.ValueMember = "JiraTask";

            // выбираем значения 
            comboBox_device.SelectedValue = label_device_old.Text;
            comboBox_jira.SelectedValue = label_Jira_old.Text;
            comboBox_AC.SelectedValue = label_AC_old.Text;

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string Type_AC = null;            
            if (textBox_AC.Enabled == true)
                Type_AC = textBox_AC.Text;
            else { Type_AC = comboBox_AC.SelectedValue.ToString(); }

            string Type_Device;
            if (textBox_device.Enabled == true)
                Type_Device = textBox_device.Text;
            else { Type_Device = comboBox_device.SelectedValue.ToString(); }

            string Type_Jira ;
            if (textBox_jira.Enabled == true)
                Type_Jira = textBox_jira.Text;
            else
            {
                if (comboBox_jira.SelectedValue.ToString() != null)
                    Type_Jira = comboBox_jira.SelectedValue.ToString();
                else
                    Type_Jira = "";
            }

            bll.change(label_ID.Text, Type_AC, textBox_inv.Text, Type_Device, textBox_SN.Text, textBox_model.Text, Type_Jira);

            dalSet.change(label_ID.Text,
                bll.Get_ID("TypeAC", "TypeAC", Type_AC).ToString(),  
                textBox_inv.Text,
                bll.Get_ID("TypeDevice", "NameDevice", Type_Device).ToString(),
                textBox_SN.Text, 
                textBox_model.Text, 
                bll.Get_ID("JiraTask", "JiraTask", Type_Jira).ToString());

            BLL.ArrayChancge.Clear();
            this.Close();
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

        private void checkBox_device_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_device.Checked == true)
            {
                textBox_device.Enabled = true;
                comboBox_device.Enabled = false;
            }

            else
            {
                textBox_device.Enabled = false;
                comboBox_device.Enabled = true;
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            BLL.ArrayChancge.Clear();
            this.Close();
        }

        private void changeFormOne_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.ArrayChancge.Clear();
        }
    }
}
