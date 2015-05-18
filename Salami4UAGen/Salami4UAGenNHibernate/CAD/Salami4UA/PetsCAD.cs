
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
public partial class PetsCAD : BasicCAD, IPetsCAD
{
public PetsCAD() : base ()
{
}

public PetsCAD(ISession sessionAux) : base (sessionAux)
{
}



public PetsEN ReadOIDDefault (string Name)
{
        PetsEN petsEN = null;

        try
        {
                SessionInitializeTransaction ();
                petsEN = (PetsEN)session.Get (typeof(PetsEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in PetsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return petsEN;
}


public string New_ (PetsEN pets)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (pets);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in PetsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pets.Name;
}

public void Modify (PetsEN pets)
{
        try
        {
                SessionInitializeTransaction ();
                PetsEN petsEN = (PetsEN)session.Load (typeof(PetsEN), pets.Name);
                session.Update (petsEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in PetsCAD.", ex);
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
                PetsEN petsEN = (PetsEN)session.Load (typeof(PetsEN), Name);
                session.Delete (petsEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in PetsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameTodosLosAnimales ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PetsEN self where FROM PetsEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PetsENdameTodosLosAnimalesHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in PetsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> DameAnimalesPorUsuario (Salami4UAGenNHibernate.EN.Salami4UA.UserEN usuario)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PetsEN self where FROM PetsEN p WHERE p.User = :usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PetsENdameAnimalesPorUsuarioHQL");
                query.SetParameter ("usuario", usuario);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in PetsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
