
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface ICareerCAD
{
CareerEN ReadOIDDefault (string Name);

string New_ (CareerEN career);

void Modify (CareerEN career);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CareerEN> DameTodasLasCarreras ();
}
}
