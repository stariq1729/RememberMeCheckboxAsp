using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RememberMeCheckboxAsp
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Write("welcome " + Session["username"].ToString());
            }
            else
            {
               
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                //(Session["username"] = null);
                //when user press logout button session will be abandoned
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            else
            {
                
            }
        }
    }
}