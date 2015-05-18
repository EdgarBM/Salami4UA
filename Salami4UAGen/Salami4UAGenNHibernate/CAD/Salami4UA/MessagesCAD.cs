
using System;
using System.Text;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.Exceptions;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial class MessagesCAD : BasicCAD, IMessagesCAD
{
public MessagesCAD() : base ()
{
}

public MessagesCAD(ISession sessionAux) : base (sessionAux)
{
}



public MessagesEN ReadOIDDefault (int Id)
{
        MessagesEN messagesEN = null;

        try
        {
                SessionInitializeTransaction ();
                messagesEN = (MessagesEN)session.Get (typeof(MessagesEN), Id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return messagesEN;
}


public int New_ (MessagesEN messages)
{
        try
        {
                SessionInitializeTransaction ();
                if (messages.UserOrigen != null) {
                        messages.UserOrigen = (Salami4UAGenNHibernate.EN.Salami4UA.UserEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.UserEN), messages.UserOrigen.Nickname);

                        messages.UserOrigen.MessagesEnviados.Add (messages);
                }
                if (messages.UserDestino != null) {
                        messages.UserDestino = (Salami4UAGenNHibernate.EN.Salami4UA.UserEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.UserEN), messages.UserDestino.Nickname);

                        messages.UserDestino.MessagesRecibidos.Add (messages);
                }

                session.Save (messages);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return messages.Id;
}

public void Modify (MessagesEN messages)
{
        try
        {
                SessionInitializeTransaction ();
                MessagesEN messagesEN = (MessagesEN)session.Load (typeof(MessagesEN), messages.Id);

                messagesEN.Message = messages.Message;

                session.Update (messagesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int Id)
{
        try
        {
                SessionInitializeTransaction ();
                MessagesEN messagesEN = (MessagesEN)session.Load (typeof(MessagesEN), Id);
                session.Delete (messagesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesEnviadosPorUsuario (string nick)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MessagesEN self where FROM MessagesEN m WHERE m.UserOrigen.Nickname = :nick";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MessagesENdameTodosLosMensajesEnviadosPorUsuarioHQL");
                query.SetParameter ("nick", nick);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesRecibidosPorUsuario (string nick)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MessagesEN self where FROM MessagesEN m WHERE m.UserDestino.Nickname = :nick";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MessagesENdameTodosLosMensajesRecibidosPorUsuarioHQL");
                query.SetParameter ("nick", nick);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> DameTodosLosMensajesEntreUsuarios (string nickOrigen, string nickDestino)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MessagesEN self where FROM MessagesEN m WHERE m.UserOrigen.Nickname = :nickOrigen AND m.UserDestino.Nickname = :nickDestino";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MessagesENdameTodosLosMensajesEntreUsuariosHQL");
                query.SetParameter ("nickOrigen", nickOrigen);
                query.SetParameter ("nickDestino", nickDestino);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MessagesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
