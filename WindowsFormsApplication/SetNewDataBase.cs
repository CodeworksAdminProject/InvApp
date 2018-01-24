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

            comboBox_Room.DataSource = dal_get.GetDataRoom();
            comboBox_Room.DisplayMember = "NameRoom";
            comboBox_Room.ValueMember = "NameRoom";

            comboBox_Responsible.DataSource = dal_get.GetDataResponsible();
            comboBox_Responsible.DisplayMember = "NameRes";
            comboBox_Responsible.ValueMember = "NameRes";

            comboBox_Floor.DataSource = dal_get.GetFloor();
            comboBox_Floor.DisplayMember = "floorNambe";
            comboBox_Floor.ValueMember = "floorNambe";

            comboBox_LanName.DataSource = dal_get.GetDataLanName();
            comboBox_LanName.DisplayMember = "NameLAN";
            comboBox_LanName.ValueMember = "NameLAN";

            comboBox_TypeDevice.DataSource = dal_get.GetDataTypeDevice();
            comboBox_TypeDevice.DisplayMember = "NameDevice";
            comboBox_TypeDevice.ValueMember = "NameDevice";


           
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
            else { LanName = comboBox_LanName.SelectedValue.ToString();}

            string Floor;
            if (textBox_Floor.Enabled == true)
                Floor = textBox_Floor.Text;
            else { Floor = comboBox_Floor.SelectedValue.ToString(); }

            string Room;
            if (textBox_Room.Enabled == true)
                Room = textBox_Room.Text;
            else { Room = comboBox_Room.SelectedValue.ToString();}

            DialogResult dialogResult = MessageBox.Show(("Инвентарный номер:\t" + textBox_NumberInv.Text +
                           "\nНазвание в сети:\t\t" + LanName +
                           "\nОтветственный\t\t" + Responsible +
                           "\nМестоположение:\t\t" + Floor + " этаж, " + Room + " комната" +
                           "\nТип устройства:\t\t" + typedevise +
                           "\nСерийный номер:\t\t" + textBox_NumberSN.Text +
                           "\nМодель:\t\t\t" + textBox_Model.Text), "Подтверждение отправки", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                dalSet.SetNewPosition("NULL", bll.Get_ID("TypeDevice", "NameDevice", typedevise).ToString(), textBox_Model.Text,
                textBox_NumberSN.Text, bll.Get_ID("NameRes", "NameRes", Responsible).ToString(),
                bll.Get_ID("NameLAN", "NameLAN", LanName).ToString(), bll.Get_ID("Floor", "floorNambe", Floor).ToString(),
                bll.Get_ID("Room", "NameRoom", Room).ToString(), textBox_NumberInv.Text);

                bll.BodyMailNew(textBox_NumberInv.Text, LanName, Responsible, Floor, Room, typedevise, textBox_NumberSN.Text, textBox_Model.Text);
                MessageBox.Show("Улетело в базу !! ");
            }
            else if (dialogResult == DialogResult.No)
            {

            }

           

        }
           
    }
}
