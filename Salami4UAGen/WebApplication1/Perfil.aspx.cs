using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;
using Salami4UAGenNHibernate.Enumerated;
using Salami4UAGenNHibernate.Exceptions;
using Salami4UAGenNHibernate.Properties;
using Salami4UAGenNHibernate.Utils;
using System.Collections;
using System.Text;
using Salami4UAGenNHibernate.CEN.Salami4UA;




namespace WebApplication1
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                String nick = Session["Login"].ToString();

                try
                {
                    UserCEN usuario = new UserCEN();
                    IList<UserEN> usuarios = usuario.DameUsuarioPorNickname(nick);



                    foreach (UserEN us in usuarios)
                    {
                        Nickname.Text = nick;
                        Email.Text = us.Email;
                        NationalityLabel.Text = us.Nacionalidad.Name.ToString();
                        HeightLabel.Text = us.Height_0.Height.ToString();
                        BodyTypeLabel.Text = us.BodyType.ToString();
                        EthnicityLabel.Text = us.Ethnicity.ToString();
                        EyeColorLabel.Text = us.EyeColor.ToString();
                        HairColorLabel.Text = us.HairColor.ToString();
                        HairLengthLabel.Text = us.HairLength.ToString();
                        HairStyleLabel.Text = us.HairStyle.ToString();
                        SmokeLabel.Text = us.Smoke.ToString();
                        ReligionLabel.Text = us.Religion.ToString();

                        // Las multiples opciones


                        /*NationalityEN nacionalidad = new NationalityEN();
                        nacionalidad.Name = us.Nacionalidad.Name.ToString();
                        IList<UserEN> usus = usuario.DameUsuarioPorNacionalidad(nacionalidad);*/

                        HeightEN altura = new HeightEN();
                        altura.Height = 100;
                        IList<UserEN> usus = usuario.DameUsuarioPorAltura(altura);


                        //PetsCEN petcen = new PetsCEN();
                        //IList<PetsEN> ans = petcen.DameAnimalesPorUsuario(us);

                        //UserEN userEN = (UserEN)session.Load(typeof(UserEN), Nickname);



                        IList<PetsEN> animales = us.Pets;
                        //int i = animales.Count;
                        string s = "";
                        bool primero = true;
                        foreach (PetsEN animal in animales)
                        {
                            if (primero)
                            {
                                primero = false;
                                s = animal.Name;
                            }

                            else
                            {
                                s += ", " + animal.Name;
                            }
                        }

                        PetsLabel.Text = s;
                    }

                }
                catch (Exception ex)
                {
                }
            }

            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }

        }

        protected void BotonCambiarPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ChangePassword.aspx");
        }

        protected void BotonEditarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditarPerfil.aspx");
        }

        protected void BotonEliminarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EliminarPerfil.aspx");
        }
    }
}