
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
public partial class PetsCEN
{
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameAnimalesPorUsuario (string usuario)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Pets_dameAnimalesPorUsuario) ENABLED START*/

        // Write here your custom code...


        System.Collections.Generic.IList < Salami4UAGenNHibernate.EN.Salami4UA.PetsEN > todosanimales = new PetsCEN ().DameTodosLosAnimales ();
        while (todosanimales.Count != 0) {
                todosanimales.RemoveAt (0);
        }

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                PetsCAD petcad = new PetsCAD (basic.session);
                UserCAD usuariocad = new UserCAD (basic.session);
                UserEN usuarioEN = usuariocad.ReadOIDDefault (usuario);

                foreach (String animal in usuarioEN.Pets) {
                        PetsEN p = new PetsEN ();
                        p.Name = animal;
                        todosanimales.Add (p);
                }
        }
        catch (Exception ex)
        {
                return null;
        }

        return todosanimales;

        /*PROTECTED REGION END*/
}
}
}
