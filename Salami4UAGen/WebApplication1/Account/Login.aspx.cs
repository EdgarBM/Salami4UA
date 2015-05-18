using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            Session.Clear();
        }

        protected void LoginButton_Click(object LoginButton, EventArgs e)
        {
            try
            {
                Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN();
                

                if (usuario.ValidationUser(LoginUser.UserName, LoginUser.Password))
                {
                    
                    ErrorValidacion.Text = "";
                    Session["login"] = LoginUser.UserName;
                    Response.Redirect("~/Default.aspx");
                }

                else
                {
                    ErrorValidacion.Text = "The nickname and the password don't match";
                }



            }
            catch (Exception ex)
            {
            }
        }

        protected void change_password(object changeButton, EventArgs e)
        {
            Response.Redirect("~/ChangePassword.aspx");
        }

    }
}
