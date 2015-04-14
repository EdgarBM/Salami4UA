
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
public partial class GenreFilmsCAD : BasicCAD, IGenreFilmsCAD
{
public GenreFilmsCAD() : base ()
{
}

public GenreFilmsCAD(ISession sessionAux) : base (sessionAux)
{
}



public GenreFilmsEN ReadOIDDefault (string Name)
{
        GenreFilmsEN genreFilmsEN = null;

        try
        {
                SessionInitializeTransaction ();
                genreFilmsEN = (GenreFilmsEN)session.Get (typeof(GenreFilmsEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in GenreFilmsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return genreFilmsEN;
}


public string New_ (GenreFilmsEN genreFilms)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (genreFilms);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in GenreFilmsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return genreFilms.Name;
}

public void Modify (GenreFilmsEN genreFilms)
{
        try
        {
                SessionInitializeTransaction ();
                GenreFilmsEN genreFilmsEN = (GenreFilmsEN)session.Load (typeof(GenreFilmsEN), genreFilms.Name);
                session.Update (genreFilmsEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in GenreFilmsCAD.", ex);
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
                GenreFilmsEN genreFilmsEN = (GenreFilmsEN)session.Load (typeof(GenreFilmsEN), Name);
                session.Delete (genreFilmsEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in GenreFilmsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> DameTodosLosGenerosCine ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM GenreFilmsEN self where FROM GenreFilmsEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("GenreFilmsENdameTodosLosGenerosCineHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in GenreFilmsCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
