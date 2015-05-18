

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
public partial class CineCEN
{
private ICineCAD _ICineCAD;

public CineCEN()
{
        this._ICineCAD = new CineCAD ();
}

public CineCEN(ICineCAD _ICineCAD)
{
        this._ICineCAD = _ICineCAD;
}

public ICineCAD get_ICineCAD ()
{
        return this._ICineCAD;
}

public string New_ (string p_Name)
{
        CineEN cineEN = null;
        string oid;

        //Initialized CineEN
        cineEN = new CineEN ();
        cineEN.Name = p_Name;

        //Call to CineCAD

        oid = _ICineCAD.New_ (cineEN);
        return oid;
}

public void Modify (string p_Cine_OID)
{
        CineEN cineEN = null;

        //Initialized CineEN
        cineEN = new CineEN ();
        cineEN.Name = p_Cine_OID;
        //Call to CineCAD

        _ICineCAD.Modify (cineEN);
}

public void Destroy (string Name)
{
        _ICineCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CineEN> DameTodosLosGenerosCine ()
{
        return _ICineCAD.DameTodosLosGenerosCine ();
}
}
}
