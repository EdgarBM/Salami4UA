
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
public partial class UserCAD : BasicCAD, IUserCAD
{
public UserCAD() : base ()
{
}

public UserCAD(ISession sessionAux) : base (sessionAux)
{
}



public UserEN ReadOIDDefault (string Nickname)
{
        UserEN userEN = null;

        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Get (typeof(UserEN), Nickname);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return userEN;
}


public string New_ (UserEN user)
{
        try
        {
                SessionInitializeTransaction ();
                if (user.Pets != null) {
                        for (int i = 0; i < user.Pets.Count; i++) {
                                user.Pets [i] = (Salami4UAGenNHibernate.EN.Salami4UA.PetsEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.PetsEN), user.Pets [i].Name);
                                user.Pets [i].User.Add (user);
                        }
                }
                if (user.CharacteristicFeatures != null) {
                        for (int i = 0; i < user.CharacteristicFeatures.Count; i++) {
                                user.CharacteristicFeatures [i] = (Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN), user.CharacteristicFeatures [i].Name);
                                user.CharacteristicFeatures [i].User.Add (user);
                        }
                }
                if (user.Hobbies != null) {
                        for (int i = 0; i < user.Hobbies.Count; i++) {
                                user.Hobbies [i] = (Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN), user.Hobbies [i].Name);
                                user.Hobbies [i].User.Add (user);
                        }
                }
                if (user.Sports != null) {
                        for (int i = 0; i < user.Sports.Count; i++) {
                                user.Sports [i] = (Salami4UAGenNHibernate.EN.Salami4UA.SportsEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.SportsEN), user.Sports [i].Name);
                                user.Sports [i].User.Add (user);
                        }
                }
                if (user.MusicalTastes != null) {
                        for (int i = 0; i < user.MusicalTastes.Count; i++) {
                                user.MusicalTastes [i] = (Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN), user.MusicalTastes [i].Name);
                                user.MusicalTastes [i].User.Add (user);
                        }
                }
                if (user.GenreFilms != null) {
                        for (int i = 0; i < user.GenreFilms.Count; i++) {
                                user.GenreFilms [i] = (Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN), user.GenreFilms [i].Name);
                                user.GenreFilms [i].User.Add (user);
                        }
                }
                if (user.Nacionalidad != null) {
                        user.Nacionalidad = (Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN), user.Nacionalidad.Name);

                        user.Nacionalidad.User.Add (user);
                }
                if (user.Height_0 != null) {
                        user.Height_0 = (Salami4UAGenNHibernate.EN.Salami4UA.HeightEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.HeightEN), user.Height_0.Height);

                        user.Height_0.User.Add (user);
                }

                session.Save (user);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return user.Nickname;
}

public void Modify (UserEN user)
{
        try
        {
                SessionInitializeTransaction ();
                UserEN userEN = (UserEN)session.Load (typeof(UserEN), user.Nickname);

                userEN.Password = user.Password;


                userEN.HairColor = user.HairColor;


                userEN.EyeColor = user.EyeColor;


                userEN.HairLength = user.HairLength;


                userEN.HairStyle = user.HairStyle;


                userEN.BodyType = user.BodyType;


                userEN.Ethnicity = user.Ethnicity;


                userEN.Religion = user.Religion;


                userEN.Smoke = user.Smoke;


                userEN.Email = user.Email;


                userEN.Birthday = user.Birthday;


                userEN.Gender = user.Gender;


                userEN.Likes = user.Likes;

                session.Update (userEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string Nickname)
{
        try
        {
                SessionInitializeTransaction ();
                UserEN userEN = (UserEN)session.Load (typeof(UserEN), Nickname);
                session.Delete (userEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEmail (string mail)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Email = :mail";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorEmailHQL");
                query.SetParameter ("mail", mail);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNickname (string nombre)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Nickname = :nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorNicknameHQL");
                query.SetParameter ("nombre", nombre);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameTodosLosUsuarios ()
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameTodosLosUsuariosHQL");

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorBodyType (Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.BodyType = :bodyType";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorBodyTypeHQL");
                query.SetParameter ("bodyType", bodyType);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEthnicity (Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum etnia)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Ethnicity = :etnia";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorEthnicityHQL");
                query.SetParameter ("etnia", etnia);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEyeColor (Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum color)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.EyeColor = :color";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorEyeColorHQL");
                query.SetParameter ("color", color);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairColor (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum color)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.HairColor = :color";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorHairColorHQL");
                query.SetParameter ("color", color);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairLength (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum tamanyo)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.HairLength = :tamanyo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorHairLengthHQL");
                query.SetParameter ("tamanyo", tamanyo);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairStyle (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum estilo)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.HairStyle = :estilo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorHairStyleHQL");
                query.SetParameter ("estilo", estilo);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorReligion (Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Religion = :religion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorReligionHQL");
                query.SetParameter ("religion", religion);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorFumar (Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum fumar)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Smoke = :fumar";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorFumarHQL");
                query.SetParameter ("fumar", fumar);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorGender (Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum genero)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Gender = :genero";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorGenderHQL");
                query.SetParameter ("genero", genero);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNacionalidad (Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacionalidad)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Nacionalidad = :nacionalidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorNacionalidadHQL");
                query.SetParameter ("nacionalidad", nacionalidad);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorAltura (Salami4UAGenNHibernate.EN.Salami4UA.HeightEN altura)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Height_0 = :altura";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorAlturaHQL");
                query.SetParameter ("altura", altura);

                result = query.List<Salami4UAGenNHibernate.EN.Salami4UA.UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Salami4UAGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Salami4UAGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
