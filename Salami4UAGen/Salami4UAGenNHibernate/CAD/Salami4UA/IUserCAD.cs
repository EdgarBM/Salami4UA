
using System;
using Salami4UAGenNHibernate.EN.Salami4UA;

namespace Salami4UAGenNHibernate.CAD.Salami4UA
{
public partial interface IUserCAD
{
UserEN ReadOIDDefault (string Nickname);

string New_ (UserEN user);

void Modify (UserEN user);


void Destroy (string Nickname);



System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEmail (string mail);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorNickname (string nombre);




System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameTodosLosUsuarios ();


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorBodyType (Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType);



System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEthnicity (Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum etnia);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorEyeColor (Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum color);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairColor (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum color);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairLength (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum tamanyo);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorHairStyle (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum estilo);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorReligion (Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorFumar (Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum fumar);


System.Collections.Generic.IList<Salami4UAGenNHibernate.EN.Salami4UA.UserEN> DameUsuarioPorGender (Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum genero);
}
}
