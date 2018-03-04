using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    class DAL_SET
    {


        //String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
        //    Properties.Settings.Default.SqlPort + "; Database=TolyattiDB; Integrated Security=true;";

        String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
            Properties.Settings.Default.SqlPort + "; Database=" + Properties.Settings.Default.SqlDataBase + "; Integrated Security=true;";


        // ghjdthrf 
        public void SetNewPosition(string TypeAccount, string TypeDevice, string Model,
            string SN, string Responsible, string LanName, string Floor, string Room, string InvNumber, string jira ) 
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            // переработать  20-21
            SqlCommand command = new SqlCommand(@"INSERT INTO dbo.MainTB (dateCreated, TypeAC_ID, NumberINV, NameLAN_ID, " +
                @"NameRes_ID, Floor_ID, Room_ID, TypeDevice_ID, SN, Model, [WrittenOff], JiraTask_ID) VALUES(GETDATE(), " + 
                TypeAccount + ", '" +
                InvNumber + "', " +  
                LanName + ", " +
                Responsible + ", " +
                Floor + ", " + 
                Room +", " +
                TypeDevice + ", '" +
                SN + "', '" +
                Model + "', 0, " + jira + "); ", connect);

            try
            {

                connect.Open();
            
                command.ExecuteNonQuery();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
           
        }

        public void SetNewPosition(string TypeDevice, string Model, string SN, string LanName, string InvNumber, string jira)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            // переработать  20-21
            SqlCommand command = new SqlCommand(@"INSERT INTO dbo.MainTB (dateCreated, TypeAC_ID, NumberINV, NameLAN_ID, " +
                @"NameRes_ID, Floor_ID, Room_ID, TypeDevice_ID, SN, Model, [WrittenOff], JiraTask_ID) VALUES(GETDATE(), '" +
                InvNumber + "', " +
                LanName + ", " +
                TypeDevice + ", '" +
                SN + "', '" +
                Model + "', 0, "+jira+"); ", connect);

            try
            {

                connect.Open();

                command.ExecuteNonQuery();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();

        }

        public void SetNewPosition(string Table, string Column, string Parametr)
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"INSERT INTO dbo." + Table + @" ( "+ Column+ @") VALUES('"+Parametr+ @"');", connect);

            try
            {

                connect.Open();

                command.ExecuteNonQuery();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();
            
        }

        public void SetChangeData(string ColumnMT, string Parametr, string ID)
        {

           
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Update  dbo.MainTB SET " + ColumnMT + " = " + Parametr + 
                    "  Where dbo.MainTB.ID ='" + ID + "';", connect);

                try
                {

                    connect.Open();

                    command.ExecuteNonQuery();
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
        

           
        }

        public void WrittenOff(string ID, string Reason, string value )
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Update  dbo.MainTB SET  [WrittenOff] = " + value +
                    ", [ReasonWriteOff] = '" +Reason + "' "+ 
                    "WHERE dbo.MainTB.ID = " + ID +" ;", connect);
                try
                {

                    connect.Open();

                    command.ExecuteNonQuery();
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
        }

        public void Delete (string table, string ID)
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Delete  dbo."+ table +  
                    " WHERE dbo."+ table + ".ID = " + ID + " ;", connect);
                try
                {

                    connect.Open();

                    command.ExecuteNonQuery();
                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }

                connect.Close();
            }
        }

        internal void AddFDB(string userName, int ID, string reasonWriteOff, string InvNumber, string TypeDevice, string SN, string Model, string ID_main)
        {
            SqlConnection connect = new SqlConnection(sConectDB);
            // переработать  20-21
            SqlCommand command = new SqlCommand(@" INSERT INTO dbo.JBD (dateCreated, UserName, KindOfActivity_ID, ReasonOrMoved, " +
                @"TypeDevice, SN, Model, ID_IN_Main_TB) VALUES(GETDATE(), '" +
                userName + "', " +
                ID + ", '" +
                reasonWriteOff + "', '" +
                TypeDevice + "', '" +
                SN + "', '" +
                Model + "'," +
                ID_main + ");", connect);

            try
            {

                connect.Open();

                command.ExecuteNonQuery();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }

            connect.Close();

        }
    }   
}


