using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
using System.Globalization;

namespace AdditionOfNumbers.HelperClasses
{
    public static class HandleError
    {
        /// <summary>
        /// To Write error in log file
        /// </summary>
        /// <param name="errorObj"></param>
        public static void WriteError(Exception errorObj)
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(errorObj, true);

            bool Folderexists = System.IO.Directory.Exists(System.Web.HttpContext.Current.Server.MapPath("~/ErrorLog"));
            if (!Folderexists)
            {
                System.IO.Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath("~/ErrorLog"));
            }
            string path = "~/ErrorLog/" + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
            if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(path)))
            {
                File.Create(System.Web.HttpContext.Current.Server.MapPath(path)).Close();

            }
            using (StreamWriter w = File.AppendText(System.Web.HttpContext.Current.Server.MapPath(path)))
            {
                w.WriteLine(DateTime.Now.ToString() + ": " + errorObj.Source.ToString().Trim() + "; " + errorObj.Message.ToString().Trim());            
                w.Flush();
                w.Close();
            }

        }
    }
}