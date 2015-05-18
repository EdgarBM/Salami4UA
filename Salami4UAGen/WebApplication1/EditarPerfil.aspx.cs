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

namespace WebApplication1
{
    public partial class EditarPerfil : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                if (!Page.IsPostBack)
                {
                    InicializarValores();
                }
            }

            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void InicializarValores()
        {
            String nick = Session["Login"].ToString();

            try
            {
                UserCEN usuario = new UserCEN();
                IList<UserEN> usuarios = usuario.DameUsuarioPorNickname(nick);


                foreach (UserEN us in usuarios)
                {
                    IList<NationalityEN> nacionalidades = new NationalityCEN().DameTodaslasNacionalidades();
                    for (int i = 0; i < nacionalidades.Count; i++)
                    {
                        Nacionalidad.Items.Insert(i, new ListItem(nacionalidades.ElementAt(i).Name, nacionalidades.ElementAt(i).Name));
                    }

                    IList<HeightEN> alturas = new HeightCEN().DameTodaslasAlturas();
                    for (int i = 0; i < alturas.Count; i++)
                    {
                        Altura.Items.Insert(i, new ListItem(alturas.ElementAt(i).Height.ToString(), alturas.ElementAt(i).Height.ToString()));
                    }

                    String corpulento = Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum.Corpulent.ToString();
                    String normal = Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum.Normal.ToString();
                    String secret = Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum.Secret.ToString();
                    String slim = Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum.Slim.ToString();
                    String solidly = Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum.Solidly.ToString();
                    String sports = Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum.Sports.ToString();

                    TiposDeCuerpo.Items.Insert(0, new ListItem(corpulento, corpulento));
                    TiposDeCuerpo.Items.Insert(1, new ListItem(normal, normal));
                    TiposDeCuerpo.Items.Insert(2, new ListItem(secret, secret));
                    TiposDeCuerpo.Items.Insert(3, new ListItem(slim, slim));
                    TiposDeCuerpo.Items.Insert(4, new ListItem(solidly, solidly));
                    TiposDeCuerpo.Items.Insert(5, new ListItem(sports, sports));

                    String african = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.African.ToString();
                    String arab = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Arab.ToString();
                    String asian = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Asian.ToString();
                    String european = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.European.ToString();
                    String indian = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Indian.ToString();
                    String latino = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Latino.ToString();
                    String mediterranean = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Mediterranean.ToString();
                    String mestizo = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Mestizo.ToString();
                    String secret1 = Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum.Secret.ToString();

                    Etnia.Items.Insert(0, new ListItem(african, african));
                    Etnia.Items.Insert(1, new ListItem(arab, arab));
                    Etnia.Items.Insert(2, new ListItem(asian, asian));
                    Etnia.Items.Insert(3, new ListItem(european, european));
                    Etnia.Items.Insert(4, new ListItem(indian, latino));
                    Etnia.Items.Insert(5, new ListItem(mediterranean, mediterranean));
                    Etnia.Items.Insert(6, new ListItem(mestizo, mestizo));
                    Etnia.Items.Insert(7, new ListItem(secret1, secret1));

                    String black = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Black.ToString();
                    String blue = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Blue.ToString();
                    String brown = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Brown.ToString();
                    String green = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Green.ToString();
                    String grey = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Grey.ToString();
                    String hazel = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Hazel.ToString();
                    String other = Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum.Other.ToString();

                    ColorOjos.Items.Insert(0, new ListItem(black, black));
                    ColorOjos.Items.Insert(1, new ListItem(blue, blue));
                    ColorOjos.Items.Insert(2, new ListItem(brown, brown));
                    ColorOjos.Items.Insert(3, new ListItem(green, green));
                    ColorOjos.Items.Insert(4, new ListItem(grey, grey));
                    ColorOjos.Items.Insert(5, new ListItem(hazel, hazel));
                    ColorOjos.Items.Insert(6, new ListItem(other, other));

                    String blonde = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.Blonde.ToString();
                    String brownhair = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.Brown.ToString();
                    String darkbrown = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.DarkBrown.ToString();
                    String gray = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.Gray.ToString();
                    String lightbrown = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.LightBrown.ToString();
                    String otherhair = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.Other.ToString();
                    String redhead = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.Redhead.ToString();
                    String white = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum.White.ToString();

                    ColorPelo.Items.Insert(0, new ListItem(blonde, blonde));
                    ColorPelo.Items.Insert(1, new ListItem(brownhair, brownhair));
                    ColorPelo.Items.Insert(2, new ListItem(darkbrown, darkbrown));
                    ColorPelo.Items.Insert(3, new ListItem(gray, gray));
                    ColorPelo.Items.Insert(4, new ListItem(lightbrown, lightbrown));
                    ColorPelo.Items.Insert(5, new ListItem(otherhair, otherhair));
                    ColorPelo.Items.Insert(6, new ListItem(redhead, redhead));
                    ColorPelo.Items.Insert(7, new ListItem(white, white));

                    String hairless = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum.Hairless.ToString();
                    String longhair = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum.Long.ToString();
                    String normalhair = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum.Normal.ToString();
                    String shaven = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum.Shaven.ToString();
                    String shorthair = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum.Short.ToString();

                    LongitudPelo.Items.Insert(0, new ListItem(hairless, hairless));
                    LongitudPelo.Items.Insert(1, new ListItem(longhair, longhair));
                    LongitudPelo.Items.Insert(2, new ListItem(normalhair, normalhair));
                    LongitudPelo.Items.Insert(3, new ListItem(shaven, shaven));
                    LongitudPelo.Items.Insert(4, new ListItem(shorthair, shorthair));

                    String curly = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum.Curly.ToString();
                    String straight = Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum.Straight.ToString();

                    EstiloPelo.Items.Insert(0, new ListItem(curly, curly));
                    EstiloPelo.Items.Insert(1, new ListItem(straight, straight));

                    String agnostic = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Agnostic.ToString();
                    String atheist = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Atheist.ToString();
                    String buddisht = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Buddhist.ToString();
                    String catholic = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Catholic.ToString();
                    String christian = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Christian.ToString();
                    String otherreligion = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Other.ToString();
                    String protestant = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Protestant.ToString();
                    String secretreligion = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Secret.ToString();
                    String spiritualistic = Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum.Spiritualistic.ToString();

                    Religion.Items.Insert(0, new ListItem(agnostic, agnostic));
                    Religion.Items.Insert(1, new ListItem(atheist, atheist));
                    Religion.Items.Insert(2, new ListItem(buddisht, buddisht));
                    Religion.Items.Insert(3, new ListItem(catholic, catholic));
                    Religion.Items.Insert(4, new ListItem(christian, christian));
                    Religion.Items.Insert(5, new ListItem(otherreligion, otherreligion));
                    Religion.Items.Insert(6, new ListItem(protestant, protestant));
                    Religion.Items.Insert(7, new ListItem(secretreligion, secretreligion));
                    Religion.Items.Insert(8, new ListItem(spiritualistic, spiritualistic));

                    String nosmoke = Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum.No.ToString();
                    String ocassionally = Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum.Occasionally.ToString();
                    String often = Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum.Often.ToString();

                    Fumar.Items.Insert(0, new ListItem(nosmoke, nosmoke));
                    Fumar.Items.Insert(1, new ListItem(ocassionally, ocassionally));
                    Fumar.Items.Insert(2, new ListItem(often, often));

                    String generohombre = Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum.Man.ToString();
                    String generomujer = Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum.Woman.ToString();

                    Genero.Items.Insert(0, new ListItem(generohombre, generohombre));
                    Genero.Items.Insert(1, new ListItem(generomujer, generomujer));

                    String buscaHombre = Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum.Man.ToString();
                    String buscaMujer = Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum.Woman.ToString();
                    String buscaAmbos = Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum.Both.ToString();

                    Orientacion.Items.Insert(0, new ListItem(buscaHombre, buscaHombre));
                    Orientacion.Items.Insert(1, new ListItem(buscaMujer, buscaMujer));
                    Orientacion.Items.Insert(2, new ListItem(buscaAmbos, buscaAmbos));


                    // Las multiples opciones

                    IList<PetsEN> animales = new Salami4UAGenNHibernate.CEN.Salami4UA.PetsCEN().DameTodosLosAnimales();
                    for (int i = 0; i < animales.Count; i++)
                    {
                        Animales.Items.Add(animales.ElementAt(i).Name);
                    }

                    IList<CharacteristicFeaturesEN> caracteristicas = new Salami4UAGenNHibernate.CEN.Salami4UA.CharacteristicFeaturesCEN().DameTodasLasCaracteristicas();
                    for (int i = 0; i < caracteristicas.Count; i++)
                    {
                        Caracteristicas.Items.Add(caracteristicas.ElementAt(i).Name);
                    }

                    IList<GenreFilmsEN> cines = new Salami4UAGenNHibernate.CEN.Salami4UA.GenreFilmsCEN().DameTodosLosGenerosCine();
                    for (int i = 0; i < cines.Count; i++)
                    {
                        Cine.Items.Add(cines.ElementAt(i).Name);
                    }

                    IList<MusicalTastesEN> musicas = new Salami4UAGenNHibernate.CEN.Salami4UA.MusicalTastesCEN().DameTodosLosGustosMusicales();
                    for (int i = 0; i < musicas.Count; i++)
                    {
                        Musica.Items.Add(musicas.ElementAt(i).Name);
                    }

                    IList<SportsEN> deportes = new Salami4UAGenNHibernate.CEN.Salami4UA.SportsCEN().DameTodosLosDeportes();
                    for (int i = 0; i < deportes.Count; i++)
                    {
                        Deportes.Items.Add(deportes.ElementAt(i).Name);
                    }

                    IList<HobbiesEN> hobbies = new Salami4UAGenNHibernate.CEN.Salami4UA.HobbiesCEN().DameTodosLosHobbies();
                    for (int i = 0; i < hobbies.Count; i++)
                    {
                        Hobbies.Items.Add(hobbies.ElementAt(i).Name);
                    }


                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            bool ok = true;
            EliminarErroresAnteriores(); // Pone en blanco los errores de los textbox

            Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN();


            IList<string> animales = new List<string>();
            foreach (ListItem elemento in Animales.Items)
            {
                if (elemento.Selected)
                {
                    animales.Add(elemento.Value.ToString());
                }
            }

            if (animales.Count == 0)
            {
                //Mostrar error en un label
                ErrorAnimales.Text = "Please select at least one animal";
                ok = false;
            }

            IList<string> caracteristicas = new List<string>();
            foreach (ListItem elemento in Caracteristicas.Items)
            {
                if (elemento.Selected)
                {
                    caracteristicas.Add(elemento.Value.ToString());
                }
            }

            if (caracteristicas.Count == 0)
            {
                //Mostrar error en un label
                ErrorCaracteristicas.Text = "Please select at least one characteristic feature";
                ok = false;
            }

            IList<string> cines = new List<string>();
            foreach (ListItem elemento in Cine.Items)
            {
                if (elemento.Selected)
                {
                    cines.Add(elemento.Value.ToString());
                }
            }


            if (cines.Count == 0)
            {
                //Mostrar error en un label
                ErrorCine.Text = "Please select at least one genre film";
                ok = false;
            }



            IList<string> musicas = new List<string>();
            foreach (ListItem elemento in Musica.Items)
            {
                if (elemento.Selected)
                {
                    musicas.Add(elemento.Value.ToString());
                }
            }


            if (musicas.Count == 0)
            {
                //Mostrar error en un label
                ErrorMusica.Text = "Please select at least one musical taste";
                ok = false;
            }


            IList<string> deportes = new List<string>();
            foreach (ListItem elemento in Deportes.Items)
            {
                if (elemento.Selected)
                {
                    deportes.Add(elemento.Value.ToString());
                }
            }


            if (deportes.Count == 0)
            {
                //Mostrar error en un label
                ErrorDeportes.Text = "Please select at least one sport";
                ok = false;
            }


            IList<string> hobbies = new List<string>();
            foreach (ListItem elemento in Hobbies.Items)
            {
                if (elemento.Selected)
                {
                    hobbies.Add(elemento.Value.ToString());
                }
            }


            if (hobbies.Count == 0)
            {
                //Mostrar error en un label
                ErrorHobbies.Text = "Please select at least one hobby";
                ok = false;
            }


            Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor = (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum), ColorPelo.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor = (Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum), ColorOjos.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength = (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum), LongitudPelo.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle = (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum), EstiloPelo.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType = (Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum), TiposDeCuerpo.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity = (Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum), Etnia.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion = (Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum), Religion.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke = (Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum), Fumar.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum genero = (Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum), Genero.SelectedValue);
            Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum orientacion = (Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum), Orientacion.SelectedValue);



            DateTime tiempo = new DateTime();
            tiempo = Birthday.SelectedDate.Date;
            if (tiempo.Year == 0001)
            {
                ok = false;
                ErrorFechaNacimiento.Text = "You must select your date of birth";
            }

            if (ok)
            {
                Exception excep = null;

                try
                {
                    UserCEN usuarioCEN = new UserCEN();
                    String nick = Session["Login"].ToString();
                    IList<UserEN> usuarios = new UserCEN().DameUsuarioPorNickname(nick);
                    foreach (UserEN us in usuarios)
                    {
                        //usuarioCEN.CambiaNacionalidadUsuario(us.Nickname, us.Nacionalidad.Name, Nacionalidad.SelectedValue);
                        usuario.Modify(us.Nickname, us.Password, hairColor, eyeColor, hairLength, hairStyle, bodyType, ethnicity, religion, smoke, us.Email, tiempo, genero, orientacion);
                    }


                }
                catch (Exception ex)
                {
                    excep = ex;
                    EliminarErroresAnteriores();
                    ErrorInsertar.Text = "ERROR: The update of the profile was not possible";
                }

                if (excep == null)
                {
                    Response.Redirect("~/Perfil.aspx");
                }
            }

        }


        private void EliminarErroresAnteriores()
        {
            ErrorAnimales.Text = "";
            ErrorHobbies.Text = "";
            ErrorDeportes.Text = "";
            ErrorCine.Text = "";
            ErrorMusica.Text = "";
            ErrorCaracteristicas.Text = "";
            ErrorInsertar.Text = "";
        }
    }
}