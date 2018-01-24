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


        String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
            Properties.Settings.Default.SqlPort + "; Database=inv; Integrated Security=true;";


        public void SetNewPosition(string TypeAccount, string TypeDevice, string Model,
            string SN, string Responsible, string LanName, string Floor, string Room, string InvNumber ) 
        {
            ArrayList DataGrid = new ArrayList();
            SqlConnection connect = new SqlConnection(sConectDB);
            SqlCommand command = new SqlCommand(@"if (select MainTB.NumberINV from MainTB where MainTB.NumberINV = '" + InvNumber + @"') IS NULL " +
                @" begin INSERT INTO dbo.MainTB (dateCreated, TypeAC_ID, NumberINV, NameLAN_ID, " +
                @"NameRes_ID, Floor_ID, Room_ID, TypeDevice_ID, SN, Model, [WrittenOff]) VALUES(GETDATE(), " + 
                TypeAccount + ", '" +
                InvNumber + "', " +  
                LanName + ", " +
                Responsible + ", " +
                Floor + ", " + 
                Room +", " +
                TypeDevice + ", '" +
                SN + "', '" +
                Model + "', 0)" + 
                 " end; ", connect);

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
            SqlCommand command = new SqlCommand("INSERT INTO dbo." + Table + " ( " + Column+") VALUES('"+Parametr+ "');", connect);

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

        public void SetChangeData(string ColumnMT, string Parametr, string ID, string SN, string Model)
        {

           
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Update  dbo.MainTB SET " + ColumnMT + " = " + Parametr + 
                    "  Where dbo.MainTB.ID ='" + ID + "' and dbo.MainTB.SN = '"+SN+ "' and dbo.MainTB.Model = '"+
                    Model +"';", connect);

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

        public void Delete(string ID)
        {
            ArrayList DataGrid = new ArrayList();
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Update  dbo.MainTB SET  [WrittenOff] = 1 " +
                    "WHERE dbo.MainTB.ID = '"+ ID +"' ;", connect);
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
}


