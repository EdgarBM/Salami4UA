

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
public partial class CaracteristicaCEN
{
private ICaracteristicaCAD _ICaracteristicaCAD;

public CaracteristicaCEN()
{
        this._ICaracteristicaCAD = new CaracteristicaCAD ();
}

public CaracteristicaCEN(ICaracteristicaCAD _ICaracteristicaCAD)
{
        this._ICaracteristicaCAD = _ICaracteristicaCAD;
}

public ICaracteristicaCAD get_ICaracteristicaCAD ()
{
        return this._ICaracteristicaCAD;
}

public string New_ (string p_Name)
{
        CaracteristicaEN caracteristicaEN = null;
        string oid;

        //Initialized CaracteristicaEN
        caracteristicaEN = new CaracteristicaEN ();
        caracteristicaEN.Name = p_Name;

        //Call to CaracteristicaCAD

        oid = _ICaracteristicaCAD.New_ (caracteristicaEN);
        return oid;
}

public void Modify (string p_Caracteristica_OID)
{
        CaracteristicaEN caracteristicaEN = null;

        //Initialized CaracteristicaEN
        caracteristicaEN = new CaracteristicaEN ();
        caracteristicaEN.Name = p_Caracteristica_OID;
        //Call to CaracteristicaCAD

        _ICaracteristicaCAD.Modify (caracteristicaEN);
}

public void Destroy (string Name)
{
        _ICaracteristicaCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicaEN> DameTodasLasCaracteristicas ()
{
        return _ICaracteristicaCAD.DameTodasLasCaracteristicas ();
}
}
}
