

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
public partial class CareerCEN
{
private ICareerCAD _ICareerCAD;

public CareerCEN()
{
        this._ICareerCAD = new CareerCAD ();
}

public CareerCEN(ICareerCAD _ICareerCAD)
{
        this._ICareerCAD = _ICareerCAD;
}

public ICareerCAD get_ICareerCAD ()
{
        return this._ICareerCAD;
}

public string New_ (string p_Name)
{
        CareerEN careerEN = null;
        string oid;

        //Initialized CareerEN
        careerEN = new CareerEN ();
        careerEN.Name = p_Name;

        //Call to CareerCAD

        oid = _ICareerCAD.New_ (careerEN);
        return oid;
}

public void Modify (string p_Career_OID)
{
        CareerEN careerEN = null;

        //Initialized CareerEN
        careerEN = new CareerEN ();
        careerEN.Name = p_Career_OID;
        //Call to CareerCAD

        _ICareerCAD.Modify (careerEN);
}

public void Destroy (string Name)
{
        _ICareerCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CareerEN> DameTodasLasCarreras ()
{
        return _ICareerCAD.DameTodasLasCarreras ();
}
}
}
