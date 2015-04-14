

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
public partial class SportsCEN
{
private ISportsCAD _ISportsCAD;

public SportsCEN()
{
        this._ISportsCAD = new SportsCAD ();
}

public SportsCEN(ISportsCAD _ISportsCAD)
{
        this._ISportsCAD = _ISportsCAD;
}

public ISportsCAD get_ISportsCAD ()
{
        return this._ISportsCAD;
}

public string New_ (string p_Name)
{
        SportsEN sportsEN = null;
        string oid;

        //Initialized SportsEN
        sportsEN = new SportsEN ();
        sportsEN.Name = p_Name;

        //Call to SportsCAD

        oid = _ISportsCAD.New_ (sportsEN);
        return oid;
}

public void Modify (string p_Sports_OID)
{
        SportsEN sportsEN = null;

        //Initialized SportsEN
        sportsEN = new SportsEN ();
        sportsEN.Name = p_Sports_OID;
        //Call to SportsCAD

        _ISportsCAD.Modify (sportsEN);
}

public void Destroy (string Name)
{
        _ISportsCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> DameTodosLosDeportes ()
{
        return _ISportsCAD.DameTodosLosDeportes ();
}
}
}
