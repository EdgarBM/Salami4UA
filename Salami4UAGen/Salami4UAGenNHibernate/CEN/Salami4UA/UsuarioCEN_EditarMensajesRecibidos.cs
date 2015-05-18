
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
public void EditarMensajesRecibidos (System.Collections.Generic.IList<string> mensajesNuevos)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_EditarMensajesRecibidos_customized) START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.MensajesNuevos = MensajesNuevos;
        //Call to UsuarioCAD

        _IUsuarioCAD.EditarMensajesRecibidos (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
