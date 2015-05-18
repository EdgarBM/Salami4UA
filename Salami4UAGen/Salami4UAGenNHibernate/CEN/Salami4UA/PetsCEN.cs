

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
public partial class PetsCEN
{
private IPetsCAD _IPetsCAD;

public PetsCEN()
{
        this._IPetsCAD = new PetsCAD ();
}

public PetsCEN(IPetsCAD _IPetsCAD)
{
        this._IPetsCAD = _IPetsCAD;
}

public IPetsCAD get_IPetsCAD ()
{
        return this._IPetsCAD;
}

public string New_ (string p_Name)
{
        PetsEN petsEN = null;
        string oid;

        //Initialized PetsEN
        petsEN = new PetsEN ();
        petsEN.Name = p_Name;

        //Call to PetsCAD

        oid = _IPetsCAD.New_ (petsEN);
        return oid;
}

public void Modify (string p_Pets_OID)
{
        PetsEN petsEN = null;

        //Initialized PetsEN
        petsEN = new PetsEN ();
        petsEN.Name = p_Pets_OID;
        //Call to PetsCAD

        _IPetsCAD.Modify (petsEN);
}

public void Destroy (string Name)
{
        _IPetsCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameTodosLosAnimales ()
{
        return _IPetsCAD.DameTodosLosAnimales ();
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameAnimalesPorUsuario (Salami4UAGenNHibernate.EN.Salami4UA.UserEN usuario)
{
        return _IPetsCAD.DameAnimalesPorUsuario (usuario);
}
}
}
