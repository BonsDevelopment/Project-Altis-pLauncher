using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project_Altis_pLauncher.TextParser
{

    public static class TextFactory
    {
        private static readonly WebClient wcStringDownloader = new WebClient();
     
        public static async Task<string> GetStringRequestAsync(Uri uri)
        {
            
            using (wcStringDownloader)
            {
                return await wcStringDownloader.DownloadStringTaskAsync(uri);
            }

           
        }

        public static string GetStringRequest(Uri uri)
        {
            using (wcStringDownloader)
            {
                return wcStringDownloader.DownloadString(uri);
            }

        }


        public static string ExcessRemover(this string thisString, string[] strDelimeters)
        {
            foreach (var strReplace in strDelimeters)
            {
                thisString = thisString.Replace(strReplace, "");
            }

            return thisString;
        }

        public static string CleanString(string origString, string startCut, string endCut, int indexValue)
        {
            int Start = origString.IndexOf(startCut, indexValue) + startCut.Length;
            int End = origString.IndexOf(endCut, Start);
            return origString.Substring(Start, End - Start);
        }

       
    }
}
