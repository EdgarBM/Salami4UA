
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
public partial class MusicalTastesCEN
{
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> DameGustosMusicalesPorUsuario (string nickname)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_MusicalTastes_dameGustosMusicalesPorUsuario) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> todoMusica = new MusicalTastesCEN ().DameTodosLosGustosMusicales ();
        while (todoMusica.Count != 0) {
                todoMusica.RemoveAt (0);
        }

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                MusicalTastesCAD musicaCAD = new MusicalTastesCAD (basic.session);
                UserCAD usuarioCAD = new UserCAD (basic.session);
                UserEN usuarioEN = usuarioCAD.ReadOIDDefault (nickname);

                foreach (MusicalTastesEN musica in usuarioEN.MusicalTastes) {
                        todoMusica.Add (musica);
                }
        }
        catch (Exception ex)
        {
                return null;
        }

        return todoMusica;

        /*PROTECTED REGION END*/
}
}
}
