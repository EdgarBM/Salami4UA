
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
public partial class MusicaCAD : BasicCAD, IMusicaCAD
{
public MusicaCAD() : base ()
{
}

public MusicaCAD(ISession sessionAux) : base (sessionAux)
{
}



public MusicaEN ReadOIDDefault (string Name)
{
        MusicaEN musicaEN = null;

        try
        {
                SessionInitializeTransaction ();
                musicaEN = (MusicaEN)session.Get (typeof(MusicaEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return musicaEN;
}


public string New_ (MusicaEN musica)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (musica);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return musica.Name;
}

public void Modify (MusicaEN musica)
{
        try
        {
                SessionInitializeTransaction ();
                MusicaEN musicaEN = (MusicaEN)session.Load (typeof(MusicaEN), musica.Name);
                session.Update (musicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string Name)
{
        try
        {
                SessionInitializeTransaction ();
                MusicaEN musicaEN = (MusicaEN)session.Load (typeof(MusicaEN), Name);
                session.Delete (musicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicaEN> DameTodosLosGustosMusicales ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MusicaEN self where FROM MusicaEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MusicaENdameTodosLosGustosMusicalesHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MusicaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
