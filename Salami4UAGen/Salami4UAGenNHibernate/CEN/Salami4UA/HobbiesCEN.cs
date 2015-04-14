

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
public partial class HobbiesCEN
{
private IHobbiesCAD _IHobbiesCAD;

public HobbiesCEN()
{
        this._IHobbiesCAD = new HobbiesCAD ();
}

public HobbiesCEN(IHobbiesCAD _IHobbiesCAD)
{
        this._IHobbiesCAD = _IHobbiesCAD;
}

public IHobbiesCAD get_IHobbiesCAD ()
{
        return this._IHobbiesCAD;
}

public string New_ (string p_Name)
{
        HobbiesEN hobbiesEN = null;
        string oid;

        //Initialized HobbiesEN
        hobbiesEN = new HobbiesEN ();
        hobbiesEN.Name = p_Name;

        //Call to HobbiesCAD

        oid = _IHobbiesCAD.New_ (hobbiesEN);
        return oid;
}

public void Modify (string p_Hobbies_OID)
{
        HobbiesEN hobbiesEN = null;

        //Initialized HobbiesEN
        hobbiesEN = new HobbiesEN ();
        hobbiesEN.Name = p_Hobbies_OID;
        //Call to HobbiesCAD

        _IHobbiesCAD.Modify (hobbiesEN);
}

public void Destroy (string Name)
{
        _IHobbiesCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> DameTodosLosHobbies ()
{
        return _IHobbiesCAD.DameTodosLosHobbies ();
}
}
}
