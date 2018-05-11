using System;

namespace WindowsFormsApplication
{
    internal class BLL_Buttoms
    {
        DAL_SET_Buttons dalSetButtonns = new DAL_SET_Buttons();
        BLL bll = new BLL();
        DAL_GET dalGet = new DAL_GET();

        internal void Writtenoff(string addId, string tableName)
        {
            string  KindOfActivity; 
            if (tableName == "HardWare" || tableName == "HardwareStockRoom")
            {
                KindOfActivity = "9";
            }

            else 
            {
                KindOfActivity = "1";
            }
            

            WriteOff set = new WriteOff();
            set.button_OK.Text = "Списать";
            set.ShowDialog();

            if (BLL.flag == true)
            {

                dalSetButtonns.WrittenOff(addId, BLL.ReasonWriteOff, KindOfActivity, tableName);

                dalSetButtonns.AddJDB(Environment.UserName, KindOfActivity, BLL.ReasonWriteOff, addId, tableName);

                BLL.sHtmlTableAddWriteOffForReport = BLL.sHtmlTableAddWriteOffForReport + bll.WrittenOff_And_Delete(addId, BLL.sHtmlTableAddWriteOffForReport, "Add");
                BLL.ReasonWriteOff = null;
                BLL.flag = false;
            }
        }

        internal void Change_data(string addId, string tableName)
        {
            string KindOfActivity;
            if (tableName == "HardWare")
            {
                KindOfActivity = "8";
            }

            else if (tableName == "HardwareStockRoom")  
            {
                KindOfActivity = "8";
            }

            else
            {
                KindOfActivity = "7";
            }
            
            dalSetButtonns.AddJDB(Environment.UserName, KindOfActivity, "null", addId, tableName);

            
            setDataBase SetData = new setDataBase();
            
            SetData.Set_flag_button(tableName);
            SetData.Set_ArrayList_DataINV(dalGet.Get_For_SetForms_MaintTB(addId));
            SetData.ShowDialog();
            //SetData.DataINV = ; 

        }
    }
}