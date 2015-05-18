
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace Salami4UAGenNHibernate.CEN.Salami4UA
{
public partial class UsuarioCEN
{
public System.Collections.Generic.IList<string> DamePersonasQueTeHanBloqueado (string p_oid)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_damePersonasQueTeHanBloqueado) ENABLED START*/

        // Write here your custom code...

        BasicCP basic = new BasicCP();

        try
        {
            basic.SessionInitializeTransaction();

            UsuarioCAD usuarioCAD = new UsuarioCAD(basic.session);
            UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault(p_oid);

            return usuarioEN.PersonasQueTeHanBloqueado;
        }
        catch (Exception ex)
        {
            return null;
        }

        /*PROTECTED REGION END*/
}
}
}
