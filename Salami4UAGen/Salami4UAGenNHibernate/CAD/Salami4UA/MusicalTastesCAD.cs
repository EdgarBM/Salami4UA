
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
public partial class MusicalTastesCAD : BasicCAD, IMusicalTastesCAD
{
public MusicalTastesCAD() : base ()
{
}

public MusicalTastesCAD(ISession sessionAux) : base (sessionAux)
{
}



public MusicalTastesEN ReadOIDDefault (string Name)
{
        MusicalTastesEN musicalTastesEN = null;

        try
        {
                SessionInitializeTransaction ();
                musicalTastesEN = (MusicalTastesEN)session.Get (typeof(MusicalTastesEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicalTastesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return musicalTastesEN;
}


public string New_ (MusicalTastesEN musicalTastes)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (musicalTastes);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicalTastesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return musicalTastes.Name;
}

public void Modify (MusicalTastesEN musicalTastes)
{
        try
        {
                SessionInitializeTransaction ();
                MusicalTastesEN musicalTastesEN = (MusicalTastesEN)session.Load (typeof(MusicalTastesEN), musicalTastes.Name);
                session.Update (musicalTastesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicalTastesCAD.", ex);
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
                MusicalTastesEN musicalTastesEN = (MusicalTastesEN)session.Load (typeof(MusicalTastesEN), Name);
                session.Delete (musicalTastesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicalTastesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> DameTodosLosGustosMusicales ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MusicalTastesEN self where FROM MusicalTastesEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MusicalTastesENdameTodosLosGustosMusicalesHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in MusicalTastesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
