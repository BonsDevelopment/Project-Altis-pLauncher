using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Altis_pLauncher.TextParser
{
    public class GetChangeLog
    {
        private static string[] stringDelimeters = {"<li>", "</li>" };

        public static string ChangeLog()
        {
            string pageSource = TextFactory.GetStringRequest(new Uri("http://bon.x10host.com/Project%20Altis/ttpaChangeLog.txt")).ExcessRemover(stringDelimeters);
            return pageSource;
        }
    }
}


//</h3><u1>
