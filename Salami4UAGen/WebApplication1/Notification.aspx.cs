using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace WebApplication1
{
    public partial class Notification : System.Web.UI.Page
    {

        List<UsuarioEN> listaUsuariosMensajes;
        List<UsuarioEN> listaUsuariosPinchitos;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Login"] != null)
            {
                string user = (string)Session["login"];

                UsuarioCEN cen = new UsuarioCEN();

                listaUsuariosMensajes = new List<UsuarioEN>();
                listaUsuariosPinchitos = new List<UsuarioEN>();

                IList<string> mensajesRecibidos = cen.DameMensajesRecibidosPorUsuario(user);
                IList<string> pinchitosRecibidos = cen.DamePinchitosRecibidosPorUsuario(user);

                foreach (string nickname in mensajesRecibidos)
                {
                    listaUsuariosMensajes.Add(cen.DameUsuarioPorNickname(nickname)[0]);
                }

                foreach (string nickname in pinchitosRecibidos)
                {
                    listaUsuariosPinchitos.Add(cen.DameUsuarioPorNickname(nickname)[0]);
                }


                GridViewMensajes.DataSource = listaUsuariosMensajes;
                GridViewPinchitos.DataSource = listaUsuariosPinchitos;

                GridViewMensajes.DataBind();
                GridViewPinchitos.DataBind();
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
    }
}