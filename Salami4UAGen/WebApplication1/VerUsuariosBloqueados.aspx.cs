using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace WebApplication1
{
    public partial class VerUsuariosBloqueados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                try
                {
                    String nick = Session["login"].ToString();
                    UsuarioCEN usuarioCEN = new UsuarioCEN();

                    IList<string> usuariosString = usuarioCEN.DamePersonasALasQUeHasBloqueado(nick);
                    IList<UsuarioEN> usuarios = new List<UsuarioEN>();

                    foreach (String s in usuariosString)
                    {
                        UsuarioEN usuarioEN = usuarioCEN.ReadOID(s);
                        usuarios.Add(usuarioEN);
                    }

                    BlockedUsersGridView.DataSource = usuarios;
                    BlockedUsersGridView.DataBind();
                }
                catch (Exception ex)
                { }
            }

            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        public string ChopString(string s)
        {
            try
            {
                s = s.Substring(0, 10);
            }
            catch (Exception) { }

            return s;
        }

        /*protected void DesbloquearUsuario_Click(object sender, EventArgs e)
        {
            String nick = Session["Login"].ToString();
            UsuarioCEN usuario = new UsuarioCEN();

            IList<string> listaUsers = usuario.DamePersonasQueTeHanBloqueado(Nickname.Text); // Lista para el usuario bloqueado
            IList<string> nuevaListaBloqueados = usuario.DamePersonasALasQUeHasBloqueado(nick); // Lista para el usuario que bloquea

            if (listaUsers.Contains(nick) && nuevaListaBloqueados.Contains(Nickname.Text))
            {
                listaUsers.Remove(nick); // Persona que bloquea
                nuevaListaBloqueados.Remove(Nickname.Text); // Persona bloqueada
                usuario.ModificarPersonasQueTeHanBloqueado(Nickname.Text, listaUsers);
                usuario.ModificarPersonasALasQueHasBloqueado(nick, nuevaListaBloqueados);
            }
        }*/

    }
}