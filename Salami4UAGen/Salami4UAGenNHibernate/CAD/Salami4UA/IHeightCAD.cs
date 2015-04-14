
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IHeightCAD
{
HeightEN ReadOIDDefault (int height);

int New_ (HeightEN height);

void Modify (HeightEN height);


void Destroy (int height);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN> DameTodaslasAlturas ();
}
}
