﻿using System;
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

            if (Properties.Settings.Default.inr_barcod == 0)
                barcod = ID;
            else  if (Properties.Settings.Default.inr_barcod == 1)
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

            TSCLIB_DLL.printlabel("1", "1");
            TSCLIB_DLL.sendcommand("CUT");
            TSCLIB_DLL.closeport();
        }
    }
}