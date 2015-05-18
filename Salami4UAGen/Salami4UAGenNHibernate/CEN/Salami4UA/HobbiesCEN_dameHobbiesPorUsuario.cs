
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
public partial class HobbiesCEN
{
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> DameHobbiesPorUsuario (string nickname)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Hobbies_dameHobbiesPorUsuario) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> todosHobbies = new HobbiesCEN ().DameTodosLosHobbies ();
        while (todosHobbies.Count != 0) {
                todosHobbies.RemoveAt (0);
        }

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                HobbiesCAD hobbieCAD = new HobbiesCAD (basic.session);
                UserCAD usuarioCAD = new UserCAD (basic.session);
                UserEN usuarioEN = usuarioCAD.ReadOIDDefault (nickname);

                foreach (String hob in usuarioEN.Hobbies) {
                        HobbiesEN h = new HobbiesEN ();
                        h.Name = hob;
                        todosHobbies.Add (h);
                }
        }
        catch (Exception ex)
        {
                return null;
        }

        return todosHobbies;

        /*PROTECTED REGION END*/
}
}
}
