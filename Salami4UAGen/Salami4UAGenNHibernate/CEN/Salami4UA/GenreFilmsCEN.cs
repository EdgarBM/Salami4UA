

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace Salami4UAGenNHibernate.CEN.Salami4UA
{
public partial class GenreFilmsCEN
{
private IGenreFilmsCAD _IGenreFilmsCAD;

public GenreFilmsCEN()
{
        this._IGenreFilmsCAD = new GenreFilmsCAD ();
}

public GenreFilmsCEN(IGenreFilmsCAD _IGenreFilmsCAD)
{
        this._IGenreFilmsCAD = _IGenreFilmsCAD;
}

public IGenreFilmsCAD get_IGenreFilmsCAD ()
{
        return this._IGenreFilmsCAD;
}

public string New_ (string p_Name)
{
        GenreFilmsEN genreFilmsEN = null;
        string oid;

        //Initialized GenreFilmsEN
        genreFilmsEN = new GenreFilmsEN ();
        genreFilmsEN.Name = p_Name;

        //Call to GenreFilmsCAD

        oid = _IGenreFilmsCAD.New_ (genreFilmsEN);
        return oid;
}

public void Modify (string p_GenreFilms_OID)
{
        GenreFilmsEN genreFilmsEN = null;

        //Initialized GenreFilmsEN
        genreFilmsEN = new GenreFilmsEN ();
        genreFilmsEN.Name = p_GenreFilms_OID;
        //Call to GenreFilmsCAD

        _IGenreFilmsCAD.Modify (genreFilmsEN);
}

public void Destroy (string Name)
{
        _IGenreFilmsCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> DameTodosLosGenerosCine ()
{
        return _IGenreFilmsCAD.DameTodosLosGenerosCine ();
}
}
}
