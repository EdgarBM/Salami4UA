using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Salami4UAGenNHibernate.CEN.Salami4UA;

namespace WebApplication1
{
    public partial class DesbloquearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("~/Account/Login.aspx");
            }

            else
            {
                String nick = HttpContext.Current.Request.Url.AbsolutePath.Replace("/DesbloquearUsuario.aspx", "");

                try
                {
                    nick = nick.TrimStart('/');
                }
                catch (Exception ex) { }

                LabelBloqueo.Text = "Are you sure that you want to unblock " + nick + " and allow to see your profile, send messages and send pinchitos?";
            }
        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {
            String nick = Session["Login"].ToString();
            String Nickname = HttpContext.Current.Request.Url.AbsolutePath.Replace("/DesbloquearUsuario.aspx", "");
            try
            {
                Nickname = Nickname.TrimStart('/');
            }
            catch (Exception ex) { }

            UsuarioCEN usuario = new UsuarioCEN();

            IList<string> listaUsers = usuario.DamePersonasQueTeHanBloqueado(Nickname); // Lista para el usuario bloqueado
            IList<string> nuevaListaBloqueados = usuario.DamePersonasALasQUeHasBloqueado(nick); // Lista para el usuario que bloquea

            if (listaUsers.Contains(nick) && nuevaListaBloqueados.Contains(Nickname))
            {
                listaUsers.Remove(nick); // Persona que bloquea
                nuevaListaBloqueados.Remove(Nickname); // Persona bloqueada
                usuario.ModificarPersonasQueTeHanBloqueado(Nickname, listaUsers);
                usuario.ModificarPersonasALasQueHasBloqueado(nick, nuevaListaBloqueados);
            }

            Response.Redirect("~/VerUsuariosBloqueados.aspx");
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VerUsuariosBloqueados.aspx");
        }
    }
}