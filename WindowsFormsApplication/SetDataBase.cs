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
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();
        ArrayList DataINV = new ArrayList();
       

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

            comboBox_LanName.DataSource = dal_get.Get_Data_From_Table_From_Colunm("NameLAN", "NameLAN");
            comboBox_LanName.DisplayMember = "NameLAN";
            comboBox_LanName.ValueMember = "NameLAN";

            
            DataINV = dal_get.GetForSetForms();

            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
 
            dataGridView1.DataSource = DataINV;
            
        }

        private void textBox_NumberInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
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

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label_LN.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            label_RES.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label_FL.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label_R.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            label_TD.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            label_NS.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            label_M.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }


        private void comboBox_TypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    dalSet.SetChangeData("TypeAC_ID",  bll.Get_ID("TypeAC", "TypeAC", comboBox_TypeAccount.SelectedValue.ToString()).ToString(),
                        row.Cells[0].Value.ToString());
                }
            }

            DataINV = dal_get.GetForSetForms();
            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            dataGridView1.DataSource = DataINV;

        }

        private void comboBox_LanName_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    dalSet.SetChangeData("NameLAN_ID",  bll.Get_ID("NameLAN", "NameLAN", comboBox_LanName.SelectedValue.ToString()).ToString(),
                        row.Cells[0].Value.ToString());
                }
            }

            DataINV = dal_get.GetForSetForms();
            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            dataGridView1.DataSource = DataINV;
        }
        
        private void comboBox_Responsible_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    dalSet.SetChangeData("NameRes_ID", bll.Get_ID("NameRes", "NameRes", comboBox_Responsible.SelectedValue.ToString()).ToString(),
                        row.Cells[0].Value.ToString());
                }
            }

            DataINV = dal_get.GetForSetForms();
            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            dataGridView1.DataSource = DataINV;
        }
                
        private void comboBox_Floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    dalSet.SetChangeData("Floor_ID", bll.Get_ID("Floor", "floorNambe", comboBox_Floor.SelectedValue.ToString()).ToString(),
                       row.Cells[0].Value.ToString());
                }
            }

            DataINV = dal_get.GetForSetForms();
            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            dataGridView1.DataSource = DataINV;
        }

        private void comboBox_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    dalSet.SetChangeData("Room_ID",  bll.Get_ID("Room", "NameRoom", comboBox_Room.SelectedValue.ToString()).ToString(),
                       row.Cells[0].Value.ToString());
                }
            }

            DataINV = dal_get.GetForSetForms();
            comboBox_invinNumber.DataSource = DataINV;
            comboBox_invinNumber.DisplayMember = "NumberINV";
            comboBox_invinNumber.ValueMember = "NumberINV";
            dataGridView1.DataSource = DataINV;
        }


        private void textBox_TypeAccount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true)
                    {
                        dalSet.SetChangeData("TypeAC_ID",  bll.Get_ID("TypeAC", "TypeAC", textBox_TypeAccount.Text).ToString(),
                            row.Cells[0].Value.ToString());
                    }
                }

                DataINV = dal_get.GetForSetForms();
                comboBox_invinNumber.DataSource = DataINV;
                comboBox_invinNumber.DisplayMember = "NumberINV";
                comboBox_invinNumber.ValueMember = "NumberINV";
                dataGridView1.DataSource = DataINV;

            }
        }

        private void textBox_Responsible_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true)
                    {
                        dalSet.SetChangeData("NameRes_ID", bll.Get_ID("NameRes", "NameRes", textBox_Responsible.Text).ToString(),
                            row.Cells[0].Value.ToString());
                    }
                }

                DataINV = dal_get.GetForSetForms();
                comboBox_invinNumber.DataSource = DataINV;
                comboBox_invinNumber.DisplayMember = "NumberINV";
                comboBox_invinNumber.ValueMember = "NumberINV";
                dataGridView1.DataSource = DataINV;
            }
        }

        private void textBox_Floor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true)
                    {
                        dalSet.SetChangeData("Floor_ID", bll.Get_ID("Floor", "floorNambe", textBox_Floor.Text).ToString(),
                           row.Cells[0].Value.ToString());
                    }
                }

                DataINV = dal_get.GetForSetForms();
                comboBox_invinNumber.DataSource = DataINV;
                comboBox_invinNumber.DisplayMember = "NumberINV";
                comboBox_invinNumber.ValueMember = "NumberINV";
                dataGridView1.DataSource = DataINV;
            }
        }

        private void textBox_Room_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true)
                    {
                        dalSet.SetChangeData("Room_ID", bll.Get_ID("Room", "NameRoom", textBox_Room.Text).ToString(),
                            row.Cells[0].Value.ToString());
                    }
                }

                DataINV = dal_get.GetForSetForms();
                comboBox_invinNumber.DataSource = DataINV;
                comboBox_invinNumber.DisplayMember = "NumberINV";
                comboBox_invinNumber.ValueMember = "NumberINV";
                dataGridView1.DataSource = DataINV;
            }
        }

        private void textBox_LanName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true)
                    {
                        dalSet.SetChangeData("NameLAN_ID", bll.Get_ID("NameLAN", "NameLAN", textBox_LanName.Text).ToString(),
                            row.Cells[0].Value.ToString());
                    }
                }

                DataINV = dal_get.GetForSetForms();
                comboBox_invinNumber.DataSource = DataINV;
                comboBox_invinNumber.DisplayMember = "NumberINV";
                comboBox_invinNumber.ValueMember = "NumberINV";
                dataGridView1.DataSource = DataINV;
            }
            
        }


        private void setDataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                bll.Compere(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                   row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());

            BLL.Data.Clear();
            BLL.DataOld.Clear();

        }

    }
}


