

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
public partial class MusicalTastesCEN
{
private IMusicalTastesCAD _IMusicalTastesCAD;

public MusicalTastesCEN()
{
        this._IMusicalTastesCAD = new MusicalTastesCAD ();
}

public MusicalTastesCEN(IMusicalTastesCAD _IMusicalTastesCAD)
{
        this._IMusicalTastesCAD = _IMusicalTastesCAD;
}

public IMusicalTastesCAD get_IMusicalTastesCAD ()
{
        return this._IMusicalTastesCAD;
}

public string New_ (string p_Name)
{
        MusicalTastesEN musicalTastesEN = null;
        string oid;

        //Initialized MusicalTastesEN
        musicalTastesEN = new MusicalTastesEN ();
        musicalTastesEN.Name = p_Name;

        //Call to MusicalTastesCAD

        oid = _IMusicalTastesCAD.New_ (musicalTastesEN);
        return oid;
}

public void Modify (string p_MusicalTastes_OID)
{
        MusicalTastesEN musicalTastesEN = null;

        //Initialized MusicalTastesEN
        musicalTastesEN = new MusicalTastesEN ();
        musicalTastesEN.Name = p_MusicalTastes_OID;
        //Call to MusicalTastesCAD

        _IMusicalTastesCAD.Modify (musicalTastesEN);
}

public void Destroy (string Name)
{
        _IMusicalTastesCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> DameTodosLosGustosMusicales ()
{
        return _IMusicalTastesCAD.DameTodosLosGustosMusicales ();
}
}
}
