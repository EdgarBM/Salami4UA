using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace WebApplication1.Account
{
    public partial class Login : System.Web.UI.Page
    {
        private String admin = "admin";
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            ForgotPasswordLink.NavigateUrl = "~/ForgotPassword.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            Session.Clear();
        }

        protected void LoginButton_Click(object LoginButton, EventArgs e)
        {
            try
            {
                UsuarioCEN usuario = new UsuarioCEN();
                
                if (usuario.ValidationUser(LoginUser.UserName, LoginUser.Password))
                {
                    //Check if it is the admin user
                    try{
                        IList<UsuarioEN> usu = usuario.DameUsuarioPorNickname(LoginUser.UserName);
                    
                        UsuarioEN u = usu.ElementAt(0);
                        if(String.Compare(u.Nickname, admin) == 0){
                            ErrorValidacion.Text = "";
                            Session["login"] = LoginUser.UserName;
                            Response.Redirect("~/Admin.aspx");
                        }


                    }catch(Exception){}


                    
                    ErrorValidacion.Text = "";
                    Session["login"] = LoginUser.UserName;
                    Response.Redirect("~/Default.aspx");
                }

                else
                {
                    ErrorValidacion.Text = "The nickname or the password are wrong.";
                }



            }
            catch (Exception ex)
            {
                ErrorValidacion.Text = "The nickname or the password are wrong.";
            }
        }

        protected void change_password(object changeButton, EventArgs e)
        {
            Response.Redirect("~/ChangePassword.aspx");
        }

    }
}
