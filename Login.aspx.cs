using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RememberMeCheckboxAsp
{
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                if (Request.Cookies["username"] == null)
                {
                    TextBox1.Text = Request.Cookies["username"].Value.ToString();
                }
                if (Request.Cookies["password"] == null)
                {
                   TextBox2.Text = Request.Cookies["password"].Value.ToString();
                }
                if(Request.Cookies["username"] == null && Request.Cookies["password"] == null)
                {
                    CheckBox1.Checked = true;
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Login where username = @user and password = @pass";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@user", TextBox1.Text);
            sda.SelectCommand.Parameters.AddWithValue("@pass", TextBox2.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0 )
            {
                if (CheckBox1.Checked == true)
                {
                    Response.Cookies["username"].Value = TextBox1.Text;
                    Response.Cookies["password"].Value = TextBox2.Text;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(1);


                }
                else
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);

                }
                Session["username"] = TextBox1.Text;
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('username 0r password is incorrect')</script>");
            }
        }

       
    }
}