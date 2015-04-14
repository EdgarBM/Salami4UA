
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class HeightEN
{
/**
 *
 */

private int height;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user;





public virtual int Height {
        get { return height; } set { height = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> User {
        get { return user; } set { user = value;  }
}





public HeightEN()
{
        user = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
}



public HeightEN(int height, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user)
{
        this.init (height, user);
}


public HeightEN(HeightEN height)
{
        this.init (height.Height, height.User);
}

private void init (int height, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user)
{
        this.Height = height;


        this.User = user;
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
