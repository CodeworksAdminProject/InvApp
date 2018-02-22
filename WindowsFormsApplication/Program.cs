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
            if (BLL.sMailBodyNew != null)
                tabl2 = "</table>";

            if ((BLL.sMailBody != null) || (BLL.sMailBodyNew != null) || (BLL.sMailBodyDelete != null) || (BLL.sHtmlTableWriteOffForReport !=null))
                sentmail.SentMail(BLL.heds + BLL.sMailBody + BLL.sMailBodyDelete + tabl1+ BLL.sHtmlTableWriteOffForReport + tabl2, Properties.Settings.Default.Email);
        }
    }
}
