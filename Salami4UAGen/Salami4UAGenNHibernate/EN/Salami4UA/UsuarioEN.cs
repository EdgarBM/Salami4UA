
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class UsuarioEN
{
/**
 *
 */

private string nickname;

/**
 *
 */

private string password;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke;

/**
 *
 */

private string email;

/**
 *
 */

private Nullable<DateTime> birthday;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum gender;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum likes;

/**
 *
 */

private string name;

/**
 *
 */

private string surname;

/**
 *
 */

private string comment;

/**
 *
 */

private string validationCode;

/**
 *
 */

private string career;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum course;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> messagesEnviados;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> messagesRecibidos;

/**
 *
 */

private string nationality;

/**
 *
 */

private int height;

/**
 *
 */

private System.Collections.Generic.IList<string> pets;

/**
 *
 */

private System.Collections.Generic.IList<string> films;

/**
 *
 */

private System.Collections.Generic.IList<string> musics;

/**
 *
 */

private System.Collections.Generic.IList<string> characteristics;

/**
 *
 */

private System.Collections.Generic.IList<string> sports;

/**
 *
 */

private System.Collections.Generic.IList<string> hobbies;





public virtual string Nickname {
        get { return nickname; } set { nickname = value;  }
}


public virtual string Password {
        get { return password; } set { password = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum HairColor {
        get { return hairColor; } set { hairColor = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum EyeColor {
        get { return eyeColor; } set { eyeColor = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum HairLength {
        get { return hairLength; } set { hairLength = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum HairStyle {
        get { return hairStyle; } set { hairStyle = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum BodyType {
        get { return bodyType; } set { bodyType = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum Ethnicity {
        get { return ethnicity; } set { ethnicity = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum Religion {
        get { return religion; } set { religion = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum Smoke {
        get { return smoke; } set { smoke = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual Nullable<DateTime> Birthday {
        get { return birthday; } set { birthday = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum Gender {
        get { return gender; } set { gender = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum Likes {
        get { return likes; } set { likes = value;  }
}


public virtual string Name {
        get { return name; } set { name = value;  }
}


public virtual string Surname {
        get { return surname; } set { surname = value;  }
}


public virtual string Comment {
        get { return comment; } set { comment = value;  }
}


public virtual string ValidationCode {
        get { return validationCode; } set { validationCode = value;  }
}


public virtual string Career {
        get { return career; } set { career = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum Course {
        get { return course; } set { course = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> MessagesEnviados {
        get { return messagesEnviados; } set { messagesEnviados = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> MessagesRecibidos {
        get { return messagesRecibidos; } set { messagesRecibidos = value;  }
}


public virtual string Nationality {
        get { return nationality; } set { nationality = value;  }
}


public virtual int Height {
        get { return height; } set { height = value;  }
}


public virtual System.Collections.Generic.IList<string> Pets {
        get { return pets; } set { pets = value;  }
}


public virtual System.Collections.Generic.IList<string> Films {
        get { return films; } set { films = value;  }
}


public virtual System.Collections.Generic.IList<string> Musics {
        get { return musics; } set { musics = value;  }
}


public virtual System.Collections.Generic.IList<string> Characteristics {
        get { return characteristics; } set { characteristics = value;  }
}


public virtual System.Collections.Generic.IList<string> Sports {
        get { return sports; } set { sports = value;  }
}


public virtual System.Collections.Generic.IList<string> Hobbies {
        get { return hobbies; } set { hobbies = value;  }
}





public UsuarioEN()
{
        messagesEnviados = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN>();
        messagesRecibidos = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN>();
}



public UsuarioEN(string nickname, string password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke, string email, Nullable<DateTime> birthday, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum likes, string name, string surname, string comment, string validationCode, string career, Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum course, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> messagesEnviados, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> messagesRecibidos, string nationality, int height, System.Collections.Generic.IList<string> pets, System.Collections.Generic.IList<string> films, System.Collections.Generic.IList<string> musics, System.Collections.Generic.IList<string> characteristics, System.Collections.Generic.IList<string> sports, System.Collections.Generic.IList<string> hobbies)
{
        this.init (nickname, password, hairColor, eyeColor, hairLength, hairStyle, bodyType, ethnicity, religion, smoke, email, birthday, gender, likes, name, surname, comment, validationCode, career, course, messagesEnviados, messagesRecibidos, nationality, height, pets, films, musics, characteristics, sports, hobbies);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Nickname, usuario.Password, usuario.HairColor, usuario.EyeColor, usuario.HairLength, usuario.HairStyle, usuario.BodyType, usuario.Ethnicity, usuario.Religion, usuario.Smoke, usuario.Email, usuario.Birthday, usuario.Gender, usuario.Likes, usuario.Name, usuario.Surname, usuario.Comment, usuario.ValidationCode, usuario.Career, usuario.Course, usuario.MessagesEnviados, usuario.MessagesRecibidos, usuario.Nationality, usuario.Height, usuario.Pets, usuario.Films, usuario.Musics, usuario.Characteristics, usuario.Sports, usuario.Hobbies);
}

private void init (string nickname, string password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke, string email, Nullable<DateTime> birthday, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum likes, string name, string surname, string comment, string validationCode, string career, Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum course, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> messagesEnviados, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MensajesEN> messagesRecibidos, string nationality, int height, System.Collections.Generic.IList<string> pets, System.Collections.Generic.IList<string> films, System.Collections.Generic.IList<string> musics, System.Collections.Generic.IList<string> characteristics, System.Collections.Generic.IList<string> sports, System.Collections.Generic.IList<string> hobbies)
{
        this.Nickname = Nickname;


        this.Password = password;

        this.HairColor = hairColor;

        this.EyeColor = eyeColor;

        this.HairLength = hairLength;

        this.HairStyle = hairStyle;

        this.BodyType = bodyType;

        this.Ethnicity = ethnicity;

        this.Religion = religion;

        this.Smoke = smoke;

        this.Email = email;

        this.Birthday = birthday;

        this.Gender = gender;

        this.Likes = likes;

        this.Name = name;

        this.Surname = surname;

        this.Comment = comment;

        this.ValidationCode = validationCode;

        this.Career = career;

        this.Course = course;

        this.MessagesEnviados = messagesEnviados;

        this.MessagesRecibidos = messagesRecibidos;

        this.Nationality = nationality;

        this.Height = height;

        this.Pets = pets;

        this.Films = films;

        this.Musics = musics;

        this.Characteristics = characteristics;

        this.Sports = sports;

        this.Hobbies = hobbies;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Nickname.Equals (t.Nickname))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nickname.GetHashCode ();
        return hash;
}
}
}
