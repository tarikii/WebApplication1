using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        public string UserName2;
        public static string UserName3;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {

                if (Session["Username"] != null)
                    Saludo.($"Bienvenido, {Session["Username"].ToString()}!");
            }*/
        }
    }
}