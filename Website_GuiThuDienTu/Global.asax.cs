using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Website_GuiThuDienTu
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Website_GuiThuDienTu.App_Data.SQLDatabase.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            Application["Time_login"] = new List<KeyValuePair<string, string>>();
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            
            Session["iPK_AdminID"] = "";
            Session["sEmail"] ="";
            Session["sName"] ="";
            Session["sPassword"] = "";
            Session["LogIn"] = "1";
            Session["Count"] = 0;
            Session["SetTime"] = DateTime.Now;
            Session["Lock"] = false;
        }
    }
}