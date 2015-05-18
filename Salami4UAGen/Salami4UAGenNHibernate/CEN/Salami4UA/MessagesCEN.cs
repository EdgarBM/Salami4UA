

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace Salami4UAGenNHibernate.CEN.Salami4UA
{
public partial class MessagesCEN
{
private IMessagesCAD _IMessagesCAD;

public MessagesCEN()
{
        this._IMessagesCAD = new MessagesCAD ();
}

public MessagesCEN(IMessagesCAD _IMessagesCAD)
{
        this._IMessagesCAD = _IMessagesCAD;
}

public IMessagesCAD get_IMessagesCAD ()
{
        return this._IMessagesCAD;
}

public int New_ (string p_Message, string p_userOrigen, string p_userDestino)
{
        MessagesEN messagesEN = null;
        int oid;

        //Initialized MessagesEN
        messagesEN = new MessagesEN ();
        messagesEN.Message = p_Message;


        if (p_userOrigen != null) {
                messagesEN.UserOrigen = new Salami4UAGenNHibernate.EN.Salami4UA.UserEN ();
                messagesEN.UserOrigen.Nickname = p_userOrigen;
        }


        if (p_userDestino != null) {
                messagesEN.UserDestino = new Salami4UAGenNHibernate.EN.Salami4UA.UserEN ();
                messagesEN.UserDestino.Nickname = p_userDestino;
        }

        //Call to MessagesCAD

        oid = _IMessagesCAD.New_ (messagesEN);
        return oid;
}

public void Modify (int p_Messages_OID, string p_Message)
{
        MessagesEN messagesEN = null;

        //Initialized MessagesEN
        messagesEN = new MessagesEN ();
        messagesEN.Id = p_Messages_OID;
        messagesEN.Message = p_Message;
        //Call to MessagesCAD

        _IMessagesCAD.Modify (messagesEN);
}

public void Destroy (int Id)
{
        _IMessagesCAD.Destroy (Id);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesEnviadosPorUsuario (string nick)
{
        return _IMessagesCAD.DameTodosLosMensajesEnviadosPorUsuario (nick);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesRecibidosPorUsuario (string nick)
{
        return _IMessagesCAD.DameTodosLosMensajesRecibidosPorUsuario (nick);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesEntreUsuarios (string nickOrigen, string nickDestino)
{
        return _IMessagesCAD.DameTodosLosMensajesEntreUsuarios (nickOrigen, nickDestino);
}
}
}
