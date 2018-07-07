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
    public partial class changeFormTwo : Form
    {
        DAL_GET dalGET = new DAL_GET();
        DAL_SET dalSET = new DAL_SET();
        string IDs = null;

        public changeFormTwo()
        {
            InitializeComponent();
            foreach (string[] str in BLL.ArrayChancge)
            {
                if (IDs == null)
                    IDs = str[0];
                else
                    IDs = IDs + "," + str[0];
            }

            if (IDs != null)
                Data_from_DataGrid(dataGridView);

        }

        private void label_ID_text_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_AC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Device_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Data_from_DataGrid(DataGridView dataGridView)
        {            
                dataGridView.DataSource = dalGET.Table_Change_data(IDs);
                if (dataGridView.DataSource != null)
                {
                dataGridView.Columns["ID"].Visible = Properties.Settings.Default.setDataBase_mainTB_ID;
                dataGridView.Columns["ID"].HeaderCell.Value = "ID";
                dataGridView.Columns["ID"].ReadOnly = true;
                dataGridView.Columns["ID"].DefaultCellStyle.ForeColor = Color.Red;


                dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.setDataBase_mainTB_date;
                dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";
                dataGridView.Columns["dateCreated"].ReadOnly = true;
                dataGridView.Columns["dateCreated"].DefaultCellStyle.ForeColor = Color.Red;

                dataGridView.Columns["TypeAC"].Visible = Properties.Settings.Default.setDataBase_mainTB_TypeAC;
                dataGridView.Columns["TypeAC"].HeaderCell.Value = "Вид учёта";
                dataGridView.Columns["TypeAC"].ReadOnly = true;
                dataGridView.Columns["TypeAC"].DefaultCellStyle.ForeColor = Color.RosyBrown ;

                dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.setDataBase_mainTB_InvNum;
                dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.setDataBase_mainTB_LanName;
                dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";
                dataGridView.Columns["NameLAN"].ReadOnly = true;
                dataGridView.Columns["NameLAN"].DefaultCellStyle.ForeColor = Color.Red;

                dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.setDataBase_mainTB_ResName;
                dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";
                dataGridView.Columns["NameRes"].ReadOnly = true;
                dataGridView.Columns["NameRes"].DefaultCellStyle.ForeColor = Color.Red;

                dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.setDataBase_mainTB_Floor;
                dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";
                dataGridView.Columns["floorNambe"].ReadOnly = true;
                dataGridView.Columns["floorNambe"].DefaultCellStyle.ForeColor = Color.Red;

                dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.setDataBase_mainTB_Room;
                dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";
                dataGridView.Columns["NameRoom"].ReadOnly = true;
                dataGridView.Columns["NameRoom"].DefaultCellStyle.ForeColor = Color.Red;

                dataGridView.Columns["NameDevice"].Visible = Properties.Settings.Default.setDataBase_mainTB_TypeDiv;
                dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";
                dataGridView.Columns["NameDevice"].ReadOnly = true;
                dataGridView.Columns["NameDevice"].DefaultCellStyle.ForeColor = Color.RosyBrown;

                dataGridView.Columns["Model"].Visible = Properties.Settings.Default.setDataBase_mainTB_Model;
                dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                dataGridView.Columns["SN"].Visible = Properties.Settings.Default.setDataBase_mainTB_SN;
                dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.setDataBase_mainTB_JiraTask;
                dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";
                dataGridView.Columns["JiraTask"].ReadOnly = true;
                dataGridView.Columns["JiraTask"].DefaultCellStyle.ForeColor = Color.RosyBrown;

                dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.setDataBase_mainTB_WrittenOff;
                dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";
                dataGridView.Columns["WrittenOff"].ReadOnly = true;
                dataGridView.Columns["WrittenOff"].DefaultCellStyle.ForeColor = Color.Red;

                dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.setDataBase_mainTB_Reason;
                dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";
                

                dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);
                }
            
        }
    }

}
