
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
public partial class MensajesCAD : BasicCAD, IMensajesCAD
{
public MensajesCAD() : base ()
{
}

public MensajesCAD(ISession sessionAux) : base (sessionAux)
{
}



public MensajesEN ReadOIDDefault (int Id)
{
        MensajesEN mensajesEN = null;

        try
        {
                SessionInitializeTransaction ();
                mensajesEN = (MensajesEN)session.Get (typeof(MensajesEN), Id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mensajesEN;
}


public int New_ (MensajesEN mensajes)
{
        try
        {
                SessionInitializeTransaction ();
                if (mensajes.UserOrigen != null) {
                        mensajes.UserOrigen = (Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN), mensajes.UserOrigen.Nickname);

                        mensajes.UserOrigen.MessagesEnviados.Add (mensajes);
                }
                if (mensajes.UserDestino != null) {
                        mensajes.UserDestino = (Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN), mensajes.UserDestino.Nickname);

                        mensajes.UserDestino.MessagesRecibidos.Add (mensajes);
                }

                session.Save (mensajes);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mensajes.Id;
}

public void Modify (MensajesEN mensajes)
{
        try
        {
                SessionInitializeTransaction ();
                MensajesEN mensajesEN = (MensajesEN)session.Load (typeof(MensajesEN), mensajes.Id);

                mensajesEN.Message = mensajes.Message;

                session.Update (mensajesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
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
                MensajesEN mensajesEN = (MensajesEN)session.Load (typeof(MensajesEN), Id);
                session.Delete (mensajesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> DameTodosLosMensajesEnviadosPorUsuario (string nick)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MensajesEN self where FROM MensajesEN m WHERE m.UserOrigen.Nickname = :nick";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MensajesENdameTodosLosMensajesEnviadosPorUsuarioHQL");
                query.SetParameter ("nick", nick);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> DameTodosLosMensajesRecibidosPorUsuario (string nick)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MensajesEN self where FROM MensajesEN m WHERE m.UserDestino.Nickname = :nick";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MensajesENdameTodosLosMensajesRecibidosPorUsuarioHQL");
                query.SetParameter ("nick", nick);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> DameTodosLosMensajesEntreUsuarios (string nickOrigen, string nickDestino)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MensajesEN self where FROM MensajesEN m WHERE m.UserOrigen.Nickname = :nickOrigen AND m.UserDestino.Nickname = :nickDestino";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MensajesENdameTodosLosMensajesEntreUsuariosHQL");
                query.SetParameter ("nickOrigen", nickOrigen);
                query.SetParameter ("nickDestino", nickDestino);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MensajesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
