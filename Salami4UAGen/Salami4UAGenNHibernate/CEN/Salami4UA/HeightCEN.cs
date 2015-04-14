

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
public partial class HeightCEN
{
private IHeightCAD _IHeightCAD;

public HeightCEN()
{
        this._IHeightCAD = new HeightCAD ();
}

public HeightCEN(IHeightCAD _IHeightCAD)
{
        this._IHeightCAD = _IHeightCAD;
}

public IHeightCAD get_IHeightCAD ()
{
        return this._IHeightCAD;
}

public int New_ (int p_height)
{
        HeightEN heightEN = null;
        int oid;

        //Initialized HeightEN
        heightEN = new HeightEN ();
        heightEN.Height = p_height;

        //Call to HeightCAD

        oid = _IHeightCAD.New_ (heightEN);
        return oid;
}

public void Modify (int p_Height_OID)
{
        HeightEN heightEN = null;

        //Initialized HeightEN
        heightEN = new HeightEN ();
        heightEN.Height = p_Height_OID;
        //Call to HeightCAD

        _IHeightCAD.Modify (heightEN);
}

public void Destroy (int height)
{
        _IHeightCAD.Destroy (height);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN> DameTodaslasAlturas ()
{
        return _IHeightCAD.DameTodaslasAlturas ();
}
}
}
