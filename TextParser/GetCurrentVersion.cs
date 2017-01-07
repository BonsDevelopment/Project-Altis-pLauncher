using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Altis_pLauncher.TextParser
{
    public class GetCurrentVersion
    {
        private static readonly string logPath = @"C:\Program Files (x86)\Project Altis\logs";
        private static string textFileLine;
        
 
        public static string CurrentVersion()
        {
            int lineCounter = 0;
            string bufferText = "";
            DirectoryInfo dirLog = new DirectoryInfo(logPath);

            FileInfo lastLog =  dirLog.GetFiles().OrderByDescending<FileInfo, DateTime>(f => f.LastWriteTime).First();


            using (StreamReader file = new StreamReader(logPath + "\\" + lastLog.Name))
            {
                while ((textFileLine = file.ReadLine()) != null)
                {
                    if (lineCounter == 8)
                    {
                        bufferText += textFileLine;    
                    }
                    if (lineCounter == 9)
                    {
                        bufferText += textFileLine;
                    }
                    lineCounter++;
                    
                }
                
                bufferText = TextFactory.CleanString(bufferText, "serverVersion:  ", "Pre", 0);
            }
            return bufferText;
        }
    }
}
