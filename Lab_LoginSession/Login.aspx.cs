using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        // if (txtUserName.Text.Trim() == "") { }
        //if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
        //{
        //    lblPrompt.Text = "please key in userName or password";
        //    return;
        //}

        //Response.Cookies["userName"].Value = txtUserName.Text;
        //Response.Cookies["password"].Value = txtPassword.Text;

        //HttpCookie c = Request.Cookies["resultURL"];

        //if (c == null)
        //{
        //    Response.Redirect("Default.aspx");
        //}
        //else
        //{

        //    Response.Redirect(c.Value);


        //}

        if (txtUserName.Text.Trim() == ""|| txtPassword.Text.Trim() == "")
        {
            lblPrompt.Text= "please key in userName or password";
                return;
        }
        Session["userName"] = txtUserName.Text;
        Session["password"] = txtPassword.Text;

        
        HttpCookie c = Request.Cookies["resultURL"];

        if (c == null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {

            Response.Redirect(c.Value);


        }

    }
}