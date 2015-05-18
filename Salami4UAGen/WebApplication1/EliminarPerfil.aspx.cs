using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;
using Salami4UAGenNHibernate.Enumerated;
using Salami4UAGenNHibernate.Exceptions;
using Salami4UAGenNHibernate.Properties;
using Salami4UAGenNHibernate.Utils;

namespace WebApplication1
{
    public partial class EliminarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                String nick = Session["Login"].ToString();
                Username.Text = nick;
            }

            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {

            String nick = Session["Login"].ToString();
            Exception exp = null;
            bool passwordCorrecto = false;

            try
            {
                
                UsuarioCEN usuarioCEN = new UsuarioCEN();

                UsuarioCAD UsuarioCAD = new UsuarioCAD();
                UsuarioEN usuarioEN = UsuarioCAD.ReadOIDDefault(nick);

                if (usuarioCEN.ValidationUser(nick, Password.Text))
                {
                    passwordCorrecto = true;
                    usuarioCEN.Destroy(nick);
                    Session.Clear();
                }

                else
                {
                    ErrorEliminar.Text = "ERROR: The user and the password don't match";
                }

               
                
            }
            catch (Exception ex)
            {
                ErrorEliminar.Text = "ERROR: The user could not be deleted";
                exp = ex;
            }

            try
            {

                if (exp == null && passwordCorrecto)
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
            }
            catch (Exception ex)
            { }
          
        }
     }
 }
