
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface ICharacteristicFeaturesCAD
{
CharacteristicFeaturesEN ReadOIDDefault (string Name);

string New_ (CharacteristicFeaturesEN characteristicFeatures);

void Modify (CharacteristicFeaturesEN characteristicFeatures);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> DameTodasLasCaracteristicas ();
}
}
