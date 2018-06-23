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

        private void stilDataGrid()
        {
            if (dataGridViewMT.DataSource != null)
            {
                dataGridViewMT.Columns["ID"].Visible = false;
                dataGridViewMT.Columns["floorNambe"].Visible = false;


                dataGridViewMT.EnableHeadersVisualStyles = false;
                dataGridViewMT.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewMT.ColumnHeadersDefaultCellStyle.Font.FontFamily, 11f, FontStyle.Bold  | FontStyle.Italic); //жирный курсив размера 16 FontStyle.Italic
                
                //dataGridViewTB.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow; //цвет текста
                //dataGridViewTB.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red; //цвет ячейки

                dataGridViewMT.Columns["dateCreated"].HeaderCell.Value = "Дата:";
               // dataGridViewMT.Columns["TypeAC"].HeaderCell.Value = "Вид учета:";
                dataGridViewMT.Columns["NumberINV"].HeaderCell.Value = "Инвентарный №:";
                dataGridViewMT.Columns["NameLAN"].HeaderCell.Value = "Имя в сети:";
                dataGridViewMT.Columns["NameRes"].HeaderCell.Value = "Ответственный:";
                dataGridViewMT.Columns["NameRoom"].HeaderCell.Value = "Месторасположение:";
                dataGridViewMT.Columns["SN"].HeaderCell.Value = "Серийный №:";
                dataGridViewMT.Columns["Model"].HeaderCell.Value = "Модель:";
                dataGridViewMT.Columns["NameDevice"].HeaderCell.Value = "Тип устройства:";


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
            
                TSCLIB_DLL.openport("USB");
                foreach (DataGridViewRow row in dataGridViewMT.Rows)
                {
                    if (row.Selected == true)
                    {
                        bllButtoms.Print_Label(row.Cells["ID"].Value.ToString(), row.Cells["NumberINV"].Value.ToString(),
                            row.Cells["NameDevice"].Value.ToString(), row.Cells["NameLAN"].Value.ToString(),
                            row.Cells["SN"].Value.ToString(), row.Cells["Model"].Value.ToString());
                    }
                }
                TSCLIB_DLL.closeport();
            
        }

        private void printLabels(string invNumber, string SN, string PC_Name)
        {
            string numbeSN = "SN: " + SN;
            string NamePC = "PC: " + PC_Name;
            
            TSCLIB_DLL.setup("37", "70", "5", "15", "1", "3", "0");
            //TSCLIB_DLL.sendcommand("GAP 3");
            //TSCLIB_DLL.sendcommand("DIRECTION 0");
            //TSCLIB_DLL.downloadpcx("UL.PCX", "UL.PCX");
            //TSCLIB_DLL.sendcommand("PUTPCX 148,48,\"UL.PCX\"");
            //TSCLIB_DLL.sendcommand("SPEED 2");
            TSCLIB_DLL.sendcommand("SET PARTIAL_CUTTER OFF");
            TSCLIB_DLL.sendcommand("CLS");
            TSCLIB_DLL.sendcommand("BARCODE 96, 525, \"128\", 96, 0,270,3,2,\"" + invNumber + "\"");
            TSCLIB_DLL.windowsfont( 28, 525, 64, 90, 0, 0, "ARIAL", invNumber );
            TSCLIB_DLL.windowsfont( 196, 525, 32, 90, 1, 0, "ARIAL", numbeSN);
            TSCLIB_DLL.windowsfont( 232, 525, 32, 90, 1, 0, "ARIAL", NamePC);

            if (Properties.Settings.Default.ImgPath != "")
            {
                TSCLIB_DLL.downloadpcx(Properties.Settings.Default.ImgPath, "LOG2.BMP");
                TSCLIB_DLL.sendcommand("PUTBMP 44,25,\"LOG2.BMP\"");
            }
            
            //TSCLIB_DLL.sendcommand("CUT");
            //
            //Open specified printer driver
            //   TSCLIB_DLL.setup("37", "70", "4", "12", "0", "1", "1");                              //Setup the media size and sensor type info
            // TSCLIB_DLL.clearbuffer();                                                             //Clear image buffer
            //TSCLIB_DLL.barcode("78", "491", "128M", "136", "1", "270", "2", "2", "19012016565");   //Drawing barcode
            //TSCLIB_DLL.printerfont("24", "491", "3", "270", "1", "1", "S/N: 011642042");          //Drawing printer font
            //TSCLIB_DLL.windowsfont(48, 491, 24, 90, 1, 0, "ARIAL", "NAME: MN-ADPC02");            //Draw windows font
            // TSCLIB_DLL.downloadpcx("UL.PCX", "UL.PCX");                                         //Download PCX file into printer
            // TSCLIB_DLL.sendcommand("PUTPCX 136,70,\"UL.PCX\"");                                 // TSCLIB_DLL.downloadpcx("UL.PCX", "UL.PCX");                                         //Download PCX file into printer
            // TSCLIB_DLL.sendcommand("PUTPCX 136,70,\"UL.PCX\"");                                //Drawing PCX graphic
            TSCLIB_DLL.printlabel("1", "1");
            TSCLIB_DLL.sendcommand("CUT");

            //Print labels
            //TSCLIB_DLL.closeport();
           
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
            /* foreach (DataGridViewRow row in dataGridViewMT.Rows)
             {
                 if (row.Selected == true)
                 {
                     BLL.Data.Add(row.Cells["ID"].Value.ToString());
                    // bll.AddDataNew(row.Cells["ID"].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
                 }
             }


             setDataBase.flag_button = flag_button;
             setDataBase setNewData = new setDataBase();          

             //setNewData.Owner = this;
             setNewData.ShowDialog();*/
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
                stilDataGrid();
                }
            indexControl = 1;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }       

        private void textBox_PC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("dbo.NameLAN.NameLAN", textBox_PC.Text);
                stilDataGrid();
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

                stilDataGrid();
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
            flag_button = "HardwareStockRoom";
            dataGridViewMT.DataSource= dal.Get_Hardware_StockRoom();
        }

        private void button_Hardware_PS_Click(object sender, EventArgs e)
        {
            flag_button = "HardWare";
            dataGridViewMT.DataSource=dal.Get_Hardware_PS();
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
            if (indexControl  == 1)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", textBox_Number.Text);
                stilDataGrid();
            }
            else if (indexControl == 2)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("dbo.NameLAN.NameLAN", textBox_PC.Text);
                stilDataGrid();
            }
            else if (indexControl == 3)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("[dbo].[Room].[NameRoom]", comboBox_Room.SelectedValue.ToString());
                stilDataGrid();
            }
            else if (indexControl == 4)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("[dbo].[NameRes].[NameRes]", comboBox_Responsible.SelectedValue.ToString());
                stilDataGrid();
            }
            else if (indexControl == 5)
            {
                foreach (DataGridViewRow row in dataGridViewPC_Name.Rows)
                {
                    if (row.Selected == true || row.Cells[0].Selected == true)
                    {
                        dataGridViewMT.DataSource = dal.GetDataGrid_NamePC(row.Cells[0].Value.ToString());
                        stilDataGrid();
                    }
                }
            }
            else
            {
                dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", "");
                stilDataGrid();
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

                stilDataGrid();
                indexControl = 5;
                label_sum.Text = dataGridViewMT.Rows.Count.ToString();

            }
        }

        private void comboBox_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid_Combobox("[dbo].[Room].[NameRoom]", comboBox_Room.SelectedValue.ToString());
            stilDataGrid();
            indexControl = 3;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void comboBox_Responsible_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid_Combobox("[dbo].[NameRes].[NameRes]", comboBox_Responsible.SelectedValue.ToString());
            stilDataGrid();
            indexControl = 4;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void textBox_PC_TextChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid("dbo.NameLAN.NameLAN", textBox_PC.Text);
            stilDataGrid();
            indexControl = 2;
            label_sum.Text = dataGridViewMT.Rows.Count.ToString();
        }

        private void textBox_Number_TextChanged(object sender, EventArgs e)
        {
            flag_button = "MainTB";
            dataGridViewMT.DataSource = dal.GetDataGrid("MainTB.NumberINV", textBox_Number.Text);
            stilDataGrid();
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
    } 
}

