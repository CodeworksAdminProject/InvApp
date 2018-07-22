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
    class DAL_GET
    {
        //String sConectDB = @"server=tcp:" +Properties.Settings.Default.SqlServer+"," + 
        //    Properties.Settings.Default.SqlPort + "; Database=TolyattiDB; Integrated Security=true;";

        String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
            Properties.Settings.Default.SqlPort + "; Database="+Properties.Settings.Default.SqlDataBase+"; Integrated Security=true;";

  

        //======================================Array List ======================================================== 

        // get JBD
        internal ArrayList getJDB()
        {
            ArrayList Data = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"SELECT 
                   [dateCreated]
                  ,[UserName]
                  ,[KindOfActivity].KindOfActivity
                  ,[ReasonOrMoved]
                  ,[TypeDevice]
                  ,[SN]
                  ,[Model]
                  ,[InvNumber]
                  ,[ID_IN_Main_TB]                  
            FROM [dbo].[JBD]
            Join KindOfActivity on JBD.KindOfActivity_ID = KindOfActivity.ID", connect);

            try
            {

                connect.Open();
                SqlDataReader datareader = command.ExecuteReader();

                if (datareader.HasRows)
                    foreach (DbDataRecord result in datareader)
                        Data.Add(result);
                else
                    return null;
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
            return Data;
        }

        internal ArrayList Get_LanName_Haradware(string Inv, string Lan, string Res)
        {
            ArrayList PS_name = new ArrayList();

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT [dbo].[MainTB].[ID]
            ,[NumberINV]
            ,[NameLAN].NameLAN
            ,[NameRes]
            ,[floorNambe]
            ,[NameRoom]
            ,[NameDevice]
            FROM  [dbo].[MainTB]
            JOIN NameRes on NameRes_ID = NameRes.ID
            JOIN [Floor] on Floor_ID = [Floor].[ID]
            JOIN [Room] on Room_ID = Room.ID
            JOIN [TypeDevice] on TypeDevice_ID = TypeDevice.ID
            JOIN [NameLAN] on NameLAN_ID = NameLAN.ID
            where (TypeDevice.NameDevice  like '%истемный блок' or  TypeDevice.NameDevice  like  '%ини ПК' or   TypeDevice.NameDevice  like '%ервер')
            and NameLAN LIKE '%"+Lan+ @"%'
		    and NameRes LIKE '%"+Res+@"%'
		    and [NumberINV] LIKE '%"+Inv+@"%'
            and MainTB.WrittenOff = 'false';", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            PS_name.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return PS_name;
        }

        // JBD
        internal ArrayList getJDB(string value )
        {
            ArrayList Data = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"SELECT 
                  [dateCreated]
                  ,[UserName]
                  ,[KindOfActivity].KindOfActivity
                  ,[ReasonOrMoved]
                  ,[TypeDevice]
                  ,[SN]
                  ,[Model]
                  ,[InvNumber]
                  ,[ID_IN_Main_TB]	              
            FROM [dbo].[JBD]  
            Join KindOfActivity on JBD.KindOfActivity_ID = KindOfActivity.ID
            WHERE " + value+";", connect);

            try
            {

                connect.Open();
                SqlDataReader datareader = command.ExecuteReader();

                if (datareader.HasRows)
                    foreach (DbDataRecord result in datareader)
                        Data.Add(result);
                else
                    return null;
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
            return Data;
        }
        
        // JBD
        internal ArrayList getJDB(string date , string Username, string KindOfActivity, string TypeDevice,
            string SN, string Model, string InvNumbe, string ID_main )
        {
            ArrayList Data = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"SELECT 
                  [dateCreated]
                  ,[UserName]
                  ,[KindOfActivity].KindOfActivity
                  ,[ReasonOrMoved]
                  ,[TypeDevice]
                  ,[SN]
                  ,[Model]
                  ,[InvNumber]
                  ,[ID_IN_Main_TB]	              
            FROM [dbo].[JBD]  
            Join KindOfActivity on JBD.KindOfActivity_ID = KindOfActivity.ID
            WHERE " + 
            date + " AND " +
            Username + " AND " +
            KindOfActivity + " AND " +
            TypeDevice + " AND " +
            SN + " AND " +
            Model + " AND " +
            InvNumbe + " AND " +
            ID_main +
            ";", connect);

            try
            {

                connect.Open();
                SqlDataReader datareader = command.ExecuteReader();

                if (datareader.HasRows)
                    foreach (DbDataRecord result in datareader)
                        Data.Add(result);
                else
                    return null;
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
            return Data;
        }

        // Forms WrateOffTable 
        internal ArrayList getWrateOffTable()
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask, ReasonWriteOff from MainTB " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Join JiraTask on maintb.JiraTask_ID = JiraTask.ID " +
                @"where [WrittenOff] = 'True';", connect);

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
            return DataGrid;
        }

        // get data from table from colunm (data order by )
        public ArrayList Get_Data_From_Table_From_Colunm(string table, string column)
        {
            ArrayList DataFloor = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand("select dbo." + table + "." + column + " from dbo." + table + "  order by dbo." + table + "." + column + ";", connect);

            try
            {

                connect.Open();
                SqlDataReader datareader = command.ExecuteReader();

                if (datareader.HasRows)
                    foreach (DbDataRecord result in datareader)
                        DataFloor.Add(result);
                else
                    return null;
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
            return DataFloor;
        }

        // get name  pc for  combobox_hardware_namepc
        public ArrayList Get_PC_name_Hardware()
        {
            ArrayList PS_name = new ArrayList();

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"select DISTINCT NameLAN from NameLAN, MainTB WHERE	mainTB.NameLAN_ID = NameLan.ID 
                and mainTB.TypeDevice_ID = (select id from TypeDevice where TypeDevice.NameDevice  like'%истемный блок')
                and NameLAN != ''
                and MainTB.WrittenOff = 'false';", connect);

                try
                {

                    connect.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                        foreach (DbDataRecord result in datareader)
                            PS_name.Add(result);
                    else
                        return null;
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return PS_name;
        }


        // Forms setdata
        public ArrayList Get_For_SetForms_MaintTB(string ID)
        {
            string sqlQuestion;
            ArrayList DataGrid = new ArrayList();

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {

                
                    sqlQuestion = @"select
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
                from MainTB
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID 
                join [Floor] on maintb.Floor_ID = [Floor].ID 
                join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID 
                join NameLAN on maintb.NameLAN_ID = NameLAN.ID 
                join NameRes on maintb.NameRes_ID =  NameRes.ID 
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID                 
                where maintb.ID  IN ("+ID+
                @") AND [WrittenOff] = 'False'order by NameRes,NameLAN, TypeDevice_ID; ";

                   
                SqlCommand command = new SqlCommand(sqlQuestion, connect);

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

        public ArrayList Get_For_SetForms_HardwareStockRoom(string ID)
        {
            string sqlQuestion;
            ArrayList DataGrid = new ArrayList();

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                sqlQuestion = @"SELECT [HardwareStockRoom].ID
                      ,[dateCreated]
                      ,[NumberINV]                      
                      ,[TypeHardWare]
                      ,[Model]
                      ,[SN]
                      ,[quantity]
                      ,[JiraTask_ID]
                  FROM [dbo].[HardwareStockRoom]
                  Join [TypeHardWare] on TypeHardWare_ID = [TypeHardWare].[ID]" +
                @" where [HardwareStockRoom].ID  IN (" + ID + ");";


                SqlCommand command = new SqlCommand(sqlQuestion, connect);

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

        public ArrayList Get_For_SetForms_HardWare(string ID)
        {
            string sqlQuestion;
            ArrayList DataGrid = new ArrayList();

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                sqlQuestion = @"SELECT 
	          NameLAN.NameLAN
              ,HardWare.ID 
              ,[TypeHardWare]
              ,[Model]
              ,[SN]
              ,[WrittenOff]
               FROM [dbo].[HardWare],NameLAN, TypeHardWare
                Where NameLAN = (SELECT NameLAN  FROM [dbo].[MainTB] join NameLAN on NameLAN_ID = NameLAN.ID   Where [MainTB].ID = MainTB_ID) 
                AND TypeHardWare_ID = TypeHardWare.ID" +
                @" and [HardWare].ID  IN (" + ID + ");";


                SqlCommand command = new SqlCommand(sqlQuestion, connect);

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

        // hardware 
        public ArrayList GetHardWare(string ID)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"SELECT [dbo].[HardWare].[ID], TypeHardWare.TypeHardWare, HardWare.Model, HardWare.SN " +
                @"from HardWare  join TypeHardWare on HardWare.TypeHardWare_ID = TypeHardWare.ID " +
                @"Where HardWare.MainTB_ID = " + ID + @" AND HardWare.WrittenOff = 'False';", connect);

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
            return DataGrid;
        }

        // hardware  main page 
        internal ArrayList Get_Hardware_StockRoom()
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"SELECT [HardwareStockRoom].ID
                      ,[dateCreated]
                      ,[NumberINV]                      
                      ,[TypeHardWare]
                      ,[Model]
                      ,[SN]
                      ,[quantity]
                      ,[JiraTask]
                  FROM [dbo].[HardwareStockRoom]
                  Join [TypeHardWare] on TypeHardWare_ID = [TypeHardWare].[ID]
                  Join [JiraTask] on JiraTask_ID = JiraTask.ID ;", connect);

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
            return DataGrid;
        }

        // hardware  main page  into  stockroom
        internal ArrayList Get_Hardware_PS()
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"SELECT 
	          NameLAN.NameLAN
              ,HardWare.ID 
              ,[TypeHardWare]
              ,[NumberINV]
              ,[Model]
              ,[SN]
              ,[WrittenOff]
              ,[JiraTask]
               FROM [dbo].[HardWare],NameLAN, TypeHardWare, JiraTask
                Where NameLAN = (SELECT NameLAN  FROM [dbo].[MainTB] join NameLAN on NameLAN_ID = NameLAN.ID   Where [MainTB].ID = MainTB_ID)
                AND JiraTask_ID = JiraTask.ID 
                AND TypeHardWare_ID = TypeHardWare.ID;", connect);

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
            return DataGrid;
        }




        //======================================Data table ======================================================== 

        internal DataTable Table_Change_data(string IDs)
        {
           DataTable Data = new DataTable();
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
                from MainTB
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID 
                join [Floor] on maintb.Floor_ID = [Floor].ID 
                join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID 
                join NameLAN on maintb.NameLAN_ID = NameLAN.ID 
                join NameRes on maintb.NameRes_ID =  NameRes.ID 
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID                 
                where maintb.ID  IN (" + IDs +
                @") AND [WrittenOff] = 'False'; ", connect);

                try
                {

                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    Data = ds.Tables[0];
                        
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return Data;
        }
        
        // from BBL report 
        internal DataTable getWrateOffTable(string ID)
        {
            DataTable Data = new DataTable();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.NumberINV, 
                [Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from mainTB 
                join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID                  
                where maintb.ID  IN ( " + ID + " ); ", connect);

            try
            {

                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Data= ds.Tables[0];
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
            return Data;
        }
       
        // EXCEL BBL 
        public DataTable GetFloorTable()
        {
           DataTable DataFloor = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Select dbo.Floor.floorNambe from dbo.Floor order by floorNambe; ", connect);

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

        // EXCEL BBL
        internal DataTable GetLanNameTabel(string LanName)
        {
            DataTable DataLanName = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  DISTINCT NameLAN.NameLAN From MainTB  join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                    " join room on maintb.Room_ID = Room.ID Where[room].ID = (select[room].ID From[room] where[NameRoom] = '" + LanName +
                    "') AND [WrittenOff] = 'False' Order BY NameLAN.NameLAN ;", connect);

                try
                {

                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataLanName = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataLanName;
        }

        // EXCEL BBL
        internal DataTable GetMainTabel(string LanName, string Room)
        {
            DataTable DataLanName = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  MainTB.dateCreated, MainTB.NumberINV, TypeAC_ID, NameRes.NameRes, " +
                    "TypeDevice.NameDevice, MainTB.SN, MainTB.Model From MainTB " +
                    "join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                    "join NameRes on maintb.NameRes_ID = NameRes.ID " +
                    "join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID " +
                    " Where[NameLAN].ID = (select[NameLAN].ID From[NameLAN] where[NameLAN].NameLAN = '" + LanName +
                    "') And Room_ID = (Select Room.ID From Room Where NameRoom = '" + Room + "') AND [WrittenOff] = 'False';", connect);

                try
                {

                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataLanName = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataLanName;
        }

        // EXCEL BBL
        internal DataTable GetRoomTabel(string floor)
        {
            DataTable DataRoom = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  DISTINCT Room.NameRoom, Room.ID From MainTB" +
                    " join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                    " Where [Floor].ID = (select [Floor].ID From [Floor] where [floorNambe] ='" + floor +
                    "') AND [WrittenOff] = 'False' Order BY Room.ID ; ", connect);

                try
                {

                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRoom = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataRoom;
        }

        //======================================Переделать ======================================================== 

        //-
        public ArrayList GetDataGrid(string table, string value)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated,TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, 
                [Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask from MainTB 
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID 
                join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID 
                join NameRes on maintb.NameRes_ID =  NameRes.ID 
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID
                Where " + table+ " like'%" + value+ "%' AND[WrittenOff] = 'False' order by NameRes,NameLAN, TypeDevice_ID;", connect);

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
            return DataGrid;
        }

        public ArrayList GetDataGrid_Combobox(string table, string value)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, 
                [Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask from MainTB 
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID
                join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID 
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID 
                join NameRes on maintb.NameRes_ID =  NameRes.ID 
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID
                Where " + table + "='" + value + "' AND[WrittenOff] = 'False' order by NameRes,NameLAN, TypeDevice_ID;", connect);

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
            return DataGrid;
        }

        public ArrayList GetDataGrid_ALL()
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
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
            return DataGrid;
        }
        //-
        public ArrayList GetDataGrid_TypeDevice(string TypeDevice)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask from MainTB " +
                @"join TypeAC on maintb.TypeAC_ID = TypeAC.ID "+
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Join JiraTask on maintb.JiraTask_ID = JiraTask.ID " +
                @"Where dbo.TypeDevice.NameDevice =  '" + TypeDevice + @"' AND [WrittenOff] = 'False' order by NameRes,NameLAN, TypeDevice_ID;", connect);

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
            return DataGrid;
        }
      
        //-
        public ArrayList GetDataGrid_Responsoble(string Responsoble)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask from MainTB " +
                @"join TypeAC on maintb.TypeAC_ID = TypeAC.ID " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Join JiraTask on maintb.JiraTask_ID = JiraTask.ID " +
                @"Where dbo.NameRes.NameRes =  '" + Responsoble + @"' AND [WrittenOff] = 'False' order by NameRes,NameLAN, TypeDevice_ID;", connect);

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
            return DataGrid;
        }

        //-
        public ArrayList GetDataGrid_NamePC(string NamePC)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask from MainTB " +
                @"join TypeAC on maintb.TypeAC_ID = TypeAC.ID " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Join JiraTask on maintb.JiraTask_ID = JiraTask.ID " +
                @"Where dbo.NameLAN.NameLAN ='" + NamePC + @"' AND [WrittenOff] = 'False' order by NameRes,NameLAN, TypeDevice_ID;", connect);

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
            return DataGrid;
        }


        //======================================other data ========================================================  

        //- Check complince in the table
        public string GetParam_Tables(string Table, string Column, string Name)
        {

            string Resulty;
            string[] itemDB = new string[1];
            SqlConnection con = new SqlConnection(sConectDB);
            SqlCommand com = new SqlCommand("select dbo."+Table+ "."+ Column + " from dbo." + Table + " where dbo." + Table + "." + Column +  " = '" + Name + "';", con);
            con.Open();
            //com.ExecuteReader();
            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    itemDB[0] = dr.GetString(0);

                }
                Resulty = itemDB[0];
                return Resulty;
            }

            else { }

                con.Close();

            return null;
        }

        // get max id 
        internal string get_max_ID(string table_name)
        {
            string ID_max;
            int[] itemDB = new int[1];

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT MAX (ID) FROM " + table_name + ";", connect);
                try
                {

                    connect.Open();

                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            itemDB[0] = datareader.GetInt32(0);

                        }
                        ID_max = itemDB[0].ToString();
                        return ID_max;
                    }

                    else
                        return null; 

                    
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();

                return null;
            }
        }

        //- Get ID 
        public int GetID_Tables(string Table, string Column, string Name)
        {

           int Resulty;
            int[] itemDB = new int[1];
            SqlConnection con = new SqlConnection(sConectDB);
            SqlCommand com = new SqlCommand("select dbo." + Table + ".ID from dbo." + Table + " where dbo." + Table + "." + Column + " = '" + Name + "';", con);
            con.Open();
            //com.ExecuteReader();
            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    itemDB[0] = dr.GetInt32(0);
                }
                Resulty = itemDB[0];
                return Resulty;
            }

            else {}

            con.Close();

            return 0;
        }

 
    }

}
