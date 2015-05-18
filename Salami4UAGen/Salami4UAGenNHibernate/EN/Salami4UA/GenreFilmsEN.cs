
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class GenreFilmsEN
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





public GenreFilmsEN()
{
        user = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
}



public GenreFilmsEN(string name, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> user)
{
        this.init (name, user);
}


public GenreFilmsEN(GenreFilmsEN genreFilms)
{
        this.init (genreFilms.Name, genreFilms.User);
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
        GenreFilmsEN t = obj as GenreFilmsEN;
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
