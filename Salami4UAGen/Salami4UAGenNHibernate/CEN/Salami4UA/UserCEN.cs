

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace Salami4UAGenNHibernate.CEN.Salami4UA
{
public partial class UserCEN
{
private IUserCAD _IUserCAD;

public UserCEN()
{
        this._IUserCAD = new UserCAD ();
}

public UserCEN(IUserCAD _IUserCAD)
{
        this._IUserCAD = _IUserCAD;
}

public IUserCAD get_IUserCAD ()
{
        return this._IUserCAD;
}

public string New_ (string p_Nickname, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, System.Collections.Generic.IList<string> p_pets, System.Collections.Generic.IList<string> p_characteristicFeatures, System.Collections.Generic.IList<string> p_hobbies, System.Collections.Generic.IList<string> p_sports, System.Collections.Generic.IList<string> p_musicalTastes, System.Collections.Generic.IList<string> p_genreFilms, string p_nacionalidad, string p_email, Nullable<DateTime> p_Birthday, int p_height_0, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum p_Gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum p_Likes, string p_Name, string p_Surname, string p_Comment)
{
        UserEN userEN = null;
        string oid;

        //Initialized UserEN
        userEN = new UserEN ();
        userEN.Nickname = p_Nickname;

        userEN.Password = p_Password;

        userEN.HairColor = p_HairColor;

        userEN.EyeColor = p_EyeColor;

        userEN.HairLength = p_HairLength;

        userEN.HairStyle = p_HairStyle;

        userEN.BodyType = p_BodyType;

        userEN.Ethnicity = p_Ethnicity;

        userEN.Religion = p_Religion;

        userEN.Smoke = p_Smoke;


        userEN.Pets = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN>();
        if (p_pets != null) {
                foreach (string item in p_pets) {
                        Salami4UAGenNHibernate.EN.Salami4UA.PetsEN en = new Salami4UAGenNHibernate.EN.Salami4UA.PetsEN ();
                        en.Name = item;
                        userEN.Pets.Add (en);
                }
        }

        else{
                userEN.Pets = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN>();
        }


        userEN.CharacteristicFeatures = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN>();
        if (p_characteristicFeatures != null) {
                foreach (string item in p_characteristicFeatures) {
                        Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN en = new Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN ();
                        en.Name = item;
                        userEN.CharacteristicFeatures.Add (en);
                }
        }

        else{
                userEN.CharacteristicFeatures = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN>();
        }


        userEN.Hobbies = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN>();
        if (p_hobbies != null) {
                foreach (string item in p_hobbies) {
                        Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN en = new Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN ();
                        en.Name = item;
                        userEN.Hobbies.Add (en);
                }
        }

        else{
                userEN.Hobbies = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN>();
        }


        userEN.Sports = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN>();
        if (p_sports != null) {
                foreach (string item in p_sports) {
                        Salami4UAGenNHibernate.EN.Salami4UA.SportsEN en = new Salami4UAGenNHibernate.EN.Salami4UA.SportsEN ();
                        en.Name = item;
                        userEN.Sports.Add (en);
                }
        }

        else{
                userEN.Sports = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN>();
        }


        userEN.MusicalTastes = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN>();
        if (p_musicalTastes != null) {
                foreach (string item in p_musicalTastes) {
                        Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN en = new Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN ();
                        en.Name = item;
                        userEN.MusicalTastes.Add (en);
                }
        }

        else{
                userEN.MusicalTastes = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN>();
        }


        userEN.GenreFilms = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN>();
        if (p_genreFilms != null) {
                foreach (string item in p_genreFilms) {
                        Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN en = new Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN ();
                        en.Name = item;
                        userEN.GenreFilms.Add (en);
                }
        }

        else{
                userEN.GenreFilms = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN>();
        }


        if (p_nacionalidad != null) {
                userEN.Nacionalidad = new Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN ();
                userEN.Nacionalidad.Name = p_nacionalidad;
        }

        userEN.Email = p_email;

        userEN.Birthday = p_Birthday;


        if (p_height_0 != -1) {
                userEN.Height_0 = new Salami4UAGenNHibernate.EN.Salami4UA.HeightEN ();
                userEN.Height_0.Height = p_height_0;
        }

        userEN.Gender = p_Gender;

        userEN.Likes = p_Likes;

        userEN.Name = p_Name;

        userEN.Surname = p_Surname;

        userEN.Comment = p_Comment;

        //Call to UserCAD

        oid = _IUserCAD.New_ (userEN);
        return oid;
}

public void Modify (string p_User_OID, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, string p_email, Nullable<DateTime> p_Birthday, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum p_Gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum p_Likes, string p_Name, string p_Surname, string p_Comment)
{
        UserEN userEN = null;

        //Initialized UserEN
        userEN = new UserEN ();
        userEN.Nickname = p_User_OID;
        userEN.Password = p_Password;
        userEN.HairColor = p_HairColor;
        userEN.EyeColor = p_EyeColor;
        userEN.HairLength = p_HairLength;
        userEN.HairStyle = p_HairStyle;
        userEN.BodyType = p_BodyType;
        userEN.Ethnicity = p_Ethnicity;
        userEN.Religion = p_Religion;
        userEN.Smoke = p_Smoke;
        userEN.Email = p_email;
        userEN.Birthday = p_Birthday;
        userEN.Gender = p_Gender;
        userEN.Likes = p_Likes;
        userEN.Name = p_Name;
        userEN.Surname = p_Surname;
        userEN.Comment = p_Comment;
        //Call to UserCAD

        _IUserCAD.Modify (userEN);
}

public void Destroy (string Nickname)
{
        _IUserCAD.Destroy (Nickname);
}

public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEmail (string mail)
{
        return _IUserCAD.DameUsuarioPorEmail (mail);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNickname (string nombre)
{
        return _IUserCAD.DameUsuarioPorNickname (nombre);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameTodosLosUsuarios ()
{
        return _IUserCAD.DameTodosLosUsuarios ();
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorBodyType (Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType)
{
        return _IUserCAD.DameUsuarioPorBodyType (bodyType);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEthnicity (Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum etnia)
{
        return _IUserCAD.DameUsuarioPorEthnicity (etnia);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEyeColor (Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum color)
{
        return _IUserCAD.DameUsuarioPorEyeColor (color);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairColor (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum color)
{
        return _IUserCAD.DameUsuarioPorHairColor (color);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairLength (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum tamanyo)
{
        return _IUserCAD.DameUsuarioPorHairLength (tamanyo);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairStyle (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum estilo)
{
        return _IUserCAD.DameUsuarioPorHairStyle (estilo);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorReligion (Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion)
{
        return _IUserCAD.DameUsuarioPorReligion (religion);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorFumar (Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum fumar)
{
        return _IUserCAD.DameUsuarioPorFumar (fumar);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorGender (Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum genero)
{
        return _IUserCAD.DameUsuarioPorGender (genero);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNacionalidad (Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacionalidad)
{
        return _IUserCAD.DameUsuarioPorNacionalidad (nacionalidad);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorAltura (Salami4UAGenNHibernate.EN.Salami4UA.HeightEN altura)
{
        return _IUserCAD.DameUsuarioPorAltura (altura);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorRangoEdad (int min, int max)
{
        return _IUserCAD.DameUsuarioPorRangoEdad (min, max);
}
}
}
