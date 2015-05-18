
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
public void CambiaNacionalidadUsuario (string nickname, string nacionalidadAntigua, string nacionalidadNueva)
{
        /*PROTECTED REGION ID(Salami4UAGenNHibernate.CEN.Salami4UA_User_cambiaNacionalidadUsuario) ENABLED START*/

        // Write here your custom code...

        BasicCP basic = new BasicCP ();

        try
        {
                basic.SessionInitializeTransaction ();
                NationalityCAD nacionalidadCAD = new NationalityCAD (basic.session);
                UserCAD usuarioCAD = new UserCAD (basic.session);
                UserEN usuarioEN = usuarioCAD.ReadOIDDefault (nickname);
                NationalityEN nacionalidadNuevaEN = nacionalidadCAD.ReadOIDDefault(nacionalidadNueva);
                NationalityEN nacionalidadAntiguaEN = nacionalidadCAD.ReadOIDDefault(nacionalidadAntigua);
                
                nacionalidadNuevaEN.User.Add (usuarioEN);
                nacionalidadAntiguaEN.User.Remove(usuarioEN);
                nacionalidadCAD.Modify(nacionalidadAntiguaEN);    
                nacionalidadCAD.Modify(nacionalidadNuevaEN);
                
                usuarioEN.Nacionalidad = nacionalidadNuevaEN;
                _IUserCAD.Modify (usuarioEN);
        }
        catch (Exception ex)
        {
        }



        /*PROTECTED REGION END*/
}
}
}
