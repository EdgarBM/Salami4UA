
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class PetsEN
{
/**
 *
 */

private string name;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user;





public virtual string Name {
        get { return name; } set { name = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> User {
        get { return user; } set { user = value;  }
}





public PetsEN()
{
        user = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
}



public PetsEN(string name, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user)
{
        this.init (name, user);
}


public PetsEN(PetsEN pets)
{
        this.init (pets.Name, pets.User);
}

private void init (string name, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user)
{
        this.Name = Name;


        this.User = user;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PetsEN t = obj as PetsEN;
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
