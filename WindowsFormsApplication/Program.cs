using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            
            if ((BLL.sMailBody != null) || (BLL.sMailBodyNew != null) || (BLL.sMailBodyDelete != null) || 
                (BLL.sHtmlTableAddWriteOffForReport != null) || (BLL.sHtmlTableTakeAwayWriteOffForReport != null) || (BLL.sMailBodyDelete != null))
                sentmail.SentMail(BLL.heds + BLL.sMailBody + BLL.sMailBodyNew + tabl1+ BLL.sHtmlTableAddWriteOffForReport + 
                    tabl2 + BLL.sHtmlTableTakeAwayWriteOffForReport + tabl3 + BLL.sHtmlTableDeleteReport + tabl4, Properties.Settings.Default.Email);
        }
    }
}
