using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class NotificacionBloqueo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("~/Account/Login.aspx");
            }

            else
            {
                String nick = HttpContext.Current.Request.Url.AbsolutePath.Replace("/NotificacionBloqueo.aspx", "");

                try
                {
                    nick = nick.TrimStart('/');
                }
                catch (Exception ex) { }

                LabelBloqueo.Text = "You can not see the profile, send messages or send pinchitos to " + nick + " because you have been blocked";
            }
        }
    }
}