
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class HobbiesEN
{
/**
 *
 */

private string name;





public virtual string Name {
        get { return name; } set { name = value;  }
}





public HobbiesEN()
{
}



public HobbiesEN(string name)
{
        this.init (name);
}


public HobbiesEN(HobbiesEN hobbies)
{
        this.init (hobbies.Name);
}

private void init (string name)
{
        this.Name = Name;
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
