
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class NationalityEN
{
/**
 *
 */

private string name;





public virtual string Name {
        get { return name; } set { name = value;  }
}





public NationalityEN()
{
}



public NationalityEN(string name)
{
        this.init (name);
}


public NationalityEN(NationalityEN nationality)
{
        this.init (nationality.Name);
}

private void init (string name)
{
        this.Name = Name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NationalityEN t = obj as NationalityEN;
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
