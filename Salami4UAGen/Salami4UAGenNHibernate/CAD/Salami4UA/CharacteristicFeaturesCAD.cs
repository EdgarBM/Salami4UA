
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
public partial class CharacteristicFeaturesCAD : BasicCAD, ICharacteristicFeaturesCAD
{
public CharacteristicFeaturesCAD() : base ()
{
}

public CharacteristicFeaturesCAD(ISession sessionAux) : base (sessionAux)
{
}



public CharacteristicFeaturesEN ReadOIDDefault (string Name)
{
        CharacteristicFeaturesEN characteristicFeaturesEN = null;

        try
        {
                SessionInitializeTransaction ();
                characteristicFeaturesEN = (CharacteristicFeaturesEN)session.Get (typeof(CharacteristicFeaturesEN), Name);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CharacteristicFeaturesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return characteristicFeaturesEN;
}


public string New_ (CharacteristicFeaturesEN characteristicFeatures)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (characteristicFeatures);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CharacteristicFeaturesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return characteristicFeatures.Name;
}

public void Modify (CharacteristicFeaturesEN characteristicFeatures)
{
        try
        {
                SessionInitializeTransaction ();
                CharacteristicFeaturesEN characteristicFeaturesEN = (CharacteristicFeaturesEN)session.Load (typeof(CharacteristicFeaturesEN), characteristicFeatures.Name);
                session.Update (characteristicFeaturesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CharacteristicFeaturesCAD.", ex);
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
                CharacteristicFeaturesEN characteristicFeaturesEN = (CharacteristicFeaturesEN)session.Load (typeof(CharacteristicFeaturesEN), Name);
                session.Delete (characteristicFeaturesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CharacteristicFeaturesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> DameTodasLasCaracteristicas ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CharacteristicFeaturesEN self where FROM CharacteristicFeaturesEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CharacteristicFeaturesENdameTodasLasCaracteristicasHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in CharacteristicFeaturesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
