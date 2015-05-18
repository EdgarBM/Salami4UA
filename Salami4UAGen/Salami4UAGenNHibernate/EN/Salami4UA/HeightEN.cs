
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class HeightEN
{
/**
 *
 */

private int height;





public virtual int Height {
        get { return height; } set { height = value;  }
}





public HeightEN()
{
}



public HeightEN(int height)
{
        this.init (height);
}


public HeightEN(HeightEN height)
{
        this.init (height.Height);
}

private void init (int height)
{
        this.Height = height;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        HeightEN t = obj as HeightEN;
        if (t == null)
                return false;
        if (Height.Equals (t.Height))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Height.GetHashCode ();
        return hash;
}
}
}
