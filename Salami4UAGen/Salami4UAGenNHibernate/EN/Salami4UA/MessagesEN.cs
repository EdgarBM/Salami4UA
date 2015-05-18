
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class MessagesEN
{
/**
 *
 */

private int id;

/**
 *
 */

private string message;

/**
 *
 */

private Salami4UAGenNHibernate.EN.Salami4UA.UserEN userOrigen;

/**
 *
 */

private Salami4UAGenNHibernate.EN.Salami4UA.UserEN userDestino;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Message {
        get { return message; } set { message = value;  }
}


public virtual Salami4UAGenNHibernate.EN.Salami4UA.UserEN UserOrigen {
        get { return userOrigen; } set { userOrigen = value;  }
}


public virtual Salami4UAGenNHibernate.EN.Salami4UA.UserEN UserDestino {
        get { return userDestino; } set { userDestino = value;  }
}





public MessagesEN()
{
}



public MessagesEN(int id, string message, Salami4UAGenNHibernate.EN.Salami4UA.UserEN userOrigen, Salami4UAGenNHibernate.EN.Salami4UA.UserEN userDestino)
{
        this.init (id, message, userOrigen, userDestino);
}


public MessagesEN(MessagesEN messages)
{
        this.init (messages.Id, messages.Message, messages.UserOrigen, messages.UserDestino);
}

private void init (int id, string message, Salami4UAGenNHibernate.EN.Salami4UA.UserEN userOrigen, Salami4UAGenNHibernate.EN.Salami4UA.UserEN userDestino)
{
        this.Id = Id;


        this.Message = message;

        this.UserOrigen = userOrigen;

        this.UserDestino = userDestino;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MessagesEN t = obj as MessagesEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
