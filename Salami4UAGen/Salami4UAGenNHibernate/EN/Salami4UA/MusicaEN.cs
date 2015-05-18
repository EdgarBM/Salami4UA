
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class MusicaEN
{
/**
 *
 */

private string name;





public virtual string Name {
        get { return name; } set { name = value;  }
}





public MusicaEN()
{
}



public MusicaEN(string name)
{
        this.init (name);
}


public MusicaEN(MusicaEN musica)
{
        this.init (musica.Name);
}

private void init (string name)
{
        this.Name = Name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MusicaEN t = obj as MusicaEN;
        if (t == null)
                return false;
        if (Name.Equals (t.Name))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Name.GetHashCode ();
        return hash;
}
}
}
