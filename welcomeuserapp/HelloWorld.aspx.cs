using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net;
using System.IO;

namespace welcomeuserapp
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string strURL;
             

           string strbaseURL= ConfigurationManager.AppSettings.Get("ServiceURL");
           if ((txtName.Value != null) || (txtName.Value != string.Empty))
               strURL = strbaseURL + "/" + txtName.Value.Trim();
           else
               strURL = strbaseURL;
           HttpWebRequest servicerequest=(HttpWebRequest)WebRequest.Create(strURL);
           servicerequest.Method = "GET";
           servicerequest.ContentType = "application/json";
           WebResponse serviceresponse = servicerequest.GetResponse();
            Stream webstream= serviceresponse.GetResponseStream();
            StreamReader responsereader=new StreamReader(webstream);
            string response = responsereader.ReadLine();
            spnmessage.InnerHtml = response.Replace("\"", "");

            

        }
    }
}