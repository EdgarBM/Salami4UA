
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class CareerEN
{
/**
 *
 */

private string name;





public virtual string Name {
        get { return name; } set { name = value;  }
}





public CareerEN()
{
}



public CareerEN(string name)
{
        this.init (name);
}


public CareerEN(CareerEN career)
{
        this.init (career.Name);
}

private void init (string name)
{
        this.Name = Name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CareerEN t = obj as CareerEN;
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
