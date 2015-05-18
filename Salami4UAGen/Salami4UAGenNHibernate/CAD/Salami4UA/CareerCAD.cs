
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
public partial class CareerCAD : BasicCAD, ICareerCAD
{
public CareerCAD() : base ()
{
}

public CareerCAD(ISession sessionAux) : base (sessionAux)
{
}



public CareerEN ReadOIDDefault (string Name)
{
        CareerEN careerEN = null;

        try
        {
                SessionInitializeTransaction ();
                careerEN = (CareerEN)session.Get (typeof(CareerEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CareerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return careerEN;
}


public string New_ (CareerEN career)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (career);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CareerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return career.Name;
}

public void Modify (CareerEN career)
{
        try
        {
                SessionInitializeTransaction ();
                CareerEN careerEN = (CareerEN)session.Load (typeof(CareerEN), career.Name);
                session.Update (careerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CareerCAD.", ex);
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
                CareerEN careerEN = (CareerEN)session.Load (typeof(CareerEN), Name);
                session.Delete (careerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CareerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CareerEN> DameTodasLasCarreras ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CareerEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CareerEN self where FROM CareerEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CareerENdameTodasLasCarrerasHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.CareerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CareerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
