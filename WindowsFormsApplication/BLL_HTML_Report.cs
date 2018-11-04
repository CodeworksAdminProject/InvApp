using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    class BLL_HTML_Report
    {
        private void html_full_report()
        {
            string head = @"<head>
            <style 'text css'>
            TABLE {border-collapse: collapse;}
            TH  {border: 3px solid black; padding: 4xp; color:#FF0000; font-size: 20px;}
            .flor {border: 2px solid black; background:#F0F8FF; padding: 4xp;font-size: 20px; text-align: center }
            TD {border: 1px solid black; background:#fff; paddong: 4xp;}
            .not {border: 3px solid black; background:#8B0000; padding: 4xp;color: #ffe;font-family: Arial, Helvetica, sans-serif;}
            .old {background: #ffe7e7; padding: 1px;}
            </style>
            <Script language='JavaScript' type='text / javascript'> 
            function getElementsByClass(searchClass, node, tag)
            {
                var classElements = new Array();
                if (node == null)
                    node = document;

                if (tag == null)
                    tag = '*';

                var els = node.getElementsByTagName(tag);
                var elsLen = els.length - 1;
                var pattern = new RegExp('(^|\\s)' + searchClass + '(\\s|$)');

                for (i = 0, j = 0; i <= elsLen; i++)
                    if (pattern.test(els[i].className))
                    {
                        classElements[j] = els[i];
                        j++;
                    }

                return classElements;
            }

            function OpenClose(CName)
            {
                var Elements = getElementsByClass(CName, document, 'tr');
                var ElementsLength = Elements.length - 1;

                for (i = 0; i <= ElementsLength; i++)
                    if (Elements[i].style.display == '')
                    {
                        Elements[i].style.display = 'none';
                    }
                    else
                    {
                        Elements[i].style.display = '';
                    }
            }
            </ Script >
            </ head > ";


        }
    }
}
