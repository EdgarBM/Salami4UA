
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
public void AddValidation (string nombre, string validationCode)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_User_addValidation) ENABLED START*/

        // Write here your custom code...

        UserEN usuario = _IUserCAD.ReadOIDDefault (nombre);

        usuario.ValidationCode = validationCode;

        _IUserCAD.Modify (usuario);

        /*PROTECTED REGION END*/
}
}
}
