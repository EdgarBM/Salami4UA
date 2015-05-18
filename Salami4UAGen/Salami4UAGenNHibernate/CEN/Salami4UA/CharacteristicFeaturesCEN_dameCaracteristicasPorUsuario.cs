
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
public partial class CharacteristicFeaturesCEN
{
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> DameCaracteristicasPorUsuario (string nickname)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_CharacteristicFeatures_dameCaracteristicasPorUsuario) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> todascaracteristicas = new CharacteristicFeaturesCEN ().DameTodasLasCaracteristicas ();
        while (todascaracteristicas.Count != 0) {
                todascaracteristicas.RemoveAt (0);
        }

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                CharacteristicFeaturesCAD caracteristicaCAD = new CharacteristicFeaturesCAD (basic.session);
                UserCAD usuarioCAD = new UserCAD (basic.session);
                UserEN usuarioEN = usuarioCAD.ReadOIDDefault (nickname);

                foreach (String caracteristica in usuarioEN.Characteristics) {
                        CharacteristicFeaturesEN c = new CharacteristicFeaturesEN ();
                        c.Name = caracteristica;
                        todascaracteristicas.Add (c);
                }
        }
        catch (Exception ex)
        {
                return null;
        }

        return todascaracteristicas;

        /*PROTECTED REGION END*/
}
}
}
