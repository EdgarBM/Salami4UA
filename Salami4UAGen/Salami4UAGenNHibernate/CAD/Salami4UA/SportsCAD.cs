
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
public partial class SportsCAD : BasicCAD, ISportsCAD
{
public SportsCAD() : base ()
{
}

public SportsCAD(ISession sessionAux) : base (sessionAux)
{
}



public SportsEN ReadOIDDefault (string Name)
{
        SportsEN sportsEN = null;

        try
        {
                SessionInitializeTransaction ();
                sportsEN = (SportsEN)session.Get (typeof(SportsEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in SportsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sportsEN;
}


public string New_ (SportsEN sports)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (sports);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in SportsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sports.Name;
}

public void Modify (SportsEN sports)
{
        try
        {
                SessionInitializeTransaction ();
                SportsEN sportsEN = (SportsEN)session.Load (typeof(SportsEN), sports.Name);
                session.Update (sportsEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in SportsCAD.", ex);
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
                SportsEN sportsEN = (SportsEN)session.Load (typeof(SportsEN), Name);
                session.Delete (sportsEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in SportsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> DameTodosLosDeportes ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM SportsEN self where FROM SportsEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("SportsENdameTodosLosDeportesHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in SportsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
