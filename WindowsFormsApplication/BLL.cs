﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace WindowsFormsApplication
{
    class BLL
    {

        DAL_GET dalGet = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        SMTP_CLIENT smtp = new SMTP_CLIENT();

        public static ArrayList Data = new ArrayList();        
        public static ArrayList DataOld = new ArrayList();
        public static ArrayList MailBody = new ArrayList();
        public static string sMailBody;
        public static string heds;
        public static string sMailBodyNew ;
        public static string sMailBodyDelete;
        static int n = 1;
        static int t = 1;

        public int Get_ID(string Table, string Column, string param)
        {


            int Result;
            if (param == dalGet.GetParam_Tables(Table, Column, param))
            {
                Result = dalGet.GetID_Tables(Table, Column, param);
                return Result;
            }
            else
            {
                dalSet.SetNewPosition(Table, Column, param);
                Result = dalGet.GetID_Tables(Table, Column, param);
                return Result;
            }

        }

        public void AddDataNew(string ID, string NameLan, string NameRes, string Floor, string Room)
        {
            string[] str = new string[] { ID, NameLan, NameRes, Floor, Room };
            DataOld.Add(str);
        }

        public void Compere(string ID, string NameLan, string NameRes, string Floor, string Room, string NameDevice)
        {
            
            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + "</font> были внесены  следующие  изменения: </p></h1>";

            foreach (string[] str in DataOld)
            {
                if (str[0] == ID)
                {
                    if((str[1] != NameLan) || (str[2] != NameRes) || (str[3] != Floor) || (str[4] != Room))
                    {
                        if (BLL.sMailBody == null)
                            BLL.sMailBody = "<h2>Добавлены правки во следующие  позиции:</h2>";

                        BLL.sMailBody = BLL.sMailBody +  "<h4><p>" + BLL.n + ") " +  NameDevice + " c инвентарным № <font  color = 'red' ><i>" +  str[0] + "</i></font></h4>";

                        if (str[2] != NameRes)
                        {
                            BLL.sMailBody = BLL.sMailBody + "Изменено  ответственное  лицо с  <font  color='blue'>" + str[2] + " </font> на  <font  color='red'>" + NameRes + "</font><br>";
                        }
                        if (str[3] != Floor)
                        {
                            BLL.sMailBody = BLL.sMailBody + "Перетащили  с <font  color='blue'> " + str[3] + "</font> этажа на <font  color='red'>" + Floor + " этаж </font><br>";
                        }
                        if (str[4] != Room)
                        {
                            BLL.sMailBody = BLL.sMailBody + "Был в <font  color='blue'>" + str[4] + "</font>  а, заволокли  <font  color='red'> в " + Room + "</font><br>";
                        }
                        if (str[1] != NameLan)
                        {
                            BLL.sMailBody = BLL.sMailBody + "Изменили сетевое имя с  <font  color='blue'>" + str[1] + "</font> на <font  color = 'red' > "  + NameLan + "</font><br>";
                        }
                                                
                        BLL.sMailBody = BLL.sMailBody + "<br></p>";
                    }
                }
                n++;
            }
            
        }

        public void Delete(string invNumber, string nameDevice, string SN, string model, string reason)
        {
            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + "</font> были внесены  следующие  изменения: </p></h1>";

            if (BLL.sMailBodyDelete == null)
                BLL.sMailBodyDelete = "<h2>Следующие  позиции сняты с учета:</h2>";

            BLL.sMailBodyDelete = BLL.sMailBodyDelete + "<h4><p>" + BLL.t + ") " + nameDevice + " (Модель:<font  color = 'red' ><i> " +
                model + "</i></font>" +
                ",  SN: <font  color = 'red' ><i>" + SN + "</i></font>" +
                ") c инвентарным № <font  color = 'red' ><i>" + invNumber + "</i></font></br>" +
                "Установлена отметка о снятии с учета, по причине: <font  color = 'red' ><i> " + reason + "</i></font></h4> ";
            BLL.t++;
        }

        public void BodyMailNew(string Inv, string NameLan, string NameRes, string Floor, string Room, string NameDevice, string SN, string Model)
        {

            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + " </font> были внесены  следующие  изменения: </p></h1>";

            if (sMailBodyNew == null)
            {
                sMailBodyNew = "<h2>Добавлены новое (перечисленно в таблице):</h2>";
                sMailBodyNew = sMailBodyNew +"Таблица  нового ";
                sMailBodyNew = sMailBodyNew + "<table>" +
                    "<tr>" +
                    "<th>Инвентарный номер</th>" +
                     "<th>Название в сети</th>" +
                     "<th>Ответственный</th>" +
                     "<th>Этаж</th>" +
                     "<th>Помещение</th>" +
                     "<th>Тип устройства</th>" +
                     "<th>Серийный номер</th>" +
                     "<th>Модель</th>" +
                     "</tr>";
            }


            sMailBodyNew = sMailBodyNew + 
                       "<tr>" +
                       "<td>"+ Inv + "</td>" +
                        "<td>" + NameLan + "</td>" +
                        "<td>" + NameRes + "</td>" +
                        "<td>"+Floor+"</td>" +
                        "<td>" + Room + "</td>" +
                        "<td>"+ NameDevice + "</td>" +
                        "<td>"+SN+"</td>" +
                        "<td>"+ Model+"</td>" +
                        "</tr>";
                                          


                
            
        }

        public void excel()
        {
            
            
            string data;
            try
            {
                DataTable floorArray = dalGet.GetFloorTable();
                int floorCount = 0 ;

                foreach (DataRow row in floorArray.Rows)
                {
                    floorCount++;
                }

                    Microsoft.Office.Interop.Excel.Application excApp = new Excel.Application();
                // книга 
                excApp.Visible = true;
                excApp.SheetsInNewWorkbook = floorCount++;
                excApp.Workbooks.Add(Type.Missing);
               
               
                // настройка  стиля  ссылок 
                excApp.ReferenceStyle = Excel.XlReferenceStyle.xlA1;
                // временно  неактивный  докуметн
                excApp.Interactive = false;
                excApp.EnableEvents = false;
                Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
                Excel.Worksheet excSheet;
                double height = 2;

                //мутим  файл 
                

               // for (int i = 0; i < floorArray.Rows.Count-1; i++)
                //  excSheet = (Excel.Worksheet)excApp.Worksheets.Add();

                for (int i = 0; i < floorArray.Rows.Count; i++)
                {
                    int coll = 1;
                    int row = 1;
                    // excSheet = (Excel.Worksheet)excApp.Worksheets.Add();
                    excSheet = (Excel.Worksheet)excApp.Worksheets.get_Item(1+i);
                   

                    excSheet.Name = floorArray.Rows[i].ItemArray[0].ToString() + " этаж";

                    DataTable roomArray = dalGet.GetRoomTabel(floorArray.Rows[i].ItemArray[0].ToString());
                    



                    for (int t = 0; t < roomArray.Rows.Count; t++)
                    {
                        int frameRoomColl = coll;
                        int framRoomRow = row;
                        excSheet.Activate();
                        Excel.Range excSheetRange = excSheet.get_Range("A" + row, "I" + row);
                        excSheetRange.Font.Size = 5;
                        excSheetRange.RowHeight = height;
                        excSheetRange.Rows.ColumnWidth = 
                        excSheetRange.Interior.ColorIndex = 1;
                        row++;

                        excSheetRange.Columns[1].ColumnWidth = 5;
                        excSheetRange.Columns[2].ColumnWidth = 5;
                        excSheetRange.Columns[3].ColumnWidth = 19;
                        excSheetRange.Columns[4].ColumnWidth = 15;
                        excSheetRange.Columns[5].ColumnWidth = 10;
                        excSheetRange.Columns[6].ColumnWidth = 18;
                        excSheetRange.Columns[7].ColumnWidth = 25;
                        excSheetRange.Columns[8].ColumnWidth = 25;
                        excSheetRange.Columns[9].ColumnWidth = 37;

                        excSheetRange = excSheet.get_Range("A" + row, "I" + row);
                        excSheetRange.Merge(Type.Missing);
                        excSheetRange.WrapText = true;
                        excSheetRange.Font.Bold = true;
                        excSheetRange.Font.Size = 18;
                        excSheetRange.Interior.ColorIndex = 37;
                        excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                        excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                        excSheetRange.Value2 = "Комната: " + roomArray.Rows[t].ItemArray[0].ToString() +
                            ", этаж: " + floorArray.Rows[i].ItemArray[0].ToString();
                        row++;

                        excSheetRange = excSheet.get_Range("B" + row, "I" + row);
                        excSheetRange.WrapText = true;
                        excSheetRange.Font.Italic = true;
                        excSheetRange.Font.Size = 11;
                        excSheetRange.Interior.ColorIndex = 40;
                        excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                        excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                        Excel.Borders border = excSheetRange.Borders;
                        border.LineStyle = Excel.XlLineStyle.xlContinuous;
                        excSheet.Cells[row, 3] = "дата записи в  БД";
                        excSheet.Cells[row, 4] = "Инвентарный номер";
                        excSheet.Cells[row, 5] = "Тип учёта";
                        excSheet.Cells[row, 6] = "Ответственный";
                        excSheet.Cells[row, 7] = "Тип устройства";
                        excSheet.Cells[row, 8] = "Серийный номер";
                        excSheet.Cells[row, 9] = "Модель";
                        row++;

                        DataTable LanNameArray = dalGet.GetLanNameTabel(roomArray.Rows[t].ItemArray[0].ToString());

                        for (int w = 0; w < LanNameArray.Rows.Count; w++)
                        {
                            excSheetRange = excSheet.get_Range("B" + row, "I" + row);
                            excSheetRange.Merge(Type.Missing);
                            excSheetRange.Interior.ColorIndex = 1;
                            excSheetRange.Font.Size = 2;
                            excSheetRange.RowHeight = height;
                            row++;

                            excSheetRange = excSheet.get_Range("B" + row, "I" + row);
                            excSheetRange.Merge(Type.Missing);
                            excSheetRange.WrapText = true;
                            excSheetRange.Font.Bold = true;
                            excSheetRange.Font.Size = 14;
                            excSheetRange.Interior.ColorIndex = 39;
                            excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                            excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                            excSheetRange.Value2 = LanNameArray.Rows[w].ItemArray[0].ToString() + ":";
                            row++;

                            DataTable MainArray = dalGet.GetMainTabel(LanNameArray.Rows[w].ItemArray[0].ToString(),
                                roomArray.Rows[t].ItemArray[0].ToString());

                            for (int x = 0; x < MainArray.Rows.Count; x++)
                            {

                               // excSheetRange.Font.Size = 12;
                                //border = excSheetRange.Borders;
                                //border.LineStyle = Excel.XlLineStyle.xlContinuous;

                                excSheetRange = excSheet.get_Range("d" + row, "I" + row);
                                excSheetRange.NumberFormat = "@"; 
                                for (int z = 0; z < MainArray.Columns.Count; z++)
                                {
                                    data = MainArray.Rows[x].ItemArray[z].ToString();
                                    excSheet.Cells[row, z + 3] = data;
                                }

                                excSheetRange = excSheet.get_Range("C" + row);
                                excSheetRange.NumberFormat = "dd.mmmm.yyyy";

                                excSheetRange = excSheet.get_Range("C" + row, "I" + row);
                                excSheetRange.Font.Size = 12;
                                border = excSheetRange.Borders;
                                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                row++;
                                //excSheetRange.Columns.AutoFit();
                                excSheetRange.Rows.AutoFit();
                            }

                            excSheetRange = excSheet.get_Range("B" + (framRoomRow + 3), "I" + (row - 1));
                            

                            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft;
                            excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                            excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            excSheetRange.Borders[BorderIndex].ColorIndex = 0;


                            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop;
                            excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                            excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            excSheetRange.Borders[BorderIndex].ColorIndex = 0;


                            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
                            excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                            excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            excSheetRange.Borders[BorderIndex].ColorIndex = 0;

                            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight;
                            excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                            excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            excSheetRange.Borders[BorderIndex].ColorIndex = 0;

                        }

                        excSheetRange = excSheet.get_Range("A" + framRoomRow, "I" + (row-1));
                        BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft;
                        excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        excSheetRange.Borders[BorderIndex].ColorIndex = 0;


                        BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop;
                        excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        excSheetRange.Borders[BorderIndex].ColorIndex = 0;


                        BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
                        excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        excSheetRange.Borders[BorderIndex].ColorIndex = 0;

                        BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight;
                        excSheetRange.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        excSheetRange.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        excSheetRange.Borders[BorderIndex].ColorIndex = 0;

                        //excSheetRange = excSheet.UsedRange;
                        
                        releaseObject(excSheetRange);

                    }



                 releaseObject(excSheet);   
                }
               

           // excApp.Visible = true;
            excApp.Interactive = true;
            excApp.ScreenUpdating = true;
            excApp.UserControl = true;
            releaseObject(excApp);



            }
           

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            
        }

        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        } 
    }
}
