using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Drawing.Imaging;

using System.Collections;

namespace WindowsFormsApplication
{
    public partial class MainFrorm : Form
    {
        DAL_GET dal = new DAL_GET();
        DAL_SET dal_set = new DAL_SET();
        BLL_Buttoms bllButtoms = new BLL_Buttoms();
        BLL bll = new BLL();
        SMTP_CLIENT smttp = new SMTP_CLIENT();
        DAL_SEARCH dalSearch = new DAL_SEARCH();


        public static string index;
        int indexControl = 0;
        string flag_button;

        public MainFrorm()
        {
            InitializeComponent();

            comboBox_Room.DataSource = dal.Get_Data_From_Table_From_Colunm("Room", "NameRoom");
            comboBox_Room.DisplayMember = "NameRoom";
            comboBox_Room.ValueMember = "NameRoom";

            comboBox_Responsible.DataSource = dal.Get_Data_From_Table_From_Colunm("NameRes", "NameRes");
            comboBox_Responsible.DisplayMember = "NameRes";
            comboBox_Responsible.ValueMember = "NameRes";

            set_navigation(Properties.Settings.Default.int_navigation);

            string dir = @".\dll_AND_picture\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);


                byte[] resf1;
                byte[] resf2;

                resf1 = Properties.Resources.TSCLIB;
                resf2 = Properties.Resources.TSCLIB1;

                System.IO.File.WriteAllBytes(@".\dll_AND_picture\TSCLIB.dll", resf1);
                System.IO.File.WriteAllBytes(@".\dll_AND_picture\TSCLIB.lib", resf2);
            }

        }

        private void set_navigation(int flag)
        {
            string value;
            string tablename;

            if (flag == 0) {  value = "NameLAN"; tablename = "NameLAN"; }

            else if (flag == 1) { value = "NameRes"; tablename = "NameRes"; }
            
            else { value = "NameDevice"; tablename = "TypeDevice"; }


           dataGridViewPC_Name.DataSource = dal.Get_Data_From_Table_From_Colunm(tablename, value);
        }

        private void stilDataGrid(DataGridView dataGridView, string tableName)
        {
            if (dataGridView.Rows.Count != 0)
            {

                if (tableName == "MainTB")
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.mainForms_mainTB_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.mainForms_mainTB_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["TypeAC"].Visible = Properties.Settings.Default.mainForms_mainTB_TypeAC;
                    dataGridView.Columns["TypeAC"].HeaderCell.Value = "Вид учёта";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.mainForms_mainTB_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.mainForms_mainTB_LanName;
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";

                    dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.mainForms_mainTB_ResName;
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";

                    dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.mainForms_mainTB_Floor;
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";

                    dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.mainForms_mainTB_Room;
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";

                    dataGridView.Columns["NameDevice"].Visible = Properties.Settings.Default.mainForms_mainTB_TypeDiv;
                    dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.mainForms_mainTB_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.mainForms_mainTB_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.mainForms_mainTB_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    //dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.mainForms_mainTB_WrittenOff;
                    //dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    //dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.mainForms_mainTB_Reason;
                    //dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

                else if (tableName == "HardWare")
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.mainForms_hardware_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.mainForms_hardware_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.mainForms_hardware_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.mainForms_hardware_LanName;
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";

                    dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.mainForms_hardware_ResName;
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";

                    dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.mainForms_hardware_Floor;
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";

                    dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.mainForms_hardware_Room;
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";

                    dataGridView.Columns["TypeHardWare"].Visible = Properties.Settings.Default.mainForms_hardware_TypeDiv;
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.mainForms_hardware_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.mainForms_hardware_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.mainForms_hardware_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.mainForms_hardware_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.mainForms_hardware_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

                else if (tableName == "HardwareStockRoom")
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.mainForms_stockroom_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.mainForms_stockroom_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.mainForms_stockroom_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["quantity"].Visible = Properties.Settings.Default.mainForms_stockroom_Quantity;
                    dataGridView.Columns["quantity"].HeaderCell.Value = "Количество";

                    dataGridView.Columns["TypeHardWare"].Visible = Properties.Settings.Default.mainForms_stockroom_TypeDiv;
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.mainForms_stockroom_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.mainForms_stockroom_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.mainForms_stockroom_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.mainForms_stockroom_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.mainForms_stockroom_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

            }
        }

        private void PRINT_Click(object sender, EventArgs e)
        {        
            
            foreach (DataGridViewRow row in dataGridViewMT.Rows)
                bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                        row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                        row.Cells["SN"].Value.ToString(),  row.Cells["Model"].Value.ToString());
                                  
        }

        private void PRINT_LABELS_Click(object sender, EventArgs e)
        {             
                foreach (DataGridViewRow row in dataGridViewMT.Rows)
                {
                    if (row.Selected == true)
                    {
                        bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                            row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                            row.Cells["SN"].Value.ToString(), row.Cells["Model"].Value.ToString());
                    }
                }         
            
        }

        private void button_New_data_Click(object sender, EventArgs e)
        {
            SetNewDataBase setNewData = new SetNewDataBase();
            setNewData.checkBox_MainAcount.Checked = true;
            setNewData.checkBox_Stockroom.Checked = true;
            setNewData.ShowDialog();
            Update_Grid();

        }


        private void button_Update_Click(object sender, EventArgs e)
        {
            if (flag_button == "MainTB")
            {
                string AddId = null;

                foreach (DataGridViewRow row in dataGridViewMT.Rows)
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
            else if (flag_button == "HardwareStockRoom" || flag_button == "HardWare")
            {
                if (dataGridViewMT.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow row in dataGridViewMT.Rows)
                    {
                        string Lan = null;
                        if (flag_button == "HardwareStockRoom")
                            Lan = row.Cells["quantity"].Value.ToString();
                        else
                            Lan = row.Cells["NameLAN"].Value.ToString();

                        if (row.Selected == true)
                        {                          

                            bllButtoms.Move_Hardware(row.Cells["ID"].Value.ToString(),
                                row.Cells["NumberINV"].Value.ToString(),
                                row.Cells["TypeHardWare"].Value.ToString(),
                                row.Cells["Model"].Value.ToString(),
                                row.Cells["SN"].Value.ToString(),
                                row.Cells["JiraTask"].Value.ToString(),
                                Lan,
                                flag_button);

                            
                        }
                    }
                }

                else
                    MessageBox.Show("Количество выбранных объектов превышает допустимое значение (одна позиции за раз)",
                   "Боливар не вынесет двоих", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                Update_Grid();
        }

        private void MainFrorm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void textBox_Number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                {
                dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", textBox_Number.Text);
                stilDataGrid(dataGridViewMT, flag_button);
                }
            indexControl = 1;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }       

        private void textBox_PC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("dbo.NameLAN.NameLAN", textBox_PC.Text);
                stilDataGrid(dataGridViewMT, flag_button);
            }
            indexControl = 2;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void button_ExcelOpen_Click(object sender, EventArgs e)
        {
            bll.excel();
        }

        private void Settings_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            //setNewData.Owner = this;
            settings.ShowDialog();
            set_navigation(Properties.Settings.Default.int_navigation);
        }

        private void Info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            string AddId = null;

            foreach (DataGridViewRow row in dataGridViewMT.Rows)
            {
                if (row.Selected == true)
                {

                    if (AddId != null)
                        AddId += "," + row.Cells["ID"].Value.ToString();
                    else
                        AddId += row.Cells["ID"].Value.ToString();
                }
            }

            if (AddId != null)
            {
                bllButtoms.Writtenoff(AddId, flag_button);                
            }
            Update_Grid();
        }
             
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Send_mail send_mail = new Send_mail();
            send_mail.Show();
        }

        private void dataGridViewPC_Name_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                flag_button = "MainTB";
                if (Properties.Settings.Default.int_navigation == 0)
                    dataGridViewMT.DataSource = dal.GetDataGrid_NamePC(dataGridViewPC_Name.Rows[e.RowIndex].Cells[0].Value.ToString());

                else if (Properties.Settings.Default.int_navigation == 1)
                    dataGridViewMT.DataSource = dal.GetDataGrid_Responsoble(dataGridViewPC_Name.Rows[e.RowIndex].Cells[0].Value.ToString());
                else
                    dataGridViewMT.DataSource = dal.GetDataGrid_TypeDevice(dataGridViewPC_Name.Rows[e.RowIndex].Cells[0].Value.ToString());

                stilDataGrid(dataGridViewMT, flag_button);
                indexControl = 5;
                label_sum.Text = dataGridViewMT.Rows.Count.ToString();
            }
        }

        private void dataGridViewMT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            string systemBlok = "СИСТЕМНЫЙ БЛОК";

            if (dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == systemBlok.ToUpper())
            {

                MainFrorm.index = dataGridViewMT.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                HardWare hardWare = new HardWare();
                hardWare.ID = dataGridViewMT.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                hardWare.INV = dataGridViewMT.Rows[e.RowIndex].Cells["NumberINV"].Value.ToString();
                hardWare.RES = dataGridViewMT.Rows[e.RowIndex].Cells["NameRes"].Value.ToString();
                hardWare.NAME = dataGridViewMT.Rows[e.RowIndex].Cells["NameLAN"].Value.ToString();
                hardWare.SN = dataGridViewMT.Rows[e.RowIndex].Cells["SN"].Value.ToString();
                hardWare.ShowDialog();

            }

            else if (dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 10  )
            {
                String URL = @"http://jira.mara.local/browse/" + dataGridViewMT.Rows[e.RowIndex].Cells[10].Value.ToString();
                System.Diagnostics.Process.Start(URL);
            }
        }

        private void button_WriteOffTable_Click(object sender, EventArgs e)
        {
            WriteOffTable writeOff = new WriteOffTable();
            writeOff.ShowDialog();
            Update_Grid();
        }

        private void JBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JBD jbd = new JBD();
            jbd.Show();
        }

        private void button_Hardware_StockRoom_Click(object sender, EventArgs e)
        {

        }

        private void button_Hardware_PS_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string PC = "системный блок";
            string Monitor = "монитор";
            string UPS = "ибп";
            string Ipphone = "IP телефон";
            string mibiPC = "мини пк";

            if  ( dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == PC.ToUpper())
            {
                dataGridViewMT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Goldenrod;
            }
                       
            else if (dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == Monitor.ToUpper())
            {
                dataGridViewMT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cornsilk;
            }
            
            else if (dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == UPS.ToUpper())
            {
                dataGridViewMT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lavender;
            }

            else if (dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == Ipphone.ToUpper())
            {
                dataGridViewMT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gold;
            }

            else if (dataGridViewMT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == mibiPC.ToUpper())
            {
                dataGridViewMT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
            }

            //dataGridViewTB.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow; //цвет текста
            //dataGridViewTB.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red; //цвет ячейки
        }

        public  void Update_Grid()
        {
            if (flag_button == "MainTB")
            {

                if (indexControl == 1)
                {
                    dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", textBox_Number.Text);
                    stilDataGrid(dataGridViewMT, flag_button);
                }
                else if (indexControl == 2)
                {
                    dataGridViewMT.DataSource = dal.GetDataGrid("dbo.NameLAN.NameLAN", textBox_PC.Text);
                    stilDataGrid(dataGridViewMT, flag_button);
                }
                else if (indexControl == 3)
                {
                    dataGridViewMT.DataSource = dal.GetDataGrid("[dbo].[Room].[NameRoom]", comboBox_Room.SelectedValue.ToString());
                    stilDataGrid(dataGridViewMT, flag_button);
                }
                else if (indexControl == 4)
                {
                    dataGridViewMT.DataSource = dal.GetDataGrid("[dbo].[NameRes].[NameRes]", comboBox_Responsible.SelectedValue.ToString());
                    stilDataGrid(dataGridViewMT, flag_button);
                }
                else if (indexControl == 5)
                {
                    foreach (DataGridViewRow row in dataGridViewPC_Name.Rows)
                    {
                        if (row.Selected == true || row.Cells[0].Selected == true)
                        {
                            dataGridViewMT.DataSource = dal.GetDataGrid_NamePC(row.Cells[0].Value.ToString());
                            stilDataGrid(dataGridViewMT, flag_button);
                        }
                    }
                }
                else
                {
                    dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", "");
                    stilDataGrid(dataGridViewMT, flag_button);
                }
            }

            else if (flag_button == "HardwareStockRoom")
            {
                dataGridViewMT.DataSource = null;
                dataGridViewMT.DataSource = dal.Get_Hardware_StockRoom();
            }

            else if (flag_button == "Hardware")
            {
                dataGridViewMT.DataSource = null;
                dataGridViewMT.DataSource = dal.Get_Hardware_PS();

            }
            
        }

        private void button_Repair_Click(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            Update_Grid();
        }

        private void dataGridViewPC_Name_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                flag_button = "MainTB";
                if (Properties.Settings.Default.int_navigation == 0)
                    dataGridViewMT.DataSource = dal.GetDataGrid_NamePC(dataGridViewPC_Name.Rows[e.RowIndex].Cells[0].Value.ToString());

                else if (Properties.Settings.Default.int_navigation == 1)
                    dataGridViewMT.DataSource = dal.GetDataGrid_Responsoble(dataGridViewPC_Name.Rows[e.RowIndex].Cells[0].Value.ToString());
                else
                    dataGridViewMT.DataSource = dal.GetDataGrid_TypeDevice(dataGridViewPC_Name.Rows[e.RowIndex].Cells[0].Value.ToString());

                stilDataGrid(dataGridViewMT, flag_button);
                indexControl = 5;
                label_sum.Text = dataGridViewMT.Rows.Count.ToString();

            }
        }

        private void comboBox_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid_Combobox("[dbo].[Room].[NameRoom]", comboBox_Room.SelectedValue.ToString());
            stilDataGrid(dataGridViewMT, flag_button);
            indexControl = 3;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void comboBox_Responsible_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid_Combobox("[dbo].[NameRes].[NameRes]", comboBox_Responsible.SelectedValue.ToString());
            stilDataGrid(dataGridViewMT, flag_button);
            indexControl = 4;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void textBox_PC_TextChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid("dbo.NameLAN.NameLAN", textBox_PC.Text);
            stilDataGrid(dataGridViewMT, flag_button);
            indexControl = 2;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void textBox_Number_TextChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", textBox_Number.Text);
            stilDataGrid(dataGridViewMT, flag_button);
            indexControl = 1;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void grubBoxUnloading_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_DATA_Enter(object sender, EventArgs e)
        {

        }

        private void button_deleteDataBase_Click(object sender, EventArgs e)
        {
            WriteOff set = new WriteOff();
            set.Owner = this;
            set.button_OK.Text = "Улалить";
            set.ShowDialog();

            if (BLL.flag == true)
            {
                string AddId = null;

                foreach (DataGridViewRow row in dataGridViewMT.Rows)
                {
                    if (row.Selected == true)
                    {
                        BLL.sHtmlTableDeleteReport = BLL.sHtmlTableDeleteReport + bll.WrittenOff_And_Delete(row.Cells["ID"].Value.ToString(), BLL.sHtmlTableDeleteReport, "Delete");

                        AddId += row.Cells[0].Value.ToString();
                        dal_set.AddFDB(Environment.UserName, 3, BLL.ReasonWriteOff, row.Cells["NumberINV"].Value.ToString(),
                            row.Cells["NameDevice"].Value.ToString(), row.Cells["SN"].Value.ToString(),
                            row.Cells["Model"].Value.ToString(), row.Cells["ID"].Value.ToString());

                        dal_set.Delete("MainTB", row.Cells[0].Value.ToString());
                    }
                }

                BLL.ReasonWriteOff = null;
                BLL.flag = false;
                Update_Grid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag_button = "HardwareStockRoom";
            button_MainTB.ForeColor = button_hardwarePC.ForeColor = Color.MidnightBlue;
            button_MainTB.BackColor = button_hardwarePC.BackColor = Color.White;
            button_Hardware_Stockroom.BackColor = Color.LightGray;
            button_Hardware_Stockroom.ForeColor = Color.Black;
            dataGridViewMT.DataSource = null;
            dataGridViewMT.DataSource = dal.Get_Hardware_StockRoom();
        }

        private void button_hardwarePC_Click(object sender, EventArgs e)
        {
            flag_button = "HardWare";
            button_MainTB.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
            button_MainTB.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            button_hardwarePC.BackColor = Color.LightGray;
            button_hardwarePC.ForeColor = Color.Black;
            dataGridViewMT.DataSource = null;
            dataGridViewMT.DataSource = dal.Get_Hardware_PS();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMT.Rows)
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
            Update_Grid();
        }

        private void button_MainTB_Click(object sender, EventArgs e)
        {
            flag_button = "MainTB";

            button_hardwarePC.ForeColor = button_Hardware_Stockroom.ForeColor = Color.MidnightBlue;
            button_hardwarePC.BackColor = button_Hardware_Stockroom.BackColor = Color.White;
            button_MainTB.BackColor = Color.LightGray;
            button_MainTB.ForeColor = Color.Black;

            dataGridViewMT.DataSource = null;
            dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", null);            
            stilDataGrid(dataGridViewMT, flag_button);
            indexControl = 1;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }
    } 
}

