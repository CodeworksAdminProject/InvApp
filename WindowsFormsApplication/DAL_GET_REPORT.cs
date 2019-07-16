using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using System.Data;

namespace WindowsFormsApplication
{
    class DAL_GET_REPORT
    {
        //String sConectDB = @"server=tcp:" +Properties.Settings.Default.SqlServer+"," + 
        //    Properties.Settings.Default.SqlPort + "; Database=TolyattiDB; Integrated Security=true;";

        String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
            Properties.Settings.Default.SqlPort + "; Database=" + Properties.Settings.Default.SqlDataBase + "; Integrated Security=true;";




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
                Data = ds.Tables[0];
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
                SqlCommand command = new SqlCommand("Select * from dbo.Floor order by floorNambe; ", connect);

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
        internal DataTable GetLanNameTabel(string LanName, string floor_id)
        {
            DataTable DataLanName = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  DISTINCT NameLAN.NameLAN From MainTB  join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                    " join room on maintb.Room_ID = Room.ID Where[room].ID = (select[room].ID From[room] where[NameRoom] = '" + LanName +
                    "') AND [WrittenOff] =  'False'  AND MainTB.Floor_ID = " + floor_id + "Order BY NameLAN.NameLAN ;", connect);

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
        internal DataTable GetMainTabel(string LanName, string Room, string floor)
        {
            DataTable DataLanName = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated,TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, 
                [Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask, [Note] from MainTB
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID
                join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID = Room.ID
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID
                join NameRes on maintb.NameRes_ID = NameRes.ID
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID
                 where[NameLAN].NameLAN = '" + LanName +
                 "' And NameRoom = '" + Room +
                 "' AND floorNambe = '" + floor +
                 "' and[WrittenOff] = 'False' Order BY TypeDevice_ID;", connect);

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
        internal DataTable GetMainTabel(string Room)
        {
            DataTable DataLanName = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated,TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, 
                [Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask, [Note] from MainTB
                join TypeAC on maintb.TypeAC_ID = TypeAC.ID
                join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID = Room.ID
                join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID
                join NameRes on maintb.NameRes_ID = NameRes.ID
                Join JiraTask on maintb.JiraTask_ID = JiraTask.ID
                 where NameRoom = '" + Room +
                 "' and[WrittenOff] = 'False' Order BY TypeDevice_ID;", connect);

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

        // EXCEL BBL
        internal DataTable GetRoomTabel(string floor, string not_in_room)
        {
            DataTable DataRoom = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  DISTINCT Room.NameRoom, Room.ID From MainTB" +
                    " join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                    " Where [Floor].ID = (select [Floor].ID From [Floor] where [floorNambe] ='" + floor +
                    "') AND [WrittenOff] = 'False' AND [NameRoom] not in (" + not_in_room + ") Order BY Room.ID ; ", connect);

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

        // EXCEL BBL
        internal DataTable GetHardwareTabel(string ID)
        {
            DataTable DataHW = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"SELECT [NumberINV], [TypeHardWare], [Model], [SN], [Note]
                    FROM[HardWare] join[TypeHardWare] on[TypeHardWare_ID] =[TypeHardWare].ID
                    Where MainTB_ID = " + ID + " Order BY [TypeHardWare_ID] ", connect);

                try
                {
                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataHW = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataHW;
        }

        // EXCEL BBL
        internal DataTable Get_WrittenOff_DataTable()
        {
            DataTable DataHW = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, TypeAC.TypeAC, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model, JiraTask, ReasonWriteOff, Note from MainTB " +
                @"join TypeAC on maintb.TypeAC_ID = TypeAC.ID " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Join JiraTask on maintb.JiraTask_ID = JiraTask.ID " +
                @"where [WrittenOff] = 'True';", connect);

                try
                {
                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataHW = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataHW;
        }

        // EXCEL BBL
        internal DataTable Get_HW_StockRoom()
        {
            DataTable DataHW = new DataTable();
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
                      ,ReasonWriteOff
                      ,[JiraTask]
                      ,[Note]
                  FROM [dbo].[HardwareStockRoom]
                  Join [TypeHardWare] on TypeHardWare_ID = [TypeHardWare].[ID]
                  Join [JiraTask] on JiraTask_ID = JiraTask.ID ;", connect);

                try
                {
                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataHW = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataHW;
        }

        // EXCEL BBL
        internal DataTable Get_JDB_DataTable()
        {
            DataTable DataHW = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
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
            Join KindOfActivity on JBD.KindOfActivity_ID = KindOfActivity.ID;", connect);

                try
                {
                    connect.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataHW = ds.Tables[0];

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
            return DataHW;
        }

    }
}
