
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
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNacionalidad (string nacionalidad)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_User_DameUsuarioPorNacionalidad) ENABLED START*/

        // Write here your custom code...



        UserCEN usuariocen = new UserCEN ();
        NationalityEN n = new NationalityEN ();

        n.Name = nacionalidad;

        return usuariocen.Pruebas(n);


        /*
         * System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> todosUsuarios = usuariocen.DameTodosLosUsuarios ();
         * System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> resultado = usuariocen.DameTodosLosUsuarios ();
         * while (resultado.Count != 0) {
         *      resultado.RemoveAt (0);
         * }
         *
         * foreach (UserEN usuario in todosUsuarios) {
         *      if (usuario.Nacionalidad.Name == nacionalidad) {
         *              resultado.Add (usuario);
         *      }
         * }
         *
         * return resultado;*/






        /*PROTECTED REGION END*/
}
}
}
