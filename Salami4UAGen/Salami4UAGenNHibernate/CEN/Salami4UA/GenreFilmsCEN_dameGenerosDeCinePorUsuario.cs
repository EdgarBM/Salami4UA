
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
public partial class GenreFilmsCEN
{
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> DameGenerosDeCinePorUsuario (string nickname)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_GenreFilms_dameGenerosDeCinePorUsuario) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> todosCines = new GenreFilmsCEN ().DameTodosLosGenerosCine ();
        while (todosCines.Count != 0) {
                todosCines.RemoveAt (0);
        }

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                GenreFilmsCAD cineCAD = new GenreFilmsCAD (basic.session);
                UserCAD usuarioCAD = new UserCAD (basic.session);
                UserEN usuarioEN = usuarioCAD.ReadOIDDefault (nickname);

                foreach (GenreFilmsEN cine in usuarioEN.GenreFilms) {
                        todosCines.Add (cine);
                }
        }
        catch (Exception ex)
        {
                return null;
        }

        return todosCines;

        /*PROTECTED REGION END*/
}
}
}
