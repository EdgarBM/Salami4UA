
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface ICaracteristicaCAD
{
CaracteristicaEN ReadOIDDefault (string Name);

string New_ (CaracteristicaEN caracteristica);

void Modify (CaracteristicaEN caracteristica);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicaEN> DameTodasLasCaracteristicas ();
}
}
