using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace _04.DownloadFile
{
    public class WebDownload
    {
       static void Main()
        {
            //store location
            string localFilepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
           
           //create new web client            
            using (WebClient client = new WebClient())
            { 
                try
                {
                    client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", localFilepath);
                    Console.WriteLine("Download complete!");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("Invalid address!");
                }
                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
                }  
           }
        }

        
    }
}
