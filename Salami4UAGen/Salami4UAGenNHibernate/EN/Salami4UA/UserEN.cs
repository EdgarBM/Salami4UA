
using System;

namespace Salami4UAGenNHibernate.EN.Salami4UA
{
public partial class UserEN
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

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> pets;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> characteristicFeatures;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> hobbies;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> sports;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> musicalTastes;

/**
 *
 */

private System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> genreFilms;

/**
 *
 */

private Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacionalidad;

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

private Salami4UAGenNHibernate.EN.Salami4UA.HeightEN height_0;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum gender;

/**
 *
 */

private Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum likes;





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


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> Pets {
        get { return pets; } set { pets = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> CharacteristicFeatures {
        get { return characteristicFeatures; } set { characteristicFeatures = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> Hobbies {
        get { return hobbies; } set { hobbies = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> Sports {
        get { return sports; } set { sports = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> MusicalTastes {
        get { return musicalTastes; } set { musicalTastes = value;  }
}


public virtual System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> GenreFilms {
        get { return genreFilms; } set { genreFilms = value;  }
}


public virtual Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN Nacionalidad {
        get { return nacionalidad; } set { nacionalidad = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual Nullable<DateTime> Birthday {
        get { return birthday; } set { birthday = value;  }
}


public virtual Salami4UAGenNHibernate.EN.Salami4UA.HeightEN Height_0 {
        get { return height_0; } set { height_0 = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum Gender {
        get { return gender; } set { gender = value;  }
}


public virtual Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum Likes {
        get { return likes; } set { likes = value;  }
}





public UserEN()
{
        pets = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN>();
        characteristicFeatures = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN>();
        hobbies = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN>();
        sports = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN>();
        musicalTastes = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN>();
        genreFilms = new System.Collections.Generic.List<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN>();
}



public UserEN(string nickname, string password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> pets, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> characteristicFeatures, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> hobbies, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> sports, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> musicalTastes, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> genreFilms, Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacionalidad, string email, Nullable<DateTime> birthday, Salami4UAGenNHibernate.EN.Salami4UA.HeightEN height_0, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum likes)
{
        this.init (nickname, password, hairColor, eyeColor, hairLength, hairStyle, bodyType, ethnicity, religion, smoke, pets, characteristicFeatures, hobbies, sports, musicalTastes, genreFilms, nacionalidad, email, birthday, height_0, gender, likes);
}


public UserEN(UserEN user)
{
        this.init (user.Nickname, user.Password, user.HairColor, user.EyeColor, user.HairLength, user.HairStyle, user.BodyType, user.Ethnicity, user.Religion, user.Smoke, user.Pets, user.CharacteristicFeatures, user.Hobbies, user.Sports, user.MusicalTastes, user.GenreFilms, user.Nacionalidad, user.Email, user.Birthday, user.Height_0, user.Gender, user.Likes);
}

private void init (string nickname, string password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.PetsEN> pets, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.CharacteristicFeaturesEN> characteristicFeatures, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.HobbiesEN> hobbies, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.SportsEN> sports, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicalTastesEN> musicalTastes, System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.GenreFilmsEN> genreFilms, Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacionalidad, string email, Nullable<DateTime> birthday, Salami4UAGenNHibernate.EN.Salami4UA.HeightEN height_0, Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum gender, Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum likes)
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

        this.Pets = pets;

        this.CharacteristicFeatures = characteristicFeatures;

        this.Hobbies = hobbies;

        this.Sports = sports;

        this.MusicalTastes = musicalTastes;

        this.GenreFilms = genreFilms;

        this.Nacionalidad = nacionalidad;

        this.Email = email;

        this.Birthday = birthday;

        this.Height_0 = height_0;

        this.Gender = gender;

        this.Likes = likes;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UserEN t = obj as UserEN;
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
