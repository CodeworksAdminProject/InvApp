using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication
{
    

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            SMTP_CLIENT sentmail = new SMTP_CLIENT();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrorm());

            string table = null;
            if (BLL.sMailBody != null)
                table = "</table>";

            string table1 = null;
            if (BLL.sMailBodyNew != null)
                table1 = "</table>";

            string table2 = null;
            if (BLL.sHtmlTableAddWriteOffForReport != null)
                table2 = "</table>";

            string table3 = null;
            if (BLL.sHtmlTableTakeAwayWriteOffForReport != null)
                table3 = "</table>";

            string table4 = null;
            if (BLL.sHtmlTableDeleteReport != null)
                table4 = "</table>";

            string table5 = null;
            if (BLL.sHtmlTableHardware_PS != null)
                table5 = "</table>";

            string table6 = null;
            if (BLL.sHtmlTableHardware_Stockroom != null)
                table6 = "</table>";

            string table7 = null;
            if (BLL.sHtmlTable_Change_data != null)
                table7 = "</table>";

            string table8 = null;
            if (BLL.sHtmlTable_Move_Hardware  != null)
                table8 = "</table>";

            if ((BLL.sMailBody != null) || (BLL.sMailBodyNew != null) || (BLL.sMailBodyDelete != null) || 
                (BLL.sHtmlTableAddWriteOffForReport != null) || (BLL.sHtmlTableTakeAwayWriteOffForReport != null) || (BLL.sMailBodyDelete != null) ||
                (BLL.sHtmlTableHardware_PS != null) || (BLL.sHtmlTableHardware_Stockroom != null) || (BLL.sHtmlTable_Change_data != null) ||
                (BLL.sHtmlTable_Move_Hardware != null))

                sentmail.SentMail(BLL.heds + BLL.sMailBody +table + BLL.sMailBodyNew + table1+ BLL.sHtmlTableAddWriteOffForReport + 
                    table2 + BLL.sHtmlTableTakeAwayWriteOffForReport + table3 + BLL.sHtmlTableDeleteReport + table4 +
                    BLL.sHtmlTableHardware_Stockroom + table6 + BLL.sHtmlTableHardware_PS+table5 + BLL.sHtmlTable_Change_data + table7 +
                    BLL.sHtmlTable_Move_Hardware + table8, Properties.Settings.Default.Email);

          //  System.IO.File.WriteAllText(@"D:\error\sMailBody.txt", BLL.sMailBody + table);
          //  System.IO.File.WriteAllText(@"D:\error\heds.txt", BLL.heds);
        }

        
    }
}
