
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;
using System.Collections;
using System.Collections.Generic;

namespace Salami4UAGenNHibernate.CEN.Salami4UA
{
public partial class UsuarioCEN
{
public System.Collections.Generic.IList<string> DamePinchitosRecibidosPorUsuario (string p_oid)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_damePinchitosRecibidosPorUsuario) ENABLED START*/

        // Write here your custom code...

        BasicCP basic = new BasicCP ();

        IList<string> pinchitos = new List<string>();
        try
        {
                basic.SessionInitializeTransaction ();

                UsuarioCAD usuarioCAD = new UsuarioCAD (basic.session);
                UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault (p_oid);

                foreach (string m in usuarioEN.PinchitosRecibidos) {
                        pinchitos.Add (m);
                }

                basic.SessionClose ();
        }
        catch (Exception ex)
        {
                return null;
        }

        return pinchitos;
        /*PROTECTED REGION END*/
}
}
}
