
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
public void ModificarMensajesRecibidos (string p_oid, System.Collections.Generic.IList<string> mensajesRecibidos)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_modificarMensajesRecibidos_customized) START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nickname = p_oid;
        usuarioEN.MensajesRecibidos = mensajesRecibidos;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarMensajesRecibidos (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
