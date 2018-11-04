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
    internal class DAL_SET_Buttons
    {
        //String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
        //    Properties.Settings.Default.SqlPort + "; Database=TolyattiDB; Integrated Security=true;";

        String sConectDB = @"server=tcp:" + Properties.Settings.Default.SqlServer + "," +
            Properties.Settings.Default.SqlPort + "; Database=" + Properties.Settings.Default.SqlDataBase + "; Integrated Security=true;";

        internal void AddJDB(string userName, string kindJfActivity, string reasonWriteOff, string addId, string tableName)
        {
            string nameDB1 = "MainTB";
            string nameBDDivise;
            string nameColumnDivise;
            string nameColumnDiviseID;

            if (tableName == nameDB1)
            {
                nameBDDivise = "TypeDevice";
                nameColumnDivise = "NameDevice";
                nameColumnDiviseID = "TypeDevice_ID";
            }
            else
            {
                nameBDDivise = "TypeHardWare";
                nameColumnDivise = "TypeHardWare";
                nameColumnDiviseID = "TypeHardWare_ID";

            } 

            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
             SqlCommand command = new SqlCommand(@"
                DECLARE @ID INT
                DECLARE @CURSOR CURSOR 
                   
                SET @CURSOR  = CURSOR SCROLL
	            FOR 
	            Select ID FROM "+tableName + @" Where [ID] in (" +addId+ @")
	            Open @CURSOR
	            FETCH NEXT FROM @CURSOR INTO @ID
	
	            WHILE @@FETCH_STATUS = 0
                BEGIN

                DECLARE @TypeDevice varchar(80)  = (select " + nameBDDivise + "." + nameColumnDivise+ " from " + tableName + 
                    " join "+ nameBDDivise + " on " + tableName + "." + nameColumnDiviseID +" = "+nameBDDivise+ ".ID Where " + tableName +
                    @".ID =@ID );
                DECLARE @SN varchar(80)  = (select " + tableName + ".SN from " + tableName + " Where " + tableName + @".ID =@ID );
                DECLARE @Model varchar(80)  = (select " + tableName + @".Model from " + tableName + @" Where " + tableName + @".ID =@ID );

                INSERT INTO dbo.JBD (dateCreated, UserName, KindOfActivity_ID, ReasonOrMoved, TypeDevice, SN, Model, ID_IN_Main_TB)
                VALUES(GETDATE(), '"+ userName + "', "+kindJfActivity+ ", '"+ reasonWriteOff + @"' , @TypeDevice, @SN , @Model, @id);

                FETCH NEXT FROM @CURSOR INTO @ID
                end
                CLOSE @CURSOR"

                        , connect);
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

        public void WrittenOff(string ID, string Reason, string value, string tableName )
        {            
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Update  "+ tableName + " Set  [WrittenOff] = " + value +
                    ", [ReasonWriteOff] = '" + Reason + "' " +
                    "WHERE dbo." + tableName + ".ID IN (" + ID + ");", connect);
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

        internal DataTable Get_Hardware_TB(string ID)
        {
            {
                DataTable Data = new DataTable();
                using (SqlConnection connect = new SqlConnection(sConectDB))
                {
                    SqlCommand command = new SqlCommand(@"select TypeHardWare_ID, Model, Note From HardWare Where MainTB_ID =  " + ID + " and WrittenOff = 'false';", connect);

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
        }

        internal void Note(string ID, string tableName, string note)
        {
            using (SqlConnection connect = new SqlConnection(sConectDB))
            {
                SqlCommand command = new SqlCommand("Update  " + tableName + " Set  Note = '" +note +
                    "' WHERE dbo." + tableName + ".ID IN (" + ID + ");", connect);
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