

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

public string New_ (string p_Nickname, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, string p_email, Nullable<DateTime> p_Birthday, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum p_Gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum p_Likes, string p_Name, string p_Surname, string p_Comment, string p_ValidationCode, string p_Career, Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum p_Course, string p_Nationality, int p_Height, System.Collections.Generic.IList<string> p_Pets, System.Collections.Generic.IList<string> p_Films, System.Collections.Generic.IList<string> p_Musics, System.Collections.Generic.IList<string> p_Characteristics, System.Collections.Generic.IList<string> p_Sports, System.Collections.Generic.IList<string> p_Hobbies)
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

        userEN.Email = p_email;

        userEN.Birthday = p_Birthday;

        userEN.Gender = p_Gender;

        userEN.Likes = p_Likes;

        userEN.Name = p_Name;

        userEN.Surname = p_Surname;

        userEN.Comment = p_Comment;

        userEN.ValidationCode = p_ValidationCode;

        userEN.Career = p_Career;

        userEN.Course = p_Course;

        userEN.Nationality = p_Nationality;

        userEN.Height = p_Height;

        userEN.Pets = p_Pets;

        userEN.Films = p_Films;

        userEN.Musics = p_Musics;

        userEN.Characteristics = p_Characteristics;

        userEN.Sports = p_Sports;

        userEN.Hobbies = p_Hobbies;

        //Call to UserCAD

        oid = _IUserCAD.New_ (userEN);
        return oid;
}

public void Modify (string p_User_OID, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, string p_email, Nullable<DateTime> p_Birthday, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum p_Gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum p_Likes, string p_Name, string p_Surname, string p_Comment, string p_ValidationCode, string p_Career, Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum p_Course, string p_Nationality, int p_Height, System.Collections.Generic.IList<string> p_Pets, System.Collections.Generic.IList<string> p_Films, System.Collections.Generic.IList<string> p_Musics, System.Collections.Generic.IList<string> p_Characteristics, System.Collections.Generic.IList<string> p_Sports, System.Collections.Generic.IList<string> p_Hobbies)
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
        userEN.ValidationCode = p_ValidationCode;
        userEN.Career = p_Career;
        userEN.Course = p_Course;
        userEN.Nationality = p_Nationality;
        userEN.Height = p_Height;
        userEN.Pets = p_Pets;
        userEN.Films = p_Films;
        userEN.Musics = p_Musics;
        userEN.Characteristics = p_Characteristics;
        userEN.Sports = p_Sports;
        userEN.Hobbies = p_Hobbies;
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
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNacionalidad (Salami4UAGenNHibernate.EN.Salami4UA.NacionalidadEN nacionalidad)
{
        return _IUserCAD.DameUsuarioPorNacionalidad (nacionalidad);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorAltura (Salami4UAGenNHibernate.EN.Salami4UA.AlturaEN altura)
{
        return _IUserCAD.DameUsuarioPorAltura (altura);
}
public System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorRangoEdad (int min, int max)
{
        return _IUserCAD.DameUsuarioPorRangoEdad (min, max);
}
public void AnyadirMensajeEnviado (string p_User_OID, System.Collections.Generic.IList<int> p_messagesEnviados_OIDs)
{
        //Call to UserCAD

        _IUserCAD.AnyadirMensajeEnviado (p_User_OID, p_messagesEnviados_OIDs);
}
public void AnyadirMensajeRecibido (string p_User_OID, System.Collections.Generic.IList<int> p_messagesRecibidos_OIDs)
{
        //Call to UserCAD

        _IUserCAD.AnyadirMensajeRecibido (p_User_OID, p_messagesRecibidos_OIDs);
}
}
}
