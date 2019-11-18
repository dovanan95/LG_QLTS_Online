using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Microsoft.Win32;
using System.Diagnostics;

namespace Test
{
    /// <summary>
    /// Summary description for Print_doc_service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Print_doc_service : System.Web.Services.WebService
    {
        //Bien_Ban Bien_Ban = new Bien_Ban();
        //ReportFunction Report = new ReportFunction();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void Print_doc(string SoBB)
        {
            
            //OpenURL("http://10.224.50.222:49155/Bien_Ban.aspx");
            //Bien_Ban.Export_function(SoBB);
            Server.Transfer(string.Format("~/Bien_Ban.aspx?So_BB={0}", SoBB));
        }
        
        private void OpenURL(string url)
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            // Get the default browser path on the system
            string Default_Browser_Path = ((string)registryKey.GetValue(null, null)).Split('"')[1];

            Process p = new Process();
            p.StartInfo.FileName = Default_Browser_Path;
            p.StartInfo.Arguments = url;
            p.Start();
        }
    }
}
