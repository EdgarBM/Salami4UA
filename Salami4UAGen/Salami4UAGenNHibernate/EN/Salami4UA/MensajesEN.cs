
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class MensajesEN
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

private Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN userOrigen;

/**
 *
 */

private Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN userDestino;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Message {
        get { return message; } set { message = value;  }
}


public virtual Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN UserOrigen {
        get { return userOrigen; } set { userOrigen = value;  }
}


public virtual Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN UserDestino {
        get { return userDestino; } set { userDestino = value;  }
}





public MensajesEN()
{
}



public MensajesEN(int id, string message, Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN userOrigen, Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN userDestino)
{
        this.init (id, message, userOrigen, userDestino);
}


public MensajesEN(MensajesEN mensajes)
{
        this.init (mensajes.Id, mensajes.Message, mensajes.UserOrigen, mensajes.UserDestino);
}

private void init (int id, string message, Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN userOrigen, Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN userDestino)
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
        MensajesEN t = obj as MensajesEN;
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
