
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IMusicasCAD
{
MusicasEN ReadOIDDefault (string Name);

string New_ (MusicasEN musicas);

void Modify (MusicasEN musicas);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicasEN> DameTodosLosGustosMusicales ();
}
}
