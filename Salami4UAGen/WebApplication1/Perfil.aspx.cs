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
                        Genero.Text = us.Gender.ToString();
                        Orientacion.Text = us.Likes.ToString();
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

                        // Animales

                        PetsCEN petcen = new PetsCEN();
                        IList<PetsEN> animales = petcen.DameAnimalesPorUsuario(us.Nickname);

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


                        // Caracteristicas                         
                        IList<CharacteristicFeaturesEN> caracteristicasEN = new CharacteristicFeaturesCEN().DameCaracteristicasPorUsuario(us.Nickname);
                        s = ""; primero = true;
                        foreach (CharacteristicFeaturesEN caracteristica in caracteristicasEN)
                        {
                            if (primero)
                            {
                                primero = false;
                                s = caracteristica.Name;
                            }

                            else
                            {
                                s += ", " + caracteristica.Name;
                            }
                        }
                        FeaturesLabel.Text = s;

                        // Generos Cine                         
                        IList<GenreFilmsEN> generosCineEN = new GenreFilmsCEN().DameGenerosDeCinePorUsuario(us.Nickname);
                        s = ""; primero = true;
                        foreach (GenreFilmsEN cine in generosCineEN)
                        {
                            if (primero)
                            {
                                primero = false;
                                s = cine.Name;
                            }

                            else
                            {
                                s += ", " + cine.Name;
                            }
                        }
                        FilmLabel.Text = s;

                        // Musica
                        IList<MusicalTastesEN> musicaEN = new MusicalTastesCEN().DameGustosMusicalesPorUsuario(us.Nickname);
                        s = ""; primero = true;
                        foreach (MusicalTastesEN musica in musicaEN)
                        {
                            if (primero)
                            {
                                primero = false;
                                s = musica.Name;
                            }

                            else
                            {
                                s += ", " + musica.Name;
                            }
                        }
                        MusicLabel.Text = s;

                        // Deportes
                        IList<SportsEN> deportesEN = new SportsCEN().DameDeportesPorUsuario(us.Nickname);
                        s = ""; primero = true;
                        foreach (SportsEN deporte in deportesEN)
                        {
                            if (primero)
                            {
                                primero = false;
                                s = deporte.Name;
                            }

                            else
                            {
                                s += ", " + deporte.Name;
                            }
                        }
                        SportsLabel.Text = s;

                        // Hobbies
                        IList<HobbiesEN> hobbiesEN = new HobbiesCEN().DameHobbiesPorUsuario(us.Nickname);
                        s = ""; primero = true;
                        foreach (HobbiesEN hobbie in hobbiesEN)
                        {
                            if (primero)
                            {
                                primero = false;
                                s = hobbie.Name;
                            }

                            else
                            {
                                s += ", " + hobbie.Name;
                            }
                        }
                        HobbiesLabel.Text = s;

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