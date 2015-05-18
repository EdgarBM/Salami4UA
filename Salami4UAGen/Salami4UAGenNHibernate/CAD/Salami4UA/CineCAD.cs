
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
public partial class CineCAD : BasicCAD, ICineCAD
{
public CineCAD() : base ()
{
}

public CineCAD(ISession sessionAux) : base (sessionAux)
{
}



public CineEN ReadOIDDefault (string Name)
{
        CineEN cineEN = null;

        try
        {
                SessionInitializeTransaction ();
                cineEN = (CineEN)session.Get (typeof(CineEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cineEN;
}


public string New_ (CineEN cine)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cine);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cine.Name;
}

public void Modify (CineEN cine)
{
        try
        {
                SessionInitializeTransaction ();
                CineEN cineEN = (CineEN)session.Load (typeof(CineEN), cine.Name);
                session.Update (cineEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CineCAD.", ex);
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
                CineEN cineEN = (CineEN)session.Load (typeof(CineEN), Name);
                session.Delete (cineEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CineEN> DameTodosLosGenerosCine ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CineEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CineEN self where FROM CineEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CineENdameTodosLosGenerosCineHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.CineEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CineCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
