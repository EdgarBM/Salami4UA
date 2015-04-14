
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IGenreFilmsCAD
{
GenreFilmsEN ReadOIDDefault (string Name);

string New_ (GenreFilmsEN genreFilms);

void Modify (GenreFilmsEN genreFilms);


void Destroy (string Name);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> DameTodosLosGenerosCine ();
}
}
