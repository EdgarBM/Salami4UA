
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IPetsCAD
{
PetsEN ReadOIDDefault (string Name);

string New_ (PetsEN pets);

void Modify (PetsEN pets);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameTodosLosAnimales ();


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameAnimalesPorUsuario (Salami4UAGenNHibernate.EN.Salami4UA.UserEN usuario);
}
}
