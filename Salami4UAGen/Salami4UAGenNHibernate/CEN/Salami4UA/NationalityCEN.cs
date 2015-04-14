

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
public partial class NationalityCEN
{
private INationalityCAD _INationalityCAD;

public NationalityCEN()
{
        this._INationalityCAD = new NationalityCAD ();
}

public NationalityCEN(INationalityCAD _INationalityCAD)
{
        this._INationalityCAD = _INationalityCAD;
}

public INationalityCAD get_INationalityCAD ()
{
        return this._INationalityCAD;
}

public string New_ (string p_Name)
{
        NationalityEN nationalityEN = null;
        string oid;

        //Initialized NationalityEN
        nationalityEN = new NationalityEN ();
        nationalityEN.Name = p_Name;

        //Call to NationalityCAD

        oid = _INationalityCAD.New_ (nationalityEN);
        return oid;
}

public void Modify (string p_Nationality_OID)
{
        NationalityEN nationalityEN = null;

        //Initialized NationalityEN
        nationalityEN = new NationalityEN ();
        nationalityEN.Name = p_Nationality_OID;
        //Call to NationalityCAD

        _INationalityCAD.Modify (nationalityEN);
}

public void Destroy (string Name)
{
        _INationalityCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN> DameTodaslasNacionalidades ()
{
        return _INationalityCAD.DameTodaslasNacionalidades ();
}
}
}
