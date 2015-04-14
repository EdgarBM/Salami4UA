
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IHobbiesCAD
{
HobbiesEN ReadOIDDefault (string Name);

string New_ (HobbiesEN hobbies);

void Modify (HobbiesEN hobbies);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> DameTodosLosHobbies ();
}
}
