using System;

namespace WindowsFormsApplication
{
    internal class BLL_Buttoms
    {
        DAL_SET_Buttons dalSetButtonns = new DAL_SET_Buttons();
        BLL bll = new BLL();

        internal void Writtenoff(string addId, string tableName)
        {

            WriteOff set = new WriteOff();
            set.button_OK.Text = "Списать";
            set.ShowDialog();

            if (BLL.flag == true)
            {

                dalSetButtonns.WrittenOff(addId, BLL.ReasonWriteOff, "1", tableName);

                dalSetButtonns.AddJDB(Environment.UserName, 1, BLL.ReasonWriteOff, addId, tableName);

                BLL.sHtmlTableAddWriteOffForReport = BLL.sHtmlTableAddWriteOffForReport + bll.WrittenOff_And_Delete(addId, BLL.sHtmlTableAddWriteOffForReport, "Add");
                BLL.ReasonWriteOff = null;
                BLL.flag = false;
            }
        }
    }
}