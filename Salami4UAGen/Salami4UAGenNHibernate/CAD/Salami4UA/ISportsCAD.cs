
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface ISportsCAD
{
SportsEN ReadOIDDefault (string Name);

string New_ (SportsEN sports);

void Modify (SportsEN sports);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> DameTodosLosDeportes ();
}
}
