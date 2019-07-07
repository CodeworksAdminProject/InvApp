using System;
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
        public static ArrayList ArrayChancge= new ArrayList();
        public static ArrayList MailBody = new ArrayList();
        public static string sMailBody;
        public static string heds;
        public static string sMailBodyNew ;
        public static string sMailBodyDelete;
        public static string sHtmlTableAddWriteOffForReport = null;
        public static string sHtmlTableAddWriteOffForReportHW = null;
        public static string sHtmlTableTakeAwayWriteOffForReport = null;
        public static string sHtmlTableDeleteReport = null;
        public static string sHtmlTableHardware_PS = null;
        public static string sHtmlTableHardware_Stockroom = null;
        public static string sHtmlTable_Change_data = null;
        public static string sHtmlTable_Move_Hardware = null;
        public static string SerNum =null;


        public static string ReasonWriteOff = null;
        public static bool flag = false;
       

        static int n = 1;
        static int t = 1;
        static int Number = 1;

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
         
        public void Add_Data_ArrayChancge(string ID, string date, string typeAC, string Invnum, string typeDev, string SN, string Model, string jira, string NameLan, string NameRes, string Floor, string Room)
        {
            string[] str = new string[] { ID, date, typeAC, Invnum, typeDev, SN, Model, jira, NameLan, NameRes, Floor, Room };
            ArrayChancge.Add(str);
        }

        public void Add_Data_ArrayChancge(string ID, string date, string Invnum, string typeDev, string SN, string Model, string jira, string NameLan, string NameRes, string Floor, string Room)
        {
            string[] str = new string[] { ID, date, Invnum, typeDev, SN, Model, jira, NameLan, NameRes, Floor, Room };
            ArrayChancge.Add(str);
        }

        public void Add_Data_ArrayChancge(string ID, string date, string Invnum, string typeDev, string SN, string Model, string jira, string quantity)
        {
            string[] str = new string[] { ID, date, Invnum, typeDev, SN, Model, jira, quantity };
            ArrayChancge.Add(str);
        }

        public void Compere(string ID, string INV, string NameLan, string NameRes, string Floor, string Room, string NameDevice,string Model, string SN)
        {
            string old = @"<span class='old'>";
            string New = @"<span  class='new'>";


            if (BLL.heds == null)
                BLL.heds = " <h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + "</font> были внесены  следующие  изменения: </p></h1>";

            foreach (string[] str in DataOld)
            {
                if (str[0] == ID)
                {
                    if ((str[1] != NameLan) || (str[2] != NameRes) || (str[3] != Floor) || (str[4] != Room))
                    {
                        if (BLL.sMailBody == null)
                        {
                            BLL.sMailBody = "<h2>Добавлены правки во следующие  позиции:</h2>";
                            BLL.sMailBody = BLL.sMailBody + "<table>" +
                                                "<tr>" +
                                                "<th>Инвентарный номер</th>" +
                                                 "<th>Название в сети</th>" +
                                                 "<th>Ответственный</th>" +
                                                 "<th>Этаж</th>" +
                                                 "<th>Помещение</th>" +
                                                 "<th>Тип устройства</th>" +
                                                 "<th>Модель</th>" +
                                                 "<th>Серийный номер</th>" +
                                                 "</tr>";

                           
                        }

                        BLL.sMailBody = BLL.sMailBody + "<tr><td><nobr>" + INV + "</nobr></td>";

                        if (str[1] != NameLan)
                        {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + old + str[1] + @"</span></nobr></br><nobr>" +
                                 New + NameLan + "</span></nobr></td>";
                        }
                        else  { BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + str[1] + @"</nobr></br></td>"; }


                        if (str[2] != NameRes)
                        {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + old + str[2] + @"</span></nobr></br><nobr>" +
                                New + NameRes + "</span></nobr></td>";
                        }
                        else {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + str[2] + @"</nobr></br></td>";
                        }

                        if (str[3] != Floor)
                        {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + old + str[3] + @"</span></nobr></br><nobr>" +
                                 New + Floor + "</span></nobr></td>";
                        }
                        else {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + str[3] + @"</nobr></br></td>";
                        }

                        if (str[4] != Room)
                        {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + old + str[4] + @"</span></nobr></br><nobr>" +
                                 New + Room + "</span></nobr></td>";
                        }
                        else {
                            BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + str[4] + @"</nobr></br></td>";
                        }

                        BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + NameDevice + "</nobr></td>";
                        BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + Model + "</nobr></td>";
                        BLL.sMailBody = BLL.sMailBody + "<td><nobr>" + SN + "</nobr></td></tr>";


                        dalSet.AddFDB(Environment.UserName, 7, "", INV, NameDevice, SN, Model, ID);
                       
                    }
                }
                
            }
            
        }

        internal void change(string ID, string type_AC, string inv, string type_Device, string SN, string Model, string type_Jira)
        {
            string old = @"<span class='old'>";
            string New = @"<span  class='new'>";


            if (BLL.heds == null)
                BLL.heds = " <h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + "</font> были внесены  следующие  изменения: </p></h1>";

            foreach (string[] str in ArrayChancge)
            {
                if (str[0] == ID)
                {
                    if ((str[2] != type_AC) || (str[3] != inv) || (str[4] != type_Device) || (str[5] != SN) || (str[6] != Model) || (str[7] != type_Jira))
                    {
                        if (BLL.sHtmlTable_Change_data == null)
                        {
                            BLL.sHtmlTable_Change_data = "<h2>Исправление уникальных значений :</h2>";
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<table>" +
                                                "<tr>" +
                                                "<th>ID в базе</th>" +
                                                "<th>Тип учёта</th>" +
                                                "<th>Инвентарный номер</th>" +
                                                "<th>Название в сети</th>" +
                                                "<th>Ответственный</th>" +
                                                "<th>Этаж</th>" +
                                                "<th>Помещение</th>" +
                                                "<th>Тип устройства</th>" +
                                                "<th>Модель</th>" +
                                                "<th>Серийный номер</th>" +
                                                "<th>JIRA</th>" +
                                                "</tr>";


                        }

                        BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<tr><td><nobr>" + str[0] + "</nobr></td>";

                        if (str[2] != type_AC)
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + old + str[2] + @"</span></nobr></br><nobr>" +
                                 New + type_AC + "</span></nobr></td>";
                        }
                        else { BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[2] + @"</nobr></br></td>"; }                                             

                        if (str[3] != inv)
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + old + str[3] + @"</span></nobr></br><nobr>" +
                                New + inv + "</span></nobr></td>";
                        }
                        else
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[3] + @"</nobr></br></td>";
                        }
                        
                        BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[8] + @"</nobr></br></td>";
                        BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[9] + @"</nobr></br></td>";
                        BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[10] + @"</nobr></br></td>";
                        BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[11] + @"</nobr></br></td>";

                        if (str[4] != type_Device)
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + old + str[4] + @"</span></nobr></br><nobr>" +
                                 New + type_Device + "</span></nobr></td>";
                        }
                        else
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[4] + @"</nobr></br></td>";
                        }

                        if (str[6] != Model)
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + old + str[6] + @"</span></nobr></br><nobr>" +
                                 New + Model + "</span></nobr></td>";
                        }
                        else
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[6] + @"</nobr></br></td>";
                        }

                        if (str[5] != SN)
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + old + str[5] + @"</span></nobr></br><nobr>" +
                                 New + SN + "</span></nobr></td>";
                        }
                        else
                        {
                            BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + str[5] + @"</nobr></br></td>";
                        }

                        if (str[7] != type_Jira)
                        {
                            if (type_Jira != ""  || str[7] != "")
                            {

                                BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr>" + old + "<a href='http://jira.mara.local/browse/" + str[7] +
                                   "'>" + str[7] + "</ a ></span></nobr></br><nobr>" + New + "<a href='http://jira.mara.local/browse/" +
                                      type_Jira + "'>" + type_Jira + "</ a ></span></nobr></td>";
                            }

                            else                         
                               BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td></td></tr>";
                            
                        }
                        else
                        {
                            if (type_Jira != "" || str[7] != "")
                            {
                                BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td><nobr><a href='http://jira.mara.local/browse/" + str[7] +"'>"
                                   +str[7] + "</a></nobr></br></td></tr>";
                            }
                            else
                                BLL.sHtmlTable_Change_data = BLL.sHtmlTable_Change_data + "<td></td></tr>";
                        }

                        dalSet.AddFDB(Environment.UserName, 6, "",inv , type_Device, SN, Model, ID);
                    }
                }

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

        public void BodyMailNew(string Inv, string NameLan, string NameRes, string Floor, string Room, string NameDevice, string SN, string Model, string jira)
        {

            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + " </font> были внесены  следующие  изменения: </p></h1>";

            if (sMailBodyNew == null)
            {
                sMailBodyNew = "<h2>Добавлены новое (перечисленно в таблице):</h2>";
                sMailBodyNew = sMailBodyNew +"Таблица  нового ";
                sMailBodyNew = sMailBodyNew + "<table>" +
                    "<tr>" +
                    "<th>Номер операции </th>" +
                    "<th>Инвентарный номер</th>" +
                     "<th>Название в сети</th>" +
                     "<th>Ответственный</th>" +
                     "<th>Этаж</th>" +
                     "<th>Помещение</th>" +
                     "<th>Тип устройства</th>" +
                     "<th>Серийный номер</th>" +
                     "<th>Модель</th>" +
                     "<th>Задача  в Jira</th>" +
                     "</tr>";
            }


            sMailBodyNew = sMailBodyNew + 
                       "<tr>" +
                       "<td>" + Number + "</td>" +
                       "<td>" + Inv + "</td>" +
                        "<td>" + NameLan + "</td>" +
                        "<td>" + NameRes + "</td>" +
                        "<td>"+Floor+"</td>" +
                        "<td>" + Room + "</td>" +
                        "<td>"+ NameDevice + "</td>" +
                        "<td>"+SN+"</td>" +
                        "<td>"+ Model+"</td>" +
                        "<td>" + "<a href='http://jira.mara.local/browse/" +jira +"'>"+jira+" </a></td>" +
                        "</tr>";


            Number++;
                
            
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

        internal void new_Hardware_Into_PC(string invNumber, string typedevise, string SN, string Model, string Jira, string PC_name )


        {
            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + " </font> были внесены  следующие  изменения: </p></h1>";

                if (sHtmlTableHardware_PS == null)
                {
                    sHtmlTableHardware_PS = @"
                 <h2> Новое на компьютер(ы) железо или расходники</h2> 
                 <table border='1' > 
                <caption><font size='5'>Добавлено новое на компьютер(ы) железо или расходники :</font></caption>
                <tr> 
                <th>Номер операции </th>
                <th>Инвентарный номер</th>
                <th>Имя компьютера</th>
                <th>Тип устройства</th>
                <th>Серийный номер</th>
                <th>Модель</th>
                <th> Задача  в Jira</th> 
                </tr>";
                }
            

            sHtmlTableHardware_PS = sHtmlTableHardware_PS +
                       "<tr>" +
                       "<td>" + Number + "</td>" +
                       "<td>" + invNumber + "</td>" +
                        "<td>" + PC_name + "</td>" +
                        "<td>" + typedevise + "</td>" +
                        "<td>" + Model + "</td>" +
                        "<td>" + SN + "</td>" +
                        "<td>" + "<a href='http://jira.mara.local/browse/" + Jira + "'>" + Jira + " </a></td>" +
                        "</tr>";
            
        }

        internal void Move_Hardware(string invNumber, string typedevise, string SN, string Model, string Jira, string PC_name, string Old_NameLan, string flag )
        {
            string New = @"<span  class='new'>";
            string PC = null;

            if (flag == "PC_S")
                PC = "Снято с " + Old_NameLan + New + " и отправлено на склад</span>";
            else if (flag == "S_PC")
                PC = "Взято со склада и установлено на " + New + PC_name +"</span>";
            else
                PC = "Снято с "+Old_NameLan +" и установлено на " + New + PC_name + " </span>";



            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + " </font> были внесены  следующие  изменения: </p></h1>";

            if (sHtmlTable_Move_Hardware == null)
            {
                sHtmlTable_Move_Hardware = @"
                 <h2> Пепремещение железа или расходников</h2> 
                 <table border='1' > 
                <caption><font size='5'>Пепремещение железа или расходников :</font></caption>
                <tr> 
                <th>Номер операции </th>
                <th>Инвентарный номер</th>
                <th>Имя компьютера</th>
                <th>Тип устройства</th>
                <th>Серийный номер</th>
                <th>Модель</th>
                <th> Задача  в Jira</th> 
                </tr>";
            }


            sHtmlTable_Move_Hardware = sHtmlTable_Move_Hardware +
                       "<tr>" +
                       "<td>" + Number + "</td>" +
                       "<td>" + invNumber + "</td>" +
                        "<td>" + PC + "</td>" +
                        "<td>" + typedevise + "</td>" +
                        "<td>" + Model + "</td>" +
                        "<td>" + SN + "</td>" +
                        "<td>" + "<a href='http://jira.mara.local/browse/" + Jira + "'>" + Jira + " </a></td>" +
                        "</tr>";

        }

        internal void new_Hardware_Into_StockRoom(string invNumber, string typedevise, string SN, string Model, string Jira, string Sum)



        {
            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + " </font> были внесены  следующие  изменения: </p></h1>";

            if (sHtmlTableHardware_Stockroom == null)
            {
                sHtmlTableHardware_Stockroom = @"
                <h2> Новое на склад (железо или расходники)</h2 > 
                <table border='1' > 
                <caption><font size='5'>Добавлено новое железо или расходники  на  склад :</font></caption>
                <tr> 
                <th>Номер операции </th>
                <th>Инвентарный номер</th>
                <th>Тип устройства</th>
                <th>Серийный номер</th>
                <th>Модель</th>
                <th>Количество в шт </th>
                <th> Задача  в Jira</th>
                </tr>";
            }


            sHtmlTableHardware_Stockroom = sHtmlTableHardware_Stockroom +
                "<tr>" +
                "<td>" + Number + "</td>" +
                "<td>" + invNumber + "</td>" +
                "<td>" + typedevise + "</td>" +
                "<td>" + Model + "</td>" +
                "<td>" + SN + "</td>" +
                "<td>" + Sum + "</td>" +
                "<td>" + "<a href ='http://jira.mara.local/browse/" + Jira + "'>" + Jira + " </a></td>" +
                "</tr>";

        }

        internal string WrittenOff_And_Delete(string addId, string sHtmlTable, string flag, string tableName)
        {
            string Times = System.DateTime.Now.ToLongTimeString();
            DataTable table;

            string strreturn;
            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + "</font> были внесены  следующие  изменения: </p></h1>";

             table = dalGet.getWrateOffTable(addId, tableName);

            StringBuilder string_HTML_Table = new StringBuilder();

            string TypeActivity;
            string TypeClass;

            if (flag == "Add")
            {
                TypeActivity = "Списание";
                TypeClass = "UPS";
                
            }
            else if (flag == "TakeAway")
            {
                TypeActivity = "Возращено в учет";
                TypeClass = "Monitor";
            }
            else
            {
                TypeActivity = "Удалено из базы";
                TypeClass = "PC";
            }

                if (sHtmlTable == null)
            {

                string_HTML_Table.Append("<table border='1'>");
                string_HTML_Table.Append("<h2> Движение железа и расходников.  </h2><table border='1'><caption><font size='5'>Таблица движение железа и расходников.</font></caption>");
                string_HTML_Table.Append("<tr>");
                string_HTML_Table.Append("<th>Номер операции </th>");
                string_HTML_Table.Append("<th>Дата и время</th>");
                string_HTML_Table.Append("<th>ID в базе</th>");
                string_HTML_Table.Append("<th>Инвин №</th>");
                string_HTML_Table.Append("<th>Этаж</th>");
                string_HTML_Table.Append("<th>Комната</th>");
                string_HTML_Table.Append("<th>Тип устройства</th>");
                string_HTML_Table.Append("<th>Модель</th>");
                string_HTML_Table.Append("<th>SN</th>");
                string_HTML_Table.Append("<th>Количество</th>");
                string_HTML_Table.Append("<th>Вид операции </th>");
                string_HTML_Table.Append("</tr>");                

            }

            if (tableName == "HardWare")
            {
                foreach (DataRow row in table.Rows)
                {
                    string_HTML_Table.Append("<tr class='" + TypeClass + "'>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + Number + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + Times + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[0].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[2].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[5].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[6].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[7].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[8].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[9].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>1 Шт.</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + TypeActivity + "</td>");
                    string_HTML_Table.Append("</tr>");
                    Number++;
                }
            }

            if (tableName == "HardwareStockRoom")
            {
                foreach (DataRow row in table.Rows)
                {
                    string_HTML_Table.Append("<tr class='" + TypeClass + "'>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + Number + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + Times + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[0].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[2].ToString() + " </td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>Cклад </td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>Склад </td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[3].ToString() + " </td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[4].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[5].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + row[6].ToString() + "</td>");
                    string_HTML_Table.Append("<td class='" + TypeClass + "'>" + TypeActivity + "</td>");
                    string_HTML_Table.Append("</tr>");
                    Number++;
                }
            }


            strreturn = string_HTML_Table.ToString();
            return strreturn;

        }

        internal string WrittenOff_And_Delete(string addId, string sHtmlTable, string flag)
        {
            string Times = System.DateTime.Now.ToLongTimeString();
            DataTable table;

            string strreturn;
            if (BLL.heds == null)
                BLL.heds = "<h1><p> В  пользователем:  <font  color = 'red' >" + System.Environment.UserName + "</font> были внесены  следующие  изменения: </p></h1>";

                table = dalGet.getWrateOffTable(addId);
          StringBuilder string_HTML_Table = new StringBuilder();

            if (sHtmlTable == null)
            {

                string_HTML_Table.Append("<table border='1'>");
                if (flag == "Add")
                    string_HTML_Table.Append("<h2> Представленное на списание </h2><table border='1'><caption><font size='5'>Таблица представленное на списание</font></caption>");
                else if (flag == "TakeAway")
                    string_HTML_Table.Append("<h2>Оборудование возвращённое  в основной  учет </h2><table border='1'><caption><font size='5'>Оборудование возвращённое  в основной  учет</font></caption>");
                else if (flag == "Delete")
                    string_HTML_Table.Append("<h2> Удаление из базы </h2><table border='1'><caption><font size='5'>Удаление из базы </font></caption>");
                string_HTML_Table.Append("<tr>");
                string_HTML_Table.Append("<th>Номер операции </th>");
                string_HTML_Table.Append("<th>Дата и время</th>");
                string_HTML_Table.Append("<th>ID в базе</th>");
                string_HTML_Table.Append("<th>Инвин №</th>");
                string_HTML_Table.Append("<th>Этаж</th>");
                string_HTML_Table.Append("<th>Комната</th>");
                string_HTML_Table.Append("<th>Тип устройства</th>");
                string_HTML_Table.Append("<th>Модель</th>");
                string_HTML_Table.Append("<th>SN</th>");
                string_HTML_Table.Append("</tr>");

            }

            foreach (DataRow row in table.Rows)
            {

                string_HTML_Table.Append("<tr>");
                string_HTML_Table.Append("<td>" + Number + "</td>");
                string_HTML_Table.Append("<td>" + Times + "</td>");
                string_HTML_Table.Append("<td>" + row[0].ToString() + "</td>");
                string_HTML_Table.Append("<td>" + row[1].ToString() + "</td>");
                string_HTML_Table.Append("<td>" + row[2].ToString() + "</td>");
                string_HTML_Table.Append("<td>" + row[3].ToString() + "</td>");
                string_HTML_Table.Append("<td>" + row[4].ToString() + "</td>");
                string_HTML_Table.Append("<td>" + row[5].ToString() + "</td>");
                string_HTML_Table.Append("<td>" + row[6].ToString() + "</td>");
                string_HTML_Table.Append("</tr>");
                Number++;
            }

            strreturn = string_HTML_Table.ToString();
            return strreturn;

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
