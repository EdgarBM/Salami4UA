
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class HobbiesEN
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





public HobbiesEN()
{
        user = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
}



public HobbiesEN(string name, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user)
{
        this.init (name, user);
}


public HobbiesEN(HobbiesEN hobbies)
{
        this.init (hobbies.Name, hobbies.User);
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
        HobbiesEN t = obj as HobbiesEN;
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
