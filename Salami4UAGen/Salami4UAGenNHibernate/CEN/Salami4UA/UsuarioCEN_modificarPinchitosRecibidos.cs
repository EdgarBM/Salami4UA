
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
public void ModificarPinchitosRecibidos (string usuario_oid, System.Collections.Generic.IList<string> pinchitosRecibidos)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_modificarPinchitosRecibidos_customized) START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nickname = usuario_oid;
        usuarioEN.PinchitosRecibidos = pinchitosRecibidos;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarPinchitosRecibidos (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
