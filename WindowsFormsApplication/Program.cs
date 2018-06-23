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

            string tabl = null;
            if (BLL.sMailBody != null)
                tabl = "</table>";

            string tabl1 = null;
            if (BLL.sMailBodyNew != null)
                tabl1 = "</table>";

            string tabl2 = null;
            if (BLL.sHtmlTableAddWriteOffForReport != null)
                tabl2 = "</table>";

            string tabl3 = null;
            if (BLL.sHtmlTableTakeAwayWriteOffForReport != null)
                tabl3 = "</table>";

            string tabl4 = null;
            if (BLL.sHtmlTableDeleteReport != null)
                tabl4 = "</table>";

            string tabl5 = null;
            if (BLL.sHtmlTableHardware_PS != null)
                tabl5 = "</table>";

            string tabl6 = null;
            if (BLL.sHtmlTableHardware_Stockroom != null)
                tabl6 = "</table>";

            if ((BLL.sMailBody != null) || (BLL.sMailBodyNew != null) || (BLL.sMailBodyDelete != null) || 
                (BLL.sHtmlTableAddWriteOffForReport != null) || (BLL.sHtmlTableTakeAwayWriteOffForReport != null) || (BLL.sMailBodyDelete != null) ||
                (BLL.sHtmlTableHardware_PS != null) || (BLL.sHtmlTableHardware_Stockroom != null))

                sentmail.SentMail(BLL.heds + BLL.sMailBody +tabl + BLL.sMailBodyNew + tabl1+ BLL.sHtmlTableAddWriteOffForReport + 
                    tabl2 + BLL.sHtmlTableTakeAwayWriteOffForReport + tabl3 + BLL.sHtmlTableDeleteReport + tabl4 +
                    BLL.sHtmlTableHardware_Stockroom + tabl6 + BLL.sHtmlTableHardware_PS+tabl5, Properties.Settings.Default.Email);

            System.IO.File.WriteAllText(@"D:\error\sMailBody.txt", BLL.sMailBody + tabl);
          //  System.IO.File.WriteAllText(@"D:\error\heds.txt", BLL.heds);
        }

        
    }
}
