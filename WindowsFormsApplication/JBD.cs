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
    public partial class JBD : Form
    {
        DAL_GET dal = new DAL_GET();
        public JBD()
        {
            InitializeComponent();
            dataGridView1.DataSource = dal.getJDB();

            comboBox_TypeDevice.DataSource = dal.Get_Data_From_Table_From_Colunm("TypeDevice", "NameDevice");
            comboBox_TypeDevice.DisplayMember = "NameDevice";
            comboBox_TypeDevice.ValueMember = "NameDevice";

            comboBox_KindOfActivity.DataSource = dal.Get_Data_From_Table_From_Colunm("KindOfActivity", "KindOfActivity");
            comboBox_KindOfActivity.DisplayMember = "KindOfActivity";
            comboBox_KindOfActivity.ValueMember = "KindOfActivity";
        }



        private void button_Back_ID_Click(object sender, EventArgs e)
        {
            
            panel_Search_ID_5.Visible=false;           

        }

        private void button_next_InvNum_Click(object sender, EventArgs e)
        {
            panel_Search_ID_5.Visible = true;

        }

        private void button_back_InvNum_Click(object sender, EventArgs e)
        {
            panel_InvNum_4.Visible = false;
        }

        private void button_back_model_Click(object sender, EventArgs e)
        {
            panel_Search_Model_3.Visible = false;
        }

        private void button_next__TypeDevice_Click(object sender, EventArgs e)
        {
            panel_Search_SN_2.Visible = true;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            panel_Search_Model_3.Visible = true;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            panel_Search_SN_2.Visible = false;
        }

        private void button_next_Model_Click(object sender, EventArgs e)
        {
            panel_InvNum_4.Visible = true;
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[dateCreated] between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + " 00:00:00' AND '" +
                dateTimePicker2.Value.ToString("MM/dd/yyyy") + " 23:59:59'", "[UserName] LIKE '%" + textBox_UserName.Text + "%'",
                "[KindOfActivity].KindOfActivity LIKE '%" + comboBox_KindOfActivity.SelectedValue.ToString() + "%'",
                "[TypeDevice] LIKE '%" + comboBox_TypeDevice.SelectedValue.ToString() + "%'",
                "[SN] like '%" + textBox_Search_SN.Text + "%'",
                "[Model] like '%" + textBox_Search_Model_3.Text + "%'",
                "COALESCE([JBD].InvNumber,'') like '%" + textBox_InvNum.Text + "%'",
                "[ID_IN_Main_TB] like '%" + textBox_search_ID.Text + "%'");
        }

        private void button_ALL_JBD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB();
        }

        private void button_search_ID_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[ID_IN_Main_TB] like '%"+textBox_search_ID.Text+"%'");
        }

        private void button_SearchKingOfActivity_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[KindOfActivity].KindOfActivity LIKE '%" + 
                comboBox_KindOfActivity.SelectedValue.ToString()+ "%'");
        }

        private void button_SearchuserName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[UserName] LIKE '%"+textBox_UserName.Text+"%'" );
        }

        private void button_SearchDate_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = dal.getJDB("[dateCreated] between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy")+ " 00:00:00' AND '"+
                dateTimePicker2.Value.ToString("MM/dd/yyyy")+" 23:59:59'" );
        }

        private void button_Search_SN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[SN] like '%" + textBox_Search_SN.Text + "%'");
        }

        private void button_InvNum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("COALESCE([JBD].InvNumber,'') like '%" + textBox_InvNum.Text + "%'");
        }

        private void button_Shearch_Model_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[Model] like '%" + textBox_Search_Model_3.Text + "%'");
        }

        private void button_SearchDevice_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.getJDB("[TypeDevice] LIKE '%" +
                comboBox_TypeDevice.SelectedValue.ToString() + "%'");
        }
    }    
}
