

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

public string New_ (string p_Nickname, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, bool p_Offspring, string p_email, Nullable<DateTime> p_Birthday)
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

        userEN.Offspring = p_Offspring;

        userEN.Email = p_email;

        userEN.Birthday = p_Birthday;

        //Call to UserCAD

        oid = _IUserCAD.New_ (userEN);
        return oid;
}

public void Modify (string p_User_OID, string p_Password, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum p_HairColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum p_EyeColor, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum p_HairLength, Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum p_HairStyle, Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum p_BodyType, Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum p_Ethnicity, Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum p_Religion, Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum p_Smoke, bool p_Offspring, string p_email, Nullable<DateTime> p_Birthday)
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
        userEN.Offspring = p_Offspring;
        userEN.Email = p_email;
        userEN.Birthday = p_Birthday;
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
}
}
