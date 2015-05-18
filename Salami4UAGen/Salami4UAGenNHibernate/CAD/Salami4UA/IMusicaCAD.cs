
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IMusicaCAD
{
MusicaEN ReadOIDDefault (string Name);

string New_ (MusicaEN musica);

void Modify (MusicaEN musica);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicaEN> DameTodosLosGustosMusicales ();
}
}
