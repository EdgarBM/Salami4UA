
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
public partial class CaracteristicaCAD : BasicCAD, ICaracteristicaCAD
{
public CaracteristicaCAD() : base ()
{
}

public CaracteristicaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CaracteristicaEN ReadOIDDefault (string Name)
{
        CaracteristicaEN caracteristicaEN = null;

        try
        {
                SessionInitializeTransaction ();
                caracteristicaEN = (CaracteristicaEN)session.Get (typeof(CaracteristicaEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CaracteristicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return caracteristicaEN;
}


public string New_ (CaracteristicaEN caracteristica)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (caracteristica);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CaracteristicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return caracteristica.Name;
}

public void Modify (CaracteristicaEN caracteristica)
{
        try
        {
                SessionInitializeTransaction ();
                CaracteristicaEN caracteristicaEN = (CaracteristicaEN)session.Load (typeof(CaracteristicaEN), caracteristica.Name);
                session.Update (caracteristicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CaracteristicaCAD.", ex);
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
                CaracteristicaEN caracteristicaEN = (CaracteristicaEN)session.Load (typeof(CaracteristicaEN), Name);
                session.Delete (caracteristicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CaracteristicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicaEN> DameTodasLasCaracteristicas ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CaracteristicaEN self where FROM CaracteristicaEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CaracteristicaENdameTodasLasCaracteristicasHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CaracteristicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
