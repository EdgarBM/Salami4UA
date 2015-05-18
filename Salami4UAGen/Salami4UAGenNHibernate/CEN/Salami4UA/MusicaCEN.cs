

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
public partial class MusicaCEN
{
private IMusicaCAD _IMusicaCAD;

public MusicaCEN()
{
        this._IMusicaCAD = new MusicaCAD ();
}

public MusicaCEN(IMusicaCAD _IMusicaCAD)
{
        this._IMusicaCAD = _IMusicaCAD;
}

public IMusicaCAD get_IMusicaCAD ()
{
        return this._IMusicaCAD;
}

public string New_ (string p_Name)
{
        MusicaEN musicaEN = null;
        string oid;

        //Initialized MusicaEN
        musicaEN = new MusicaEN ();
        musicaEN.Name = p_Name;

        //Call to MusicaCAD

        oid = _IMusicaCAD.New_ (musicaEN);
        return oid;
}

public void Modify (string p_Musica_OID)
{
        MusicaEN musicaEN = null;

        //Initialized MusicaEN
        musicaEN = new MusicaEN ();
        musicaEN.Name = p_Musica_OID;
        //Call to MusicaCAD

        _IMusicaCAD.Modify (musicaEN);
}

public void Destroy (string Name)
{
        _IMusicaCAD.Destroy (Name);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicaEN> DameTodosLosGustosMusicales ()
{
        return _IMusicaCAD.DameTodosLosGustosMusicales ();
}
}
}
