
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IMusicalTastesCAD
{
MusicalTastesEN ReadOIDDefault (string Name);

string New_ (MusicalTastesEN musicalTastes);

void Modify (MusicalTastesEN musicalTastes);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> DameTodosLosGustosMusicales ();
}
}
