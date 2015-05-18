
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
public void ModificarPersonasALasQueHasBloqueado (string p_oid, System.Collections.Generic.IList<string> personasALasQueHasBloqueado)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_modificarPersonasALasQueHasBloqueado_customized) START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nickname = p_oid;
        usuarioEN.PersonasALasQueHasBloqueado = personasALasQueHasBloqueado;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarPersonasALasQueHasBloqueado (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
