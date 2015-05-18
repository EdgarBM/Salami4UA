
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface ICineCAD
{
CineEN ReadOIDDefault (string Name);

string New_ (CineEN cine);

void Modify (CineEN cine);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CineEN> DameTodosLosGenerosCine ();
}
}
