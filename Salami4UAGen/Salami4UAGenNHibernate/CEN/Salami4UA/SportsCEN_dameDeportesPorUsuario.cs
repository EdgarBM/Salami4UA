
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
public partial class SportsCEN
{
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> DameDeportesPorUsuario (string nickname)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Sports_dameDeportesPorUsuario) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> todoDeportes = new SportsCEN ().DameTodosLosDeportes ();
        while (todoDeportes.Count != 0) {
                todoDeportes.RemoveAt (0);
        }

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                SportsCAD musicaCAD = new SportsCAD (basic.session);
                UserCAD usuarioCAD = new UserCAD (basic.session);
                UserEN usuarioEN = usuarioCAD.ReadOIDDefault (nickname);

                foreach (SportsEN deporte in usuarioEN.Sports) {
                        todoDeportes.Add (deporte);
                }
        }
        catch (Exception ex)
        {
                return null;
        }

        return todoDeportes;

        /*PROTECTED REGION END*/
}
}
}
