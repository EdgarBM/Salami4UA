
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IMessagesCAD
{
MessagesEN ReadOIDDefault (int Id);

int New_ (MessagesEN messages);

void Modify (MessagesEN messages);


void Destroy (int Id);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesEnviadosPorUsuario (string nick);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesRecibidosPorUsuario (string nick);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesEntreUsuarios (string nickOrigen, string nickDestino);
}
}
