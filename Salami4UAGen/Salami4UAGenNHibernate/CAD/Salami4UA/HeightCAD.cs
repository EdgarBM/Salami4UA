
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
public partial class HeightCAD : BasicCAD, IHeightCAD
{
public HeightCAD() : base ()
{
}

public HeightCAD(ISession sessionAux) : base (sessionAux)
{
}



public HeightEN ReadOIDDefault (int height)
{
        HeightEN heightEN = null;

        try
        {
                SessionInitializeTransaction ();
                heightEN = (HeightEN)session.Get (typeof(HeightEN), height);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HeightCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return heightEN;
}


public int New_ (HeightEN height)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (height);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HeightCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return height.Height;
}

public void Modify (HeightEN height)
{
        try
        {
                SessionInitializeTransaction ();
                HeightEN heightEN = (HeightEN)session.Load (typeof(HeightEN), height.Height);
                session.Update (heightEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HeightCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int height)
{
        try
        {
                SessionInitializeTransaction ();
                HeightEN heightEN = (HeightEN)session.Load (typeof(HeightEN), height);
                session.Delete (heightEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HeightCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN> DameTodaslasAlturas ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM HeightEN self where FROM HeightEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("HeightENdameTodaslasAlturasHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HeightCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
