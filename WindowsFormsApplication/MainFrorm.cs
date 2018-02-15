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
        BLL bll = new BLL();
        SMTP_CLIENT smttp = new SMTP_CLIENT();

        public MainFrorm()
        {
            InitializeComponent();

            comboBox_Room.DataSource = dal.GetDataRoom();
            comboBox_Room.DisplayMember = "NameRoom";
            comboBox_Room.ValueMember = "NameRoom";

            comboBox_Responsible.DataSource = dal.GetDataResponsible();
            comboBox_Responsible.DisplayMember = "NameRes";
            comboBox_Responsible.ValueMember = "NameRes";

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
               
        private void PRINT_Click(object sender, EventArgs e)
        {
           
                TSCLIB_DLL.openport("USB");
                foreach (DataGridViewRow row in dataGridViewMT.Rows)
                    printLabels(row.Cells[2].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[3].Value.ToString());
                TSCLIB_DLL.closeport();
           
        }

        private void PRINT_LABELS_Click(object sender, EventArgs e)
        {
            
                TSCLIB_DLL.openport("USB");
                foreach (DataGridViewRow row in dataGridViewMT.Rows)
                {
                    if (row.Selected == true)
                    {
                        printLabels(row.Cells[2].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[3].Value.ToString());
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
            TSCLIB_DLL.downloadpcx(Properties.Settings.Default.ImgPath, "LOG2.BMP");
            TSCLIB_DLL.sendcommand("PUTBMP 44,25,\"LOG2.BMP\"");
            //TSCLIB_DLL.sendcommand("CUT");

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

        private void button_Room_Click(object sender, EventArgs e)
        {
            dataGridViewMT.DataSource = dal.GetDataGrid(comboBox_Room.SelectedValue.ToString());
            if (dataGridViewMT.DataSource != null)
                dataGridViewMT.Columns["ID"].Visible = false;
        }

        private void button_Responsible_Click(object sender, EventArgs e)
        {
            dataGridViewMT.DataSource = dal.GetDataGrid_Responsoble(comboBox_Responsible.SelectedValue.ToString());
            if (dataGridViewMT.DataSource != null)
                dataGridViewMT.Columns["ID"].Visible = false;
        }

        private void button_PC_Click(object sender, EventArgs e)
        {
            dataGridViewMT.DataSource = dal.GetDataGrid_NamePC(textBox_PC.Text);
            if (dataGridViewMT.DataSource != null)
                dataGridViewMT.Columns["ID"].Visible = false;
        }

        private void button_New_data_Click(object sender, EventArgs e)
        {
            SetNewDataBase setNewData = new SetNewDataBase();
            setNewData.ShowDialog();
        }      

        private void button_Number_Click(object sender, EventArgs e)
        {
            dataGridViewMT.DataSource = dal.GetDataGrid_inv(textBox_Number.Text);
            if (dataGridViewMT.DataSource != null)
                dataGridViewMT.Columns["ID"].Visible = false;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridViewMT.Rows)
            {
                if (row.Selected == true)
                {
                    BLL.Data.Add(row.Cells[0].Value.ToString());
                    bll.AddDataNew(row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());                    
                }
            }
            
            setDataBase setNewData = new setDataBase();
            //setNewData.Owner = this;
            setNewData.ShowDialog();
        }

        private void MainFrorm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void textBox_Number_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                {
                    dataGridViewMT.DataSource = dal.GetDataGrid_inv(textBox_Number.Text);
                    if (dataGridViewMT.DataSource != null)
                        dataGridViewMT.Columns["ID"].Visible = false;
                }
            }       

        private void textBox_PC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewMT.DataSource = dal.GetDataGrid_NamePC(textBox_PC.Text);
                if (dataGridViewMT.DataSource != null)
                    dataGridViewMT.Columns["ID"].Visible = false;
            }
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
        }

        private void Info_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMT.Rows)
            {
                if (row.Selected == true)
                {
                    BLL.Data.Add(row.Cells[0].Value.ToString());                    
                }
            }
            Delete deleteForm = new Delete();
            deleteForm.Show();

        }
             

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Send_mail send_mail = new Send_mail();
            send_mail.Show();
        }

        private void dataGridViewMT_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() = "Системный блок")
            {
                dataGridView1.DataSource = dal.getHardWare(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (dataGridView1.DataSource != null)
                    dataGridView1.Columns["ID"].Visible = false;

            }
            else { dataGridView1.DataSource = null; }
        }
    } 
}

