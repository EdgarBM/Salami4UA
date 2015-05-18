
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
public partial class UserCEN
{
public bool CambiarPassword (string nick, string contrasenyaAntigua, string contrasenyaNueva)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_User_cambiarPassword) ENABLED START*/

        // Write here your custom code...

        Boolean ok = false;
        UserEN usuario = _IUserCAD.ReadOIDDefault (nick);

        if (usuario.Password == contrasenyaAntigua) {
                usuario.Password = contrasenyaNueva;
                ok = true;
        }

        return ok;

        /*PROTECTED REGION END*/
}
}
}
