using System;
using System.Data;

namespace WindowsFormsApplication
{
    internal class BLL_Buttoms
    {
        DAL_SET_Buttons dalSetButtonns = new DAL_SET_Buttons();
        BLL bll = new BLL();
        DAL_GET dalGet = new DAL_GET();        

        internal void Writtenoff(string addId, string tableName)
        {
            string  KindOfActivity; 
            if (tableName == "HardWare" || tableName == "HardwareStockRoom")
            {
                KindOfActivity = "9";
            }

            else 
            {
                KindOfActivity = "1";
            }
            

            WriteOff set = new WriteOff();
            set.button_OK.Text = "Списать";
            set.ShowDialog();

            if (BLL.flag == true)
            {

                dalSetButtonns.WrittenOff(addId, BLL.ReasonWriteOff, KindOfActivity, tableName);

                dalSetButtonns.AddJDB(Environment.UserName, KindOfActivity, BLL.ReasonWriteOff, addId, tableName);

                BLL.sHtmlTableAddWriteOffForReport = BLL.sHtmlTableAddWriteOffForReport + bll.WrittenOff_And_Delete(addId, BLL.sHtmlTableAddWriteOffForReport, "Add");
                BLL.ReasonWriteOff = null;
                BLL.flag = false;
            }
        }

        internal void Change_data(string addId, string tableName)
        {
            string KindOfActivity;
            if (tableName == "HardWare")
            {
                KindOfActivity = "8";                
            }

            else if (tableName == "HardwareStockRoom")  
            {
                KindOfActivity = "8"; 
            }

            else
            {
                KindOfActivity = "7";
            }

            setDataBase.flag_button = tableName;
            setDataBase.addId = addId;
            setDataBase SetData = new setDataBase();            
            SetData.ShowDialog();      
            
        }

        internal void Print_Label(string ID, string invNumber, string tytpeDiv, string NamePC, string SN, string Model)
        {
            TSCLIB_DLL.openport("USB");

            string numbeSN = "SN: " + SN;
            string Name;

            

            string systemBlok = "СИСТЕМНЫЙ БЛОК";
            int x = 220;
            int y = 24;
            string barcod;

            if (Properties.Settings.Default.int_barcod == 0)
                barcod = ID;
            else  if (Properties.Settings.Default.int_barcod == 1)
                barcod = invNumber;
            else
                barcod = ID;

            if (Properties.Settings.Default.print_name_or_model == 0 & tytpeDiv.ToUpper() != systemBlok.ToUpper())
                Name = "PC: " + NamePC;
            else if (Properties.Settings.Default.print_name_or_model == 1 & tytpeDiv.ToUpper() != systemBlok.ToUpper() )
                Name = "Model: " + Model;
            else
                Name = "PC: " + NamePC;

            DataTable Data = dalSetButtonns.Get_Hardware_TB(ID);

            TSCLIB_DLL.setup("37", "70", "5", "15", "1", "3", "0");            
            TSCLIB_DLL.sendcommand("SET PARTIAL_CUTTER OFF");
            TSCLIB_DLL.sendcommand("CLS");
            TSCLIB_DLL.sendcommand("BARCODE 96, 525, \"128\", 96, 0,270,3,2,\"" + barcod + "\"");
            TSCLIB_DLL.windowsfont(28, 525, 64, 90, 0, 0, "ARIAL", invNumber);
            TSCLIB_DLL.windowsfont(196, 525, 32, 90, 1, 0, "ARIAL", numbeSN);
            TSCLIB_DLL.windowsfont(232, 525, 32, 90, 1, 0, "ARIAL", Name);

            if (Properties.Settings.Default.ImgPath != "" & tytpeDiv.ToUpper() !=systemBlok.ToUpper())
            {
                TSCLIB_DLL.downloadpcx(Properties.Settings.Default.ImgPath, "LOG2.BMP");
                TSCLIB_DLL.sendcommand("PUTBMP 44,25,\"LOG2.BMP\"");
            }

            if (Properties.Settings.Default.print_img == false)
            {
                if (tytpeDiv.ToUpper() == systemBlok.ToUpper())
                {
                    foreach (DataRow row in Data.Rows)
                    {
                        if (row[0].ToString() == "1")
                            TSCLIB_DLL.windowsfont(y, x, 28, 90, 0, 0, "ARIAL", "CPU: " + row[1].ToString());
                        else if (row[0].ToString() == "2")
                            TSCLIB_DLL.windowsfont(y, x, 28, 90, 0, 0, "ARIAL", "RAM: " + row[1].ToString() + " GB");
                        else if (row[0].ToString() == "3")
                            TSCLIB_DLL.windowsfont(y, x, 28, 90, 0, 0, "ARIAL", "HDD: " + row[1].ToString());
                        else if (row[0].ToString() == "4")
                            TSCLIB_DLL.windowsfont(y, x, 28, 90, 0, 0, "ARIAL", "VC:  " + row[1].ToString());
                        else if (row[0].ToString() == "5")
                            TSCLIB_DLL.windowsfont(y, x, 28, 90, 0, 0, "ARIAL", "SSD: " + row[1].ToString());
                        else if (row[0].ToString() == "6")
                            TSCLIB_DLL.windowsfont(y, x, 28, 90, 0, 0, "ARIAL", "MB:  " + row[1].ToString());
                        y = y + 24;
                    }
                }
            }

            else
            {
                if (Properties.Settings.Default.ImgPath != "")
                {

                    TSCLIB_DLL.downloadpcx(Properties.Settings.Default.ImgPath, "LOG2.BMP");
                    TSCLIB_DLL.sendcommand("PUTBMP 44,25,\"LOG2.BMP\"");
                }
            }

            TSCLIB_DLL.printlabel("1", "1");
            TSCLIB_DLL.sendcommand("CUT");
            

            if (Properties.Settings.Default.prin_labe_HW_PC == true)
            {
                TSCLIB_DLL.clearbuffer();
                y = 24;

                if (tytpeDiv.ToUpper() == systemBlok.ToUpper())
                {
                   

                    bool print = false;
                    foreach (DataRow row in Data.Rows)
                    {

                        if (row[0].ToString() == "1")
                        {
                            TSCLIB_DLL.windowsfont(y, 525, 28, 90, 0, 0, "ARIAL", "CPU: " + row[2].ToString());
                            print = true;
                        }

                        else if (row[0].ToString() == "2")
                        {
                            TSCLIB_DLL.windowsfont(y, 525, 28, 90, 0, 0, "ARIAL", "RAM: " + row[1].ToString() + " GB" + ", (" + row[2].ToString() + ")");
                            print = true;
                        }
                        else if (row[0].ToString() == "3")
                        {
                            TSCLIB_DLL.windowsfont(y, 525, 28, 90, 0, 0, "ARIAL", "HDD: " + row[1].ToString() + ", (" + row[2].ToString() + ")");
                            print = true;
                        }
                        else if (row[0].ToString() == "4")
                        {
                            TSCLIB_DLL.windowsfont(y, 525, 28, 90, 0, 0, "ARIAL", "VC:  " + row[1].ToString());
                            print = true;
                        }
                        else if (row[0].ToString() == "5")
                        {
                            TSCLIB_DLL.windowsfont(y, 525, 28, 90, 0, 0, "ARIAL", "SSD: " + row[1].ToString() + ", ("+ row[2].ToString() + ")");
                            print = true;
                        }
                        else if (row[0].ToString() == "6")
                        {
                            TSCLIB_DLL.windowsfont(y, 525, 28, 90, 0, 0, "ARIAL", "Mama:  " + row[2].ToString() );
                            print = true;
                        }

                        y = y + 24;
                    }

                    if (print == true)
                    {
                        TSCLIB_DLL.printlabel("1", "1");
                        TSCLIB_DLL.sendcommand("CUT");
                        
                    }
                }
                
            }

            TSCLIB_DLL.closeport();
        }

        internal void Change_unique_data(string flag)
        {
            if (flag == "MainTB")
            {
                if (BLL.ArrayChancge.Count == 1)
                {
                    changeFormOne change = new changeFormOne();
                    change.ShowDialog();
                }
                else if (BLL.ArrayChancge.Count > 1)
                {
                    changeFormTwo change = new changeFormTwo();
                    change.ShowDialog();
                }
            }
            else if (flag == "HardWare")
            {
               ChangeHardWare.flag = "HardWare";
               ChangeHardWare change = new ChangeHardWare();                
               change.ShowDialog();
            }

            else if (flag == "HardwareStockRoom")
            {
                ChangeHardWare.flag = "HardwareStockRoom";
                ChangeHardWare change = new ChangeHardWare();
                change.ShowDialog();
            }
        }

        internal void Move_Hardware(string ID, string NumberINV, string TypeHardWare, string Model, string SN, string jira, string Old_NameLan,string flag)
        {
            Move_Hardware moveHardwar = new Move_Hardware();
            if (flag == "HardWare")
            {
                
                moveHardwar.ID = ID;
                moveHardwar.NumberINV = NumberINV;
                moveHardwar.TypeHardWare = TypeHardWare;
                moveHardwar.Model = Model;                
                moveHardwar.SN = SN;
                moveHardwar.jira = jira;
                moveHardwar.Old_NameLan = Old_NameLan;
                moveHardwar.Hardware.Text = TypeHardWare + " " + Model + " (SN: " + SN + "). " + "Установлено на " + Old_NameLan + " (Инв №: " +NumberINV+")" ;
                moveHardwar.sum.Text = "1";
                moveHardwar.ShowDialog();
            }

            else if (flag == "HardwareStockRoom")
            {
                moveHardwar.ID = ID;
                moveHardwar.NumberINV = NumberINV;
                moveHardwar.TypeHardWare = TypeHardWare;
                moveHardwar.Model = Model;
                moveHardwar.SN = SN;
                moveHardwar.jira = jira;
                moveHardwar.Old_NameLan = Old_NameLan;
                moveHardwar.Hardware.Text = TypeHardWare + " " + Model + " (SN: " + SN + "). На складе" + " (Инв №: " + NumberINV + ")";
                moveHardwar.sum.Text = Old_NameLan;
                moveHardwar.button_stockroom.Enabled = false;
                moveHardwar.button_stockroom.Visible = false;
                moveHardwar.ShowDialog();
            }
        }

        internal void Note(string  addId, string tableName, string Note)
        {
            WriteOff set = new WriteOff();
            set.button_OK.Text = "Записать";
            set.info.Text = "До 120 символов";
            set.reason.Text = Note;
            set.ShowDialog();
            dalSetButtonns.Note(addId.ToString(), tableName, BLL.ReasonWriteOff);
        }

        internal void Note(string addId, string tableName)
        {
            WriteOff set = new WriteOff();
            set.button_OK.Text = "Записать";
            set.info.Text = "До 120 символов";
            set.ShowDialog();
            dalSetButtonns.Note(addId, tableName, BLL.ReasonWriteOff);
        }
    }
}