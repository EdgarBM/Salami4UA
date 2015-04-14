
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
public partial class NationalityCAD : BasicCAD, INationalityCAD
{
public NationalityCAD() : base ()
{
}

public NationalityCAD(ISession sessionAux) : base (sessionAux)
{
}



public NationalityEN ReadOIDDefault (string Name)
{
        NationalityEN nationalityEN = null;

        try
        {
                SessionInitializeTransaction ();
                nationalityEN = (NationalityEN)session.Get (typeof(NationalityEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in NationalityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nationalityEN;
}


public string New_ (NationalityEN nationality)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (nationality);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in NationalityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nationality.Name;
}

public void Modify (NationalityEN nationality)
{
        try
        {
                SessionInitializeTransaction ();
                NationalityEN nationalityEN = (NationalityEN)session.Load (typeof(NationalityEN), nationality.Name);
                session.Update (nationalityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in NationalityCAD.", ex);
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
                NationalityEN nationalityEN = (NationalityEN)session.Load (typeof(NationalityEN), Name);
                session.Delete (nationalityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in NationalityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN> DameTodaslasNacionalidades ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NationalityEN self where FROM NationalityEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NationalityENdameTodaslasNacionalidadesHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in NationalityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
