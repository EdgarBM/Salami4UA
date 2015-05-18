
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


                userEN.Name = user.Name;


                userEN.Surname = user.Surname;


                userEN.Comment = user.Comment;


                userEN.ValidationCode = user.ValidationCode;


                userEN.Career = user.Career;


                userEN.Course = user.Course;


                userEN.Nationality = user.Nationality;


                userEN.Height = user.Height;


                userEN.Pets = user.Pets;


                userEN.Films = user.Films;


                userEN.Musics = user.Musics;


                userEN.Characteristics = user.Characteristics;


                userEN.Sports = user.Sports;


                userEN.Hobbies = user.Hobbies;

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
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNacionalidad (Salami4UAGenNHibernate.EN.Salami4UA.NacionalidadEN nacionalidad)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Nationality = :nacionalidad";
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
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorAltura (Salami4UAGenNHibernate.EN.Salami4UA.AlturaEN altura)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE c.Height = :altura";
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
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorRangoEdad (int min, int max)
{
        System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UserEN self where FROM UserEN c WHERE year(c.Birthday) < :min AND year(c.Birthday) > :max";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UserENdameUsuarioPorRangoEdadHQL");
                query.SetParameter ("min", min);
                query.SetParameter ("max", max);

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
public void AnyadirMensajeEnviado (string p_User_OID, System.Collections.Generic.IList<int> p_messagesEnviados_OIDs)
{
        Salami4UAGenNHibernate.EN.Salami4UA.UserEN userEN = null;
        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Load (typeof(UserEN), p_User_OID);
                Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN messagesEnviadosENAux = null;
                if (userEN.MessagesEnviados == null) {
                        userEN.MessagesEnviados = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN>();
                }

                foreach (int item in p_messagesEnviados_OIDs) {
                        messagesEnviadosENAux = new Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN ();
                        messagesEnviadosENAux = (Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN), item);
                        messagesEnviadosENAux.UserOrigen = userEN;

                        userEN.MessagesEnviados.Add (messagesEnviadosENAux);
                }


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

public void AnyadirMensajeRecibido (string p_User_OID, System.Collections.Generic.IList<int> p_messagesRecibidos_OIDs)
{
        Salami4UAGenNHibernate.EN.Salami4UA.UserEN userEN = null;
        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Load (typeof(UserEN), p_User_OID);
                Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN messagesRecibidosENAux = null;
                if (userEN.MessagesRecibidos == null) {
                        userEN.MessagesRecibidos = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN>();
                }

                foreach (int item in p_messagesRecibidos_OIDs) {
                        messagesRecibidosENAux = new Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN ();
                        messagesRecibidosENAux = (Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN)session.Load (typeof(Salami4UAGenNHibernate.EN.Salami4UA.MessagesEN), item);
                        messagesRecibidosENAux.UserDestino = userEN;

                        userEN.MessagesRecibidos.Add (messagesRecibidosENAux);
                }


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
}
}
