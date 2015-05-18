
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
public partial class UsuarioCEN
{
public void Modify (string p_Usuario_OID, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, string p_email, Nullable<DateTime> p_Birthday, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum p_Gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum p_Likes, string p_Name, string p_Surname, string p_Comment, string p_ValidationCode, string p_Career, Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum p_Course, string p_Nationality, int p_Height, System.Collections.Generic.IList<string> p_Pets, System.Collections.Generic.IList<string> p_Films, System.Collections.Generic.IList<string> p_Musics, System.Collections.Generic.IList<string> p_Characteristics, System.Collections.Generic.IList<string> p_Sports, System.Collections.Generic.IList<string> p_Hobbies, string p_UrlFoto, System.Collections.Generic.IList<string> pinchitosRecibidos, System.Collections.Generic.IList<string> mensajesRecibidos, System.Collections.Generic.IList<string> personasQueTeHanBloqueado)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_Usuario_modify_customized) START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nickname = p_Usuario_OID;
        usuarioEN.Password = p_Password;
        usuarioEN.HairColor = p_HairColor;
        usuarioEN.EyeColor = p_EyeColor;
        usuarioEN.HairLength = p_HairLength;
        usuarioEN.HairStyle = p_HairStyle;
        usuarioEN.BodyType = p_BodyType;
        usuarioEN.Ethnicity = p_Ethnicity;
        usuarioEN.Religion = p_Religion;
        usuarioEN.Smoke = p_Smoke;
        usuarioEN.Email = p_email;
        usuarioEN.Birthday = p_Birthday;
        usuarioEN.Gender = p_Gender;
        usuarioEN.Likes = p_Likes;
        usuarioEN.Name = p_Name;
        usuarioEN.Surname = p_Surname;
        usuarioEN.Comment = p_Comment;
        usuarioEN.ValidationCode = p_ValidationCode;
        usuarioEN.Career = p_Career;
        usuarioEN.Course = p_Course;
        usuarioEN.Nationality = p_Nationality;
        usuarioEN.Height = p_Height;
        usuarioEN.Pets = p_Pets;
        usuarioEN.Films = p_Films;
        usuarioEN.Musics = p_Musics;
        usuarioEN.Characteristics = p_Characteristics;
        usuarioEN.Sports = p_Sports;
        usuarioEN.Hobbies = p_Hobbies;
        usuarioEN.UrlFoto = p_UrlFoto;
        usuarioEN.PinchitosRecibidos = pinchitosRecibidos;
        usuarioEN.MensajesRecibidos = mensajesRecibidos;
        usuarioEN.PersonasQueTeHanBloqueado = personasQueTeHanBloqueado;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
