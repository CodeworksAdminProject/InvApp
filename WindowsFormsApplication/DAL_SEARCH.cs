using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication
{
    internal class DAL_SEARCH
    {
        public string date;
        public string date_now;
        public string Floor;
        public string Room;
        public string namePC;
        public string Res_name;
        public string TypeDevice;
        public string TypeHardware;
        public string InvNum;
        public string Model;
        public string SN;
        public bool @checke;
        public string Jira;
        public string TypeAC;
        public string ID_mnTB;
        public string ID_HW;
        public string ID_SR;



        private string  String_shearch()
        {
            string searchStr;
            searchStr = " dateCreated  between  '" + date + "' and '" + date_now + "' AND ";

            if (Floor != "Для всех" && Floor != null )
                searchStr = searchStr + " [Floor].floorNambe = '" + Floor + @"' AND ";
            else if (Floor == null)
                searchStr = searchStr + " [Floor].floorNambe = '' AND ";

            if (Room != "Для всех" && Room != null)
                searchStr = searchStr + " Room.NameRoom = '" + Room + @"' AND ";
            else if (Room == null)
                searchStr = searchStr + " Room.NameRoom = '' AND ";

            if (namePC != "Для всех" && namePC !=null)
                searchStr = searchStr + " NameLAN.NameLAN = '" + namePC + @"' AND ";
            else if (namePC == null)
                searchStr = searchStr + " NameLAN.NameLAN = '' AND ";

            if (Res_name != "Для всех" && Res_name != null)
                searchStr = searchStr + " NameRes.NameRes = '" + Res_name + @"' AND ";
            else if (Res_name == null)
                searchStr = searchStr + " NameRes.NameRes = '' AND ";

            if (TypeDevice != "Для всех" && TypeDevice !=null)
                searchStr = searchStr + " TypeDevice.NameDevice = '" + TypeDevice + @"' AND ";
            else if (TypeDevice == null)
                searchStr = searchStr + " TypeDevice.NameDevice = '' AND ";

            if (TypeHardware != "Для всех" && TypeHardware != null)
                searchStr = searchStr + " TypeHardWare = '" + TypeHardware + @"' AND ";
            else if (TypeHardware == null)
                searchStr = searchStr + " TypeHardWare = '' AND ";

            if (InvNum != "" && InvNum != null)
                searchStr = searchStr + " NumberINV  like '%" + InvNum + @"%' AND ";

            if (Model != "" && Model != null)
                searchStr = searchStr + "Model  like '%" + Model + @"%' AND ";

            if (SN != "" && SN != null)
                searchStr = searchStr + "  SN  like '%" + SN + @"%' AND ";

            if (Jira != "Для всех" && Jira != null)
                searchStr = searchStr + " COALESCE(JiraTask,'')  = '" + Jira + @"' AND ";
            else if (Jira == null)
                searchStr = searchStr + " COALESCE(JiraTask,'')  = '' AND ";

            if (TypeAC != "Для всех" && TypeAC !=null)
                searchStr = searchStr + "  COALESCE(TypeAC.TypeAC,'')  = '" + TypeAC + @"' AND ";
            else if (TypeAC == null)
                searchStr = searchStr + "  COALESCE(TypeAC.TypeAC,'')  = '' AND ";

            if (ID_mnTB != "" && ID_mnTB != null)
                searchStr = searchStr + "maintb.ID  like '%" + ID_mnTB + @"%' AND ";

            if (ID_HW != "" && ID_HW != null)
                searchStr = searchStr + "Hardware.ID  like '%" + ID_HW + @"%' AND ";

            if (ID_SR != "" && ID_SR != null)
                searchStr = searchStr + "HardwareStockRoom.ID  like '%" + ID_SR + @"%' AND ";

            searchStr = searchStr + "WrittenOff = '"+ @checke + "'";

            return searchStr;
        }



        String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
            Properties.Settings.Default.SqlPort + "; Database=" + Properties.Settings.Default.SqlDataBase + "; Integrated Security=true;";

        private ArrayList searchMainTB()
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {

                SqlCommand command = new SqlCommand(@"select
                maintb.ID, 
                maintb.dateCreated, 
                maintb.NumberINV, 
                TypeAC.TypeAC,
                NameLAN.NameLAN, 
                NameRes.NameRes, 
                [Floor].floorNambe, 
                Room.NameRoom,
                TypeDevice.NameDevice, 
                maintb.SN,
                MainTB.Model,
                JiraTask, 
                WrittenOff,
                ReasonWriteOff,
                Note
                from MainTB
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID 
                join [Floor] on maintb.Floor_ID = [Floor].ID 
                join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID 
                join NameLAN on maintb.NameLAN_ID = NameLAN.ID 
                join NameRes on maintb.NameRes_ID =  NameRes.ID 
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID Where" + String_shearch() + " order by NameRes,NameLAN, TypeDevice_ID;", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            DataGrid.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataGrid;
        }

        private ArrayList searchHardware()
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT [HardWare].ID
            ,dateCreated
            ,NumberINV
            ,NameLAN.NameLAN
            ,NameRes.NameRes
            ,[Floor].floorNambe
            ,Room.NameRoom
            ,TypeHardWare
            ,[Model]
            ,[SN]
            ,JiraTask
            ,[WrittenOff]
            ,ReasonWriteOff
            ,[Note]
            FROM [dbo].[HardWare],NameLAN, TypeHardWare,[Room], NameRes, [Floor], JiraTask
 
            Where NameLAN = (SELECT NameLAN  FROM [dbo].[MainTB] join NameLAN on NameLAN_ID = NameLAN.ID   Where [MainTB].ID = MainTB_ID ) AND
            TypeHardWare_ID = TypeHardWare.ID  AND
            NameRoom = (SELECT NameRoom  FROM [dbo].[MainTB] join [Room] on Room_ID = [Room].ID   Where [MainTB].ID = MainTB_ID ) AND
            NameRes.NameRes = (SELECT NameRes FROM [dbo].[MainTB] join NameRes on NameRes_ID = NameRes.ID   Where [MainTB].ID = MainTB_ID ) AND
            [Floor].floorNambe = (SELECT floorNambe FROM [dbo].[MainTB] join [Floor] on Floor_ID = [Floor].ID   Where [MainTB].ID = MainTB_ID ) AND
            JiraTask_ID = JiraTask.ID AND " + String_shearch() + " order by NameRes, NameLAN, TypeHardWare_ID;", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            DataGrid.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataGrid;
        }       

        private ArrayList searchStockRoom()
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT [HardwareStockRoom].ID
              ,[dateCreated]
              ,[NumberINV]
              ,[TypeHardWare]
              ,[Model]
              ,[SN]
              ,[quantity]
              ,[WrittenOff]
              ,[JiraTask]
              ,[ReasonWriteOff]
              ,[Note]
               FROM [dbo].[HardwareStockRoom], TypeHardWare, JiraTask
               Where TypeHardWare_ID = TypeHardWare.ID AND  JiraTask_ID = JiraTask.ID AND " + String_shearch() + " order BY TypeHardWare_ID;", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            DataGrid.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataGrid;
        }

        internal void search(DataGridView dataGridView, string tableName)
        {
            if (tableName == "HardWare")
            {
                dataGridView.DataSource = searchHardware();
            }

            else if (tableName == "MainTB")
            {
                dataGridView.DataSource = searchMainTB();
            }

            else if (tableName == "HardwareStockRoom")
            {
                dataGridView.DataSource = searchStockRoom();
            }
        }

        public DataTable Get_Data_in_combobox(string table, string column)
        {
            DataTable DataFloor = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select dbo." + table + "." + column + " from dbo." + table + "  order by dbo." + table + "." + column + ";", connect);

                try
                {

                    connect.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataFloor = ds.Tables[0];
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataFloor;
        }

        public DataTable Get_PC_name_Hardware()
        {
            DataTable DataFloor = new DataTable();

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"select DISTINCT NameLAN from NameLAN, MainTB WHERE	mainTB.NameLAN_ID = NameLan.ID 
                and mainTB.TypeDevice_ID = (select id from TypeDevice where TypeDevice.NameDevice  like'%истемный блок')
                and NameLAN != ''
                and MainTB.WrittenOff = 'false';", connect);

                try
                {

                    connect.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataFloor = ds.Tables[0];
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataFloor;
        }

        public ArrayList dataMainTB()
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"select
                maintb.ID, 
                maintb.dateCreated, 
                maintb.NumberINV, 
                TypeAC.TypeAC,
                NameLAN.NameLAN, 
                NameRes.NameRes, 
                [Floor].floorNambe, 
                Room.NameRoom,
                TypeDevice.NameDevice, 
                maintb.SN,
                MainTB.Model,
                JiraTask, 
                WrittenOff,
                ReasonWriteOff
                ,[Note]
                from MainTB
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID 
                join [Floor] on maintb.Floor_ID = [Floor].ID 
                join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID 
                join NameLAN on maintb.NameLAN_ID = NameLAN.ID 
                join NameRes on maintb.NameRes_ID =  NameRes.ID 
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID 
                order by NameRes,NameLAN, TypeDevice_ID;", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            DataGrid.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataGrid;
        }

        public ArrayList dataHardware()
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT [HardWare].ID
            ,dateCreated
            ,NumberINV
            ,NameLAN.NameLAN
            ,NameRes.NameRes
            ,[Floor].floorNambe
            ,Room.NameRoom
            ,TypeHardWare
            ,[Model]
            ,[SN]
            ,JiraTask
            ,[WrittenOff]
            ,ReasonWriteOff
            ,[Note] 
            FROM [dbo].[HardWare],NameLAN, TypeHardWare,[Room], NameRes, [Floor], JiraTask
 
            Where NameLAN = (SELECT NameLAN  FROM [dbo].[MainTB] join NameLAN on NameLAN_ID = NameLAN.ID   Where [MainTB].ID = MainTB_ID ) AND
            TypeHardWare_ID = TypeHardWare.ID  AND
            NameRoom = (SELECT NameRoom  FROM [dbo].[MainTB] join [Room] on Room_ID = [Room].ID   Where [MainTB].ID = MainTB_ID ) AND
            NameRes.NameRes = (SELECT NameRes FROM [dbo].[MainTB] join NameRes on NameRes_ID = NameRes.ID   Where [MainTB].ID = MainTB_ID ) AND
            [Floor].floorNambe = (SELECT floorNambe FROM [dbo].[MainTB] join [Floor] on Floor_ID = [Floor].ID   Where [MainTB].ID = MainTB_ID ) AND
            JiraTask_ID = JiraTask.ID
            order by NameRes,NameLAN, TypeHardWare_ID;", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            DataGrid.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataGrid;
        }

        public ArrayList dataStockroom()
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT [HardwareStockRoom].[ID]
              ,[dateCreated]
              ,[NumberINV]
              ,[TypeHardWare]
              ,[Model]
              ,[SN]
              ,[quantity]
              ,[WrittenOff]
              ,[JiraTask]
              ,[ReasonWriteOff]
              ,[Note]
                FROM [TestDB].[dbo].[HardwareStockRoom], TypeHardWare, JiraTask
                Where TypeHardWare_ID = TypeHardWare.ID 
                AND JiraTask_ID = JiraTask.ID order by  TypeHardWare_ID;", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            DataGrid.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataGrid;
        }

    }
}