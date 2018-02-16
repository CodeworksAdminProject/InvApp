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
        String sConectDB = @"server=tcp:" +Properties.Settings.Default.SqlServer+"," + 
            Properties.Settings.Default.SqlPort + "; Database=TolyattiDB; Integrated Security=true;";

        public ArrayList GetDataRoom()
        {
            ArrayList DataFloor = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand("SELECT dbo.Room.NameRoom FROM dbo.Room;", connect);

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

        public ArrayList GetDataResponsible()
        {
            ArrayList DataFloor = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand("Select dbo.NameRes.NameRes from dbo.NameRes order by NameRes;", connect);

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

        public ArrayList GetFloor()
        {
            ArrayList DataFloor = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand("Select dbo.Floor.floorNambe from dbo.Floor order by floorNambe; ", connect);

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

        public ArrayList GetDataLanName()
        {
            ArrayList DataFloor = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand("Select dbo.NameLAN.NameLAN from dbo.NameLAN order by NameLAN;", connect);

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

        public ArrayList GetDataTypeDevice()
        {
            ArrayList DataFloor = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand("select dbo.TypeDevice.NameDevice from dbo.TypeDevice  order by dbo.TypeDevice.NameDevice;", connect);

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

        public ArrayList GetDataGrid(string room)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from MainTB " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                       @"where Room.NameRoom = '" + room + @"' AND [WrittenOff] = 'False';", connect);

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

        internal DataTable GetRoomTabel(string floor)
        {
            DataTable DataRoom = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  DISTINCT Room.NameRoom, Room.ID From MainTB" + 
                    " join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID "+
                    " Where [Floor].ID = (select [Floor].ID From [Floor] where [floorNambe] ='"+ floor +
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

        public ArrayList GetDataGrid_inv(string inv)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from MainTB " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                       @"Where MainTB.NumberINV like '%" + inv + @"%' AND [WrittenOff] = 'False';", connect);

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

        internal DataTable GetMainTabel(string LanName, string Room)
        {
            DataTable DataLanName = new DataTable();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("select  MainTB.dateCreated, MainTB.NumberINV, TypeAC_ID, NameRes.NameRes, " +
                    "TypeDevice.NameDevice, MainTB.SN, MainTB.Model From MainTB "+
                    "join NameLAN on maintb.NameLAN_ID = NameLAN.ID "+
                    "join NameRes on maintb.NameRes_ID = NameRes.ID "+
                    "join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID "+
                    " Where[NameLAN].ID = (select[NameLAN].ID From[NameLAN] where[NameLAN].NameLAN = '"+LanName +
                    "') And Room_ID = (Select Room.ID From Room Where NameRoom = '"+Room + "') AND [WrittenOff] = 'False';", connect);

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

        public ArrayList GetDataGrid_Responsoble(string Responsoble)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from MainTB " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Where dbo.NameRes.NameRes =  '" + Responsoble + @"' AND [WrittenOff] = 'False';", connect);

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

        public ArrayList GetDataGrid_NamePC(string NamePC)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"select  maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from MainTB "+
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID "+
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID "+
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"Where dbo.NameLAN.NameLAN like'%" + NamePC + @"%' AND [WrittenOff] = 'False';", connect);

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

            else
                return null;

            con.Close();

        }

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

            else
                return 0;

            con.Close();

        }

        public ArrayList GetForSetForms()
        {
            string sqlQuestion;

            if (BLL.Data.Count > 1)
            {
                int n = 0;
               
                sqlQuestion = @"select maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from MainTB " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"where maintb.ID  IN (";

                foreach (string item in BLL.Data)
                {

                    sqlQuestion = sqlQuestion + "'";
                    sqlQuestion = sqlQuestion + item + "'";
                    sqlQuestion = sqlQuestion +","; 

                    n++;
                }

                sqlQuestion = sqlQuestion + "NULL";
                sqlQuestion = sqlQuestion + ") AND [WrittenOff] = 'False';";

            }

            else
            {
                sqlQuestion = "select maintb.ID, maintb.dateCreated, maintb.NumberINV, NameLAN.NameLAN, NameRes.NameRes, " +
                @"[Floor].floorNambe, Room.NameRoom, TypeDevice.NameDevice, maintb.SN, MainTB.Model from MainTB " +
                @"join [Floor] on maintb.Floor_ID = [Floor].ID join room on maintb.Room_ID =  Room.ID " +
                @"join TypeDevice on maintb.TypeDevice_ID = TypeDevice.ID join NameLAN on maintb.NameLAN_ID = NameLAN.ID " +
                @"join NameRes on maintb.NameRes_ID =  NameRes.ID " +
                @"where  maintb.ID  = '";

                foreach (string item in BLL.Data)
                {
                    sqlQuestion = sqlQuestion + item;
                }

                sqlQuestion = sqlQuestion + "' AND [WrittenOff] = 'False';";
            }



            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
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
            return DataGrid;
        }


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
    }

}
