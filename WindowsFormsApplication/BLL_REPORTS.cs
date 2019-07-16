using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;
using System.IO;


using Excel = Microsoft.Office.Interop.Excel;
using System.Data;


namespace WindowsFormsApplication
{
    class BLL_REPORTS
    {
        DAL_GET_REPORT dalGet = new DAL_GET_REPORT();

        public void excel(string filename)
        {

            string data;
            try
            {
                DataTable floorArray = dalGet.GetFloorTable();
                int floorCount = 4;
                int Workbook = 0;

                if (Properties.Settings.Default.room != null || Properties.Settings.Default.room != "")
                {
                    string room_setting = Properties.Settings.Default.room;
                    String[] rooms = room_setting.Split(',');
                    foreach (var room in rooms)
                    {
                        floorCount++;
                    }
                }

                foreach (DataRow row in floorArray.Rows)
                {
                    floorCount++;
                }



                Microsoft.Office.Interop.Excel.Application excApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                // книга 
                excApp.Visible = false;
                excApp.SheetsInNewWorkbook = floorCount;
                xlWorkBook = excApp.Workbooks.Add(Type.Missing);


                // настройка  стиля  ссылок 
                excApp.ReferenceStyle = Excel.XlReferenceStyle.xlA1;
                // временно  неактивный  докуметн
                excApp.Interactive = false;
                excApp.EnableEvents = false;
                Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
                //xlWorkBook = excApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet excSheet;
                double height = 2;


                // for (int i = 0; i < floorArray.Rows.Count-1; i++)
                //  excSheet = (Excel.Worksheet)excApp.Worksheets.Add();

                for (int i = 0; i < floorArray.Rows.Count; i++)
                {

                    int coll = 1;
                    int row = 1;
                    
                    // excSheet = (Excel.Worksheet)excApp.Worksheets.Add();
                    excSheet = (Excel.Worksheet)excApp.Worksheets.get_Item(1 + i);

                    excSheet.Name = floorArray.Rows[i].ItemArray[1].ToString() + " этаж";
                    excSheet.Tab.Color = 204;

                    DataTable roomArray;

                    if (Properties.Settings.Default.room != null || Properties.Settings.Default.room != "")
                    {
                        string room_setting = Properties.Settings.Default.room;
                        String[] rooms = room_setting.Split(',');
                        string not_in_room = null;
                        foreach (var room in rooms)
                        {
                            if (not_in_room == null)
                                not_in_room = @"'" + room + @"'";
                            else
                                not_in_room = not_in_room + @",'" + room + @"'";
                        }

                        roomArray = dalGet.GetRoomTabel(floorArray.Rows[i].ItemArray[1].ToString(), not_in_room);
                    }

                    else
                        roomArray = dalGet.GetRoomTabel(floorArray.Rows[i].ItemArray[1].ToString());

                    int frameRoomColl = coll;
                    int framRoomRow = row;
                    excSheet.Activate();

                    Excel.Range excSheetRange = excSheet.get_Range("A1", "M1");
                    excSheetRange = excSheet.get_Range("A" + row, "M" + row);
                    excSheetRange.WrapText = true;
                    excSheetRange.Font.Italic = true;
                    excSheetRange.Font.Size = 14;
                    excSheetRange.Interior.ColorIndex = 40;
                    excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                    excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                    Excel.Borders border = excSheetRange.Borders;


                    border.LineStyle = Excel.XlLineStyle.xlContinuous;
                    excSheet.Cells[row, 2] = "дата записи в  БД";
                    excSheet.Cells[row, 3] = "Тип учёта";
                    excSheet.Cells[row, 4] = "Инвентарный номер";
                    excSheet.Cells[row, 5] = "Имя ПК / Сетевое имя";
                    excSheet.Cells[row, 6] = "Ответственный";
                    excSheet.Cells[row, 7] = "Этаж";
                    excSheet.Cells[row, 8] = "Комната";
                    excSheet.Cells[row, 9] = "Тип устройства";
                    excSheet.Cells[row, 10] = "Серийный номер";
                    excSheet.Cells[row, 11] = "Модель";
                    excSheet.Cells[row, 12] = "Jira";
                    excSheet.Cells[row, 13] = "Примечание";
                    row++;



                    for (int t = 0; t < roomArray.Rows.Count; t++)
                    {
                        excSheetRange = excSheet.get_Range("A" + row, "M" + row);
                        excSheetRange.Font.Size = 5;
                        excSheetRange.RowHeight = height;
                        excSheetRange.Rows.ColumnWidth =
                        excSheetRange.Interior.ColorIndex = 1;
                        //excApp.ActiveWindow.FreezePanes = false;
                        row++;

                        excSheetRange.Columns[1].ColumnWidth = 5;
                        excSheetRange.Columns[2].ColumnWidth = 15;
                        excSheetRange.Columns[3].ColumnWidth = 9;
                        excSheetRange.Columns[4].ColumnWidth = 15;
                        excSheetRange.Columns[5].ColumnWidth = 16;
                        excSheetRange.Columns[6].ColumnWidth = 20;
                        excSheetRange.Columns[7].ColumnWidth = 9;
                        excSheetRange.Columns[8].ColumnWidth = 16;
                        excSheetRange.Columns[9].ColumnWidth = 20;
                        excSheetRange.Columns[10].ColumnWidth = 25;
                        excSheetRange.Columns[11].ColumnWidth = 38;
                        excSheetRange.Columns[12].ColumnWidth = 19;
                        excSheetRange.Columns[13].ColumnWidth = 36;
                        excSheetRange.Columns[14].ColumnWidth = 5;

                        excSheetRange = excSheet.get_Range("A" + row, "M" + row);
                        excSheetRange.Merge(Type.Missing);
                        excSheetRange.WrapText = true;
                        excSheetRange.Font.Bold = true;
                        excSheetRange.Font.Size = 18;
                        excSheetRange.Interior.ColorIndex = 37;
                        excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                        excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                        excSheetRange.Value2 = "Комната: " + roomArray.Rows[t].ItemArray[0].ToString() +
                            ", этаж: " + floorArray.Rows[i].ItemArray[1].ToString();
                        row++;



                        DataTable LanNameArray = dalGet.GetLanNameTabel(roomArray.Rows[t].ItemArray[0].ToString(), floorArray.Rows[i].ItemArray[0].ToString());

                        for (int w = 0; w < LanNameArray.Rows.Count; w++)
                        {
                            excSheetRange = excSheet.get_Range("B" + row, "M" + row);
                            excSheetRange.Merge(Type.Missing);
                            excSheetRange.Interior.ColorIndex = 1;
                            excSheetRange.Font.Size = 2;
                            excSheetRange.RowHeight = height;
                            row++;

                            excSheetRange = excSheet.get_Range("B" + row, "M" + row);
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
                                roomArray.Rows[t].ItemArray[0].ToString(), floorArray.Rows[i].ItemArray[1].ToString());

                            for (int x = 0; x < MainArray.Rows.Count; x++)
                            {

                                // excSheetRange.Font.Size = 12;
                                //border = excSheetRange.Borders;
                                //border.LineStyle = Excel.XlLineStyle.xlContinuous;

                                excSheetRange = excSheet.get_Range("C" + row, "M" + row);
                                excSheetRange.NumberFormat = "@";
                                excSheetRange = excSheet.get_Range("B" + row);
                                excSheetRange.NumberFormat = "[$-x-sysdate]dddd, mmmm dd, yyyy";

                                if (MainArray.Rows[x].ItemArray[8].ToString() == "системный блок" || MainArray.Rows[x].ItemArray[8].ToString() == "СЕРВЕР" || MainArray.Rows[x].ItemArray[8].ToString() == "Мини ПК")
                                {
                                    DataTable DataHW = dalGet.GetHardwareTabel(MainArray.Rows[x].ItemArray[0].ToString());

                                    for (int z = 1; z < MainArray.Columns.Count; z++)
                                    {
                                        data = MainArray.Rows[x].ItemArray[z].ToString();

                                        if (z == 1)
                                        {
                                            String[] date = data.Split(' ');
                                            excSheet.Cells[row, z + 1] = date[0];
                                        }
                                        else
                                            excSheet.Cells[row, z + 1] = data;
                                    }


                                    excSheetRange = excSheet.get_Range("B" + row, "M" + row);
                                    excSheetRange.Font.Size = 12;
                                    border = excSheetRange.Borders;
                                    border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                    row++;

                                    if (DataHW.Rows.Count != 0)
                                    {
                                        excSheetRange = excSheet.get_Range("I" + row, "M" + row);
                                        excSheetRange.NumberFormat = "@";
                                        excSheetRange.Font.Italic = true;
                                        excSheetRange.Font.Size = 10;
                                        border = excSheetRange.Borders;
                                        excSheetRange.Interior.ColorIndex = 40;
                                        border.LineStyle = Excel.XlLineStyle.xlContinuous;

                                        excSheet.Cells[row, 9] = "Инвентарный номер";
                                        excSheet.Cells[row, 10] = "Тип устройства";
                                        excSheet.Cells[row, 11] = "Модель";
                                        excSheet.Cells[row, 12] = "Серийный номер";
                                        excSheet.Cells[row, 13] = "Примечание";
                                        row++;

                                        for (int HW_x = 0; HW_x < DataHW.Rows.Count; HW_x++)
                                        {
                                            excSheetRange = excSheet.get_Range("I" + row, "M" + row);
                                            excSheetRange.NumberFormat = "@";

                                            excSheet.Cells[row, 9] = DataHW.Rows[HW_x].ItemArray[0].ToString();
                                            excSheet.Cells[row, 10] = DataHW.Rows[HW_x].ItemArray[1].ToString();
                                            excSheet.Cells[row, 11] = DataHW.Rows[HW_x].ItemArray[2].ToString();
                                            excSheet.Cells[row, 12] = DataHW.Rows[HW_x].ItemArray[3].ToString();
                                            excSheet.Cells[row, 13] = DataHW.Rows[HW_x].ItemArray[4].ToString();


                                            excSheetRange = excSheet.get_Range("I" + row, "M" + row);
                                            excSheetRange.NumberFormat = "@";
                                            excSheetRange.Font.Italic = true;
                                            excSheetRange.Font.Size = 9;
                                            border = excSheetRange.Borders;
                                            excSheetRange.Interior.ColorIndex = 15;
                                            border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                            row++;
                                        }
                                    }
                                }
                                else
                                {
                                    excSheetRange = excSheet.get_Range("C" + row, "M" + row);
                                    excSheetRange.NumberFormat = "@";
                                    for (int z = 1; z < MainArray.Columns.Count; z++)
                                    {
                                        data = MainArray.Rows[x].ItemArray[z].ToString();
                                        if (z == 1)
                                        {
                                            String[] date = data.Split(' ');
                                            excSheet.Cells[row, z + 1] = date[0];
                                        }
                                        else
                                            excSheet.Cells[row, z + 1] = data;
                                    }

                                    excSheetRange = excSheet.get_Range("B" + row, "M" + row);
                                    excSheetRange.Font.Size = 12;
                                    border = excSheetRange.Borders;
                                    border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                    row++;
                                    //excSheetRange.Columns.AutoFit();
                                    excSheetRange.Rows.AutoFit();

                                }
                            }

                            excSheetRange = excSheet.get_Range("B" + (framRoomRow + 2), "M" + (row - 1));


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

                        excSheetRange = excSheet.get_Range("A" + framRoomRow, "M" + (row - 1));
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

                        releaseObject(excSheetRange);

                        excApp.ActiveWindow.SplitColumn = 0;
                        excApp.ActiveWindow.SplitRow = 1;
                        excApp.ActiveWindow.FreezePanes = true;
                    }

                    Workbook++;
                    releaseObject(excSheet);
                }

                if (Properties.Settings.Default.room != null || Properties.Settings.Default.room != "")
                {

                    string room_setting = Properties.Settings.Default.room;
                    String[] rooms = room_setting.Split(',');
                    foreach (var room in rooms)
                    {

                        //Workbook++;
                        int coll = 1;
                        int row = 1;
                        // excSheet = (Excel.Worksheet)excApp.Worksheets.Add();
                        excSheet = (Excel.Worksheet)excApp.Worksheets.get_Item(1 + Workbook);
                        excSheet.Name = room;
                        excSheet.Tab.Color = 8;

                        int frameRoomColl = coll;
                        int framRoomRow = row;
                        excSheet.Activate();

                        Excel.Range excSheetRange = excSheet.get_Range("A1", "M1");

                        excSheetRange = excSheet.get_Range("A" + row, "M" + row);
                        excSheetRange.WrapText = true;
                        excSheetRange.Font.Italic = true;
                        excSheetRange.Font.Size = 11;
                        excSheetRange.Interior.ColorIndex = 40;
                        excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                        excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                        Excel.Borders border = excSheetRange.Borders;
                        border.LineStyle = Excel.XlLineStyle.xlContinuous;

                        excSheet.Cells[row, 2] = "дата записи в  БД";
                        excSheet.Cells[row, 3] = "Тип учёта";
                        excSheet.Cells[row, 4] = "Инвентарный номер";
                        excSheet.Cells[row, 5] = "Имя ПК / Сетевое имя";
                        excSheet.Cells[row, 6] = "Ответственный";
                        excSheet.Cells[row, 7] = "Этаж";
                        excSheet.Cells[row, 8] = "Комната";
                        excSheet.Cells[row, 9] = "Тип устройства";
                        excSheet.Cells[row, 10] = "Серийный номер";
                        excSheet.Cells[row, 11] = "Модель";
                        excSheet.Cells[row, 12] = "Jira";
                        excSheet.Cells[row, 13] = "Примечание";

                        excSheetRange.Columns[1].ColumnWidth = 5;
                        excSheetRange.Columns[2].ColumnWidth = 15;
                        excSheetRange.Columns[3].ColumnWidth = 9;
                        excSheetRange.Columns[4].ColumnWidth = 15;
                        excSheetRange.Columns[5].ColumnWidth = 16;
                        excSheetRange.Columns[6].ColumnWidth = 20;
                        excSheetRange.Columns[7].ColumnWidth = 9;
                        excSheetRange.Columns[8].ColumnWidth = 16;
                        excSheetRange.Columns[9].ColumnWidth = 20;
                        excSheetRange.Columns[10].ColumnWidth = 25;
                        excSheetRange.Columns[11].ColumnWidth = 38;
                        excSheetRange.Columns[12].ColumnWidth = 19;
                        excSheetRange.Columns[13].ColumnWidth = 35;
                        excSheetRange.Columns[14].ColumnWidth = 5;
                        row++;

                        DataTable MainArray = dalGet.GetMainTabel(room);

                        for (int x = 0; x < MainArray.Rows.Count; x++)
                        {

                            // excSheetRange.Font.Size = 12;
                            //border = excSheetRange.Borders;
                            //border.LineStyle = Excel.XlLineStyle.xlContinuous;

                            excSheetRange = excSheet.get_Range("B" + row, "M" + row);
                            excSheetRange.NumberFormat = "@";
                            //excApp.ActiveWindow.FreezePanes = false;
                            if (MainArray.Rows[x].ItemArray[8].ToString() == "системный блок" || MainArray.Rows[x].ItemArray[8].ToString() == "СЕРВЕР" || MainArray.Rows[x].ItemArray[8].ToString() == "Мини ПК")
                            {
                                DataTable DataHW = dalGet.GetHardwareTabel(MainArray.Rows[x].ItemArray[0].ToString());

                                for (int z = 1; z < MainArray.Columns.Count; z++)
                                {
                                    data = MainArray.Rows[x].ItemArray[z].ToString();

                                    if (z == 1)
                                    {
                                        String[] date = data.Split(' ');
                                        excSheet.Cells[row, z + 1] = date[0];
                                    }
                                    else
                                        excSheet.Cells[row, z + 1] = data;
                                }


                                excSheetRange = excSheet.get_Range("B" + row, "M" + row);
                                excSheetRange.Font.Size = 12;
                                border = excSheetRange.Borders;
                                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                row++;

                                if (DataHW.Rows.Count != 0)
                                {
                                    excSheetRange = excSheet.get_Range("I" + row, "M" + row);
                                    excSheetRange.NumberFormat = "@";
                                    excSheetRange.Font.Italic = true;
                                    excSheetRange.Font.Size = 10;
                                    border = excSheetRange.Borders;
                                    excSheetRange.Interior.ColorIndex = 40;
                                    border.LineStyle = Excel.XlLineStyle.xlContinuous;

                                    excSheet.Cells[row, 9] = "Инвентарный номер";
                                    excSheet.Cells[row, 10] = "Тип устройства";
                                    excSheet.Cells[row, 11] = "Модель";
                                    excSheet.Cells[row, 12] = "Серийный номер";
                                    excSheet.Cells[row, 13] = "Примечание";
                                    row++;

                                    for (int HW_x = 0; HW_x < DataHW.Rows.Count; HW_x++)
                                    {
                                        excSheetRange = excSheet.get_Range("I" + row, "M" + row);
                                        excSheetRange.NumberFormat = "@";

                                        excSheet.Cells[row, 9] = DataHW.Rows[HW_x].ItemArray[0].ToString();
                                        excSheet.Cells[row, 10] = DataHW.Rows[HW_x].ItemArray[1].ToString();
                                        excSheet.Cells[row, 11] = DataHW.Rows[HW_x].ItemArray[2].ToString();
                                        excSheet.Cells[row, 12] = DataHW.Rows[HW_x].ItemArray[3].ToString();
                                        excSheet.Cells[row, 13] = DataHW.Rows[HW_x].ItemArray[4].ToString();


                                        excSheetRange = excSheet.get_Range("I" + row, "M" + row);
                                        excSheetRange.NumberFormat = "@";
                                        excSheetRange.Font.Italic = true;
                                        excSheetRange.Font.Size = 9;
                                        border = excSheetRange.Borders;
                                        excSheetRange.Interior.ColorIndex = 15;
                                        border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                        row++;
                                    }
                                }
                            }
                            else
                            {
                                excSheetRange = excSheet.get_Range("C" + row, "M" + row);
                                excSheetRange.NumberFormat = "@";
                                for (int z = 1; z < MainArray.Columns.Count; z++)
                                {
                                    data = MainArray.Rows[x].ItemArray[z].ToString();
                                    if (z == 1)
                                    {
                                        String[] date = data.Split(' ');
                                        excSheet.Cells[row, z + 1] = date[0];
                                    }
                                    else
                                        excSheet.Cells[row, z + 1] = data;
                                }

                                excSheetRange = excSheet.get_Range("B" + row, "M" + row);
                                excSheetRange.Font.Size = 12;
                                border = excSheetRange.Borders;
                                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                                row++;
                                //excSheetRange.Columns.AutoFit();
                                excSheetRange.Rows.AutoFit();

                            }
                        }

                        excSheetRange = excSheet.get_Range("B" + (framRoomRow + 2), "M" + (row - 1));


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

                        //excSheetRange = excSheet.get_Range("A1", "M1").Select();
                        //excApp.ActiveWindow.FreezePanes = true;
                        //excSheet.Rows[1].Select();
                        //excApp.ActiveWindow.FreezePanes = true;

                        Workbook++;
                        excApp.ActiveWindow.SplitColumn = 0;
                        excApp.ActiveWindow.SplitRow = 1;
                        excApp.ActiveWindow.FreezePanes = true;
                    }

                    //Workbook++;
                }

                {
                    //Workbook++;
                    int coll = 1;
                    int row = 1;
                    // excSheet = (Excel.Worksheet)excApp.Worksheets.Add();
                    excSheet = (Excel.Worksheet)excApp.Worksheets.get_Item(1 + Workbook);
                    excSheet.Name = "Списаное";
                    excSheet.Tab.Color = 49407;

                    int frameRoomColl = coll;
                    int framRoomRow = row;
                    excSheet.Activate();

                    Excel.Range excSheetRange = excSheet.get_Range("A1", "N1");

                    excSheetRange = excSheet.get_Range("A" + row, "N" + row);
                    excSheetRange.WrapText = true;
                    excSheetRange.Font.Italic = true;
                    excSheetRange.Font.Size = 11;
                    excSheetRange.Interior.ColorIndex = 40;
                    excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                    excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                    Excel.Borders border = excSheetRange.Borders;
                    border.LineStyle = Excel.XlLineStyle.xlContinuous;

                    excSheet.Cells[row, 2] = "дата записи в  БД";
                    excSheet.Cells[row, 3] = "Тип учёта";
                    excSheet.Cells[row, 4] = "Инвентарный номер";
                    excSheet.Cells[row, 5] = "Имя ПК / Сетевое имя";
                    excSheet.Cells[row, 6] = "Ответственный";
                    excSheet.Cells[row, 7] = "Этаж";
                    excSheet.Cells[row, 8] = "Комната";
                    excSheet.Cells[row, 9] = "Тип устройства";
                    excSheet.Cells[row, 10] = "Серийный номер";
                    excSheet.Cells[row, 11] = "Модель";
                    excSheet.Cells[row, 12] = "Jira";
                    excSheet.Cells[row, 13] = "Причина списание";
                    excSheet.Cells[row, 14] = "Примечание";
                    excSheetRange.Columns[1].ColumnWidth = 5;
                    excSheetRange.Columns[2].ColumnWidth = 15;
                    excSheetRange.Columns[3].ColumnWidth = 9;
                    excSheetRange.Columns[4].ColumnWidth = 15;
                    excSheetRange.Columns[5].ColumnWidth = 16;
                    excSheetRange.Columns[6].ColumnWidth = 20;
                    excSheetRange.Columns[7].ColumnWidth = 9;
                    excSheetRange.Columns[8].ColumnWidth = 16;
                    excSheetRange.Columns[9].ColumnWidth = 20;
                    excSheetRange.Columns[10].ColumnWidth = 25;
                    excSheetRange.Columns[11].ColumnWidth = 30;
                    excSheetRange.Columns[12].ColumnWidth = 11;
                    excSheetRange.Columns[13].ColumnWidth = 30;
                    excSheetRange.Columns[14].ColumnWidth = 30;
                    excSheetRange.Columns[15].ColumnWidth = 5;
                    row++;

                    DataTable MainArray = dalGet.Get_WrittenOff_DataTable();

                    for (int x = 0; x < MainArray.Rows.Count; x++)
                    {

                        // excSheetRange.Font.Size = 12;
                        //border = excSheetRange.Borders;
                        //border.LineStyle = Excel.XlLineStyle.xlContinuous;

                        excSheetRange = excSheet.get_Range("C" + row, "N" + row);
                        excSheetRange.NumberFormat = "@";
                        excSheetRange = excSheet.get_Range("B" + row);
                        excSheetRange.NumberFormat = "[$-x-sysdate]dddd, mmmm dd, yyyy";

                        for (int z = 1; z < MainArray.Columns.Count; z++)
                        {
                            data = MainArray.Rows[x].ItemArray[z].ToString();
                            if (z == 1)
                            {
                                String[] date = data.Split(' ');
                                excSheet.Cells[row, z + 1] = date[0];
                            }
                            else
                                excSheet.Cells[row, z + 1] = data;
                        }
                        excSheetRange = excSheet.get_Range("B" + row, "N" + row);
                        excSheetRange.Font.Size = 12;
                        excSheetRange.Interior.ColorIndex = 0;
                        border = excSheetRange.Borders;
                        border.LineStyle = Excel.XlLineStyle.xlContinuous;
                        row++;
                        //excSheetRange.Columns.AutoFit();
                        excSheetRange.Rows.AutoFit();
                    }
                    excApp.ActiveWindow.SplitColumn = 0;
                    excApp.ActiveWindow.SplitRow = 1;
                    excApp.ActiveWindow.FreezePanes = true;
                    Workbook++;
                }


                {
                    //Workbook++;
                    int coll = 1;
                    int row = 1;
                    // excSheet = (Excel.Worksheet)excApp.Worksheets.Add();
                    excSheet = (Excel.Worksheet)excApp.Worksheets.get_Item(1 + Workbook);
                    excSheet.Name = "Железо и расходники на складе";
                    excSheet.Tab.Color = 12611584;

                    int frameRoomColl = coll;
                    int framRoomRow = row;
                    excSheet.Activate();

                    Excel.Range excSheetRange = excSheet.get_Range("A1", "K1");

                    excSheetRange = excSheet.get_Range("A" + row, "K" + row);
                    excSheetRange.WrapText = true;
                    excSheetRange.Font.Italic = true;
                    excSheetRange.Font.Size = 11;
                    excSheetRange.Interior.ColorIndex = 40;
                    excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                    excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                    Excel.Borders border = excSheetRange.Borders;
                    border.LineStyle = Excel.XlLineStyle.xlContinuous;

                    excSheet.Cells[row, 2] = "дата записи в  БД";
                    excSheet.Cells[row, 3] = "Инвентарный номер";
                    excSheet.Cells[row, 4] = "Количество";
                    excSheet.Cells[row, 5] = "Тип устройства";
                    excSheet.Cells[row, 6] = "Серийный номер";
                    excSheet.Cells[row, 7] = "Модель";
                    excSheet.Cells[row, 8] = "Списано";
                    excSheet.Cells[row, 9] = "Jira";
                    excSheet.Cells[row, 10] = "Причина списание";
                    excSheet.Cells[row, 11] = "Примечание";
                    excSheetRange.Columns[1].ColumnWidth = 5;
                    excSheetRange.Columns[2].ColumnWidth = 25;
                    excSheetRange.Columns[3].ColumnWidth = 25;
                    excSheetRange.Columns[4].ColumnWidth = 18;
                    excSheetRange.Columns[5].ColumnWidth = 25;
                    excSheetRange.Columns[6].ColumnWidth = 25;
                    excSheetRange.Columns[7].ColumnWidth = 25;
                    excSheetRange.Columns[8].ColumnWidth = 25;
                    excSheetRange.Columns[9].ColumnWidth = 25;
                    excSheetRange.Columns[10].ColumnWidth = 25;
                    excSheetRange.Columns[11].ColumnWidth = 25;
                    row++;

                    DataTable MainArray = dalGet.Get_HW_StockRoom();

                    for (int x = 0; x < MainArray.Rows.Count; x++)
                    {

                        // excSheetRange.Font.Size = 12;
                        //border = excSheetRange.Borders;
                        //border.LineStyle = Excel.XlLineStyle.xlContinuous;

                        excSheetRange = excSheet.get_Range("B" + row, "K" + row);
                        excSheetRange.NumberFormat = "@";
                        excSheetRange = excSheet.get_Range("B" + row);
                        excSheetRange.NumberFormat = "[$-x-sysdate]dddd, mmmm dd, yyyy";

                        for (int z = 1; z < MainArray.Columns.Count; z++)
                        {
                            data = MainArray.Rows[x].ItemArray[z].ToString();
                            if (z == 1)
                            {
                                String[] date = data.Split(' ');
                                excSheet.Cells[row, z + 1] = date[0];
                            }
                            else
                                excSheet.Cells[row, z + 1] = data;

                        }

                        excSheetRange = excSheet.get_Range("B" + row, "K" + row);
                        excSheetRange.Font.Size = 12;
                        border = excSheetRange.Borders;
                        border.LineStyle = Excel.XlLineStyle.xlContinuous;
                        row++;
                        //excSheetRange.Columns.AutoFit();
                        excSheetRange.Rows.AutoFit();
                    }
                    excApp.ActiveWindow.SplitColumn = 0;
                    excApp.ActiveWindow.SplitRow = 1;
                    excApp.ActiveWindow.FreezePanes = true;
                    Workbook++;
                }

                {
                    //Workbook++;
                    int coll = 1;
                    int row = 1;
                    // excSheet = (Excel.Worksheet)excApp.Worksheets.Add();
                    excSheet = (Excel.Worksheet)excApp.Worksheets.get_Item(1 + Workbook);
                    excSheet.Name = "Журнал БД";
                    excSheet.Tab.Color = 5296274;

                    int frameRoomColl = coll;
                    int framRoomRow = row;
                    excSheet.Activate();

                    Excel.Range excSheetRange = excSheet.get_Range("A1", "J1");

                    excSheetRange = excSheet.get_Range("A" + row, "J" + row);
                    excSheetRange.WrapText = true;
                    excSheetRange.Font.Italic = true;
                    excSheetRange.Font.Size = 11;
                    excSheetRange.Interior.ColorIndex = 40;
                    excSheetRange.HorizontalAlignment = Excel.Constants.xlCenter;
                    excSheetRange.VerticalAlignment = Excel.Constants.xlCenter;
                    Excel.Borders border = excSheetRange.Borders;
                    border.LineStyle = Excel.XlLineStyle.xlContinuous;

                    excSheet.Cells[row, 2] = "дата записи в  БД";
                    excSheet.Cells[row, 3] = "Имя пользователя";
                    excSheet.Cells[row, 4] = "Вид дейтельности";
                    excSheet.Cells[row, 5] = "Причина";
                    excSheet.Cells[row, 6] = "Тип устройства";
                    excSheet.Cells[row, 7] = "Серийный номер";
                    excSheet.Cells[row, 8] = "Модель";
                    excSheet.Cells[row, 9] = "Инвентарный номер";
                    excSheet.Cells[row, 10] = "ID в базе ";

                    excSheetRange.Columns[1].ColumnWidth = 5;
                    excSheetRange.Columns[2].ColumnWidth = 17;
                    excSheetRange.Columns[3].ColumnWidth = 16;
                    excSheetRange.Columns[4].ColumnWidth = 40;
                    excSheetRange.Columns[5].ColumnWidth = 50;
                    excSheetRange.Columns[6].ColumnWidth = 24;
                    excSheetRange.Columns[7].ColumnWidth = 25;
                    excSheetRange.Columns[8].ColumnWidth = 37;
                    excSheetRange.Columns[9].ColumnWidth = 20;
                    excSheetRange.Columns[10].ColumnWidth = 7;

                    row++;

                    DataTable MainArray = dalGet.Get_JDB_DataTable();

                    for (int x = 0; x < MainArray.Rows.Count; x++)
                    {

                        // excSheetRange.Font.Size = 12;
                        //border = excSheetRange.Borders;
                        //border.LineStyle = Excel.XlLineStyle.xlContinuous;

                        excSheetRange = excSheet.get_Range("C" + row, "J" + row);
                        excSheetRange.NumberFormat = "@";
                        excSheetRange = excSheet.get_Range("B" + row);
                        excSheetRange.NumberFormat = "[$-x-sysdate]dddd, mmmm dd, yyyy";

                        for (int z = 0; z < MainArray.Columns.Count; z++)
                        {
                            data = MainArray.Rows[x].ItemArray[z].ToString();
                            if (z == 0)
                            {
                                String[] date = data.Split(' ');
                                excSheet.Cells[row, z + 2] = date[0];
                            }
                            else
                                excSheet.Cells[row, z + 2] = data;
                        }

                        excSheetRange = excSheet.get_Range("B" + row, "J" + row);
                        excSheetRange.Font.Size = 12;
                        border = excSheetRange.Borders;
                        border.LineStyle = Excel.XlLineStyle.xlContinuous;
                        row++;
                        //excSheetRange.Columns.AutoFit();
                        excSheetRange.Rows.AutoFit();
                    }
                    excApp.ActiveWindow.SplitColumn = 0;
                    excApp.ActiveWindow.SplitRow = 1;
                    excApp.ActiveWindow.FreezePanes = true;
                    Workbook++;
                }



                // excApp.Visible = true;
                excApp.Interactive = true;
                excApp.ScreenUpdating = true;
                excApp.UserControl = true;
                String Data = System.DateTime.Now.ToString("yyyy-MM-dd");
                if (File.Exists(filename))
                    File.Delete(filename);

                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xlWorkBook.Close(true, Type.Missing, Type.Missing);
                excApp.Quit();
                
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
