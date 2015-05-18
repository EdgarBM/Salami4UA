using Salami4UAGenNHibernate.CEN.Salami4UA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool comprobarNotificaciones(string user)
        {
            
            UsuarioCEN cen = new UsuarioCEN();

            IList<string> mensajes = cen.DameMensajesRecibidosPorUsuario(user);
            if (mensajes.Count > 0)
                return true;

            IList<string> pinchitos = cen.DamePinchitosRecibidosPorUsuario(user);
            return (pinchitos.Count > 0);
            
        }
    }
}
