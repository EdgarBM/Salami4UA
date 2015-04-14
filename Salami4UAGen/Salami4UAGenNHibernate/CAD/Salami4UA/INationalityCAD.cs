
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface INationalityCAD
{
NationalityEN ReadOIDDefault (string Name);

string New_ (NationalityEN nationality);

void Modify (NationalityEN nationality);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN> DameTodaslasNacionalidades ();
}
}
