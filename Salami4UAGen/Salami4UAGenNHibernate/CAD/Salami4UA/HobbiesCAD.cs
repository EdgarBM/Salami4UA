
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
public partial class HobbiesCAD : BasicCAD, IHobbiesCAD
{
public HobbiesCAD() : base ()
{
}

public HobbiesCAD(ISession sessionAux) : base (sessionAux)
{
}



public HobbiesEN ReadOIDDefault (string Name)
{
        HobbiesEN hobbiesEN = null;

        try
        {
                SessionInitializeTransaction ();
                hobbiesEN = (HobbiesEN)session.Get (typeof(HobbiesEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HobbiesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return hobbiesEN;
}


public string New_ (HobbiesEN hobbies)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (hobbies);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HobbiesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return hobbies.Name;
}

public void Modify (HobbiesEN hobbies)
{
        try
        {
                SessionInitializeTransaction ();
                HobbiesEN hobbiesEN = (HobbiesEN)session.Load (typeof(HobbiesEN), hobbies.Name);
                session.Update (hobbiesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HobbiesCAD.", ex);
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
                HobbiesEN hobbiesEN = (HobbiesEN)session.Load (typeof(HobbiesEN), Name);
                session.Delete (hobbiesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HobbiesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> DameTodosLosHobbies ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM HobbiesEN self where FROM HobbiesEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("HobbiesENdameTodosLosHobbiesHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in HobbiesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
