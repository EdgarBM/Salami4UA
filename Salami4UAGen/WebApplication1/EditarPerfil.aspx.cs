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
                    ValoresDefinidosActualmente();

                }
            }

            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void ValoresDefinidosActualmente()
        {
            String nick = Session["Login"].ToString();

            try
            {
                UserCAD usuarioCAD = new UserCAD();
                UserEN usuarioEN = new UserEN();

                usuarioEN = usuarioCAD.ReadOIDDefault(nick);

                TiposDeCuerpo.SelectedValue = usuarioEN.BodyType.ToString();
                Etnia.SelectedValue = usuarioEN.Ethnicity.ToString();
                ColorOjos.SelectedValue = usuarioEN.EyeColor.ToString();
                ColorPelo.SelectedValue = usuarioEN.HairColor.ToString();
                LongitudPelo.SelectedValue = usuarioEN.HairLength.ToString();
                EstiloPelo.SelectedValue = usuarioEN.HairStyle.ToString();
                Fumar.SelectedValue = usuarioEN.Smoke.ToString();
                Religion.SelectedValue = usuarioEN.Religion.ToString();
                Genero.SelectedValue = usuarioEN.Gender.ToString();
                Orientacion.SelectedValue = usuarioEN.Likes.ToString();

                Nacionalidades.SelectedValue = usuarioEN.Nacionalidad.Name;

                PetsCEN petcen = new PetsCEN();
                IList<PetsEN> animales = petcen.DameAnimalesPorUsuario(nick);
                ListItem listItem;

                foreach (PetsEN animal in animales)
                {
                    listItem = Animales.Items.FindByText(animal.Name);
                    if (listItem != null)
                    {
                        listItem.Selected = true;
                    }
                }

                IList<CharacteristicFeaturesEN> caracteristicasEN = new CharacteristicFeaturesCEN().DameCaracteristicasPorUsuario(nick);
                foreach (CharacteristicFeaturesEN caracteristica in caracteristicasEN)
                {
                    listItem = Caracteristicas.Items.FindByText(caracteristica.Name);
                    if (listItem != null)
                    {
                        listItem.Selected = true;
                    }
                }

                IList<GenreFilmsEN> cinesEN = new GenreFilmsCEN().DameGenerosDeCinePorUsuario(nick);
                foreach (GenreFilmsEN cine in cinesEN)
                {
                    listItem = Cine.Items.FindByText(cine.Name);
                    if (listItem != null)
                    {
                        listItem.Selected = true;
                    }
                }

                IList<MusicalTastesEN> musicaEN = new MusicalTastesCEN().DameGustosMusicalesPorUsuario(nick);
                foreach (MusicalTastesEN musica in musicaEN)
                {
                    listItem = Musica.Items.FindByText(musica.Name);
                    if (listItem != null)
                    {
                        listItem.Selected = true;
                    }
                }

                IList<SportsEN> deporteEN = new SportsCEN().DameDeportesPorUsuario(nick);
                foreach (SportsEN deporte in deporteEN)
                {
                    listItem = Deportes.Items.FindByText(deporte.Name);
                    if (listItem != null)
                    {
                        listItem.Selected = true;
                    }
                }

                IList<HobbiesEN> hobbieEN = new HobbiesCEN().DameHobbiesPorUsuario(nick);
                foreach (HobbiesEN hobbie in hobbieEN)
                {
                    listItem = Hobbies.Items.FindByText(hobbie.Name);
                    if (listItem != null)
                    {
                        listItem.Selected = true;
                    }
                }

            }
            catch (Exception ex)
            {
            }


        }

        protected void InicializarValores()
        {
            String nick = Session["Login"].ToString();

            try
            {
                UserEN us = new UserEN();
                UserCAD usuarioCAD = new UserCAD();
                us = usuarioCAD.ReadOIDDefault(nick);

                Name.Text = us.Name;
                Surname.Text = us.Surname;
                Comment.Text = us.Comment;
                FechaNacimiento.Text = Convert.ToString(us.Birthday).Substring(0, 10);

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

                IList<NationalityEN> nacionalidades = new NationalityCEN().DameTodaslasNacionalidades();
                for (int i = 0; i < nacionalidades.Count; i++)
                {
                    Nacionalidades.Items.Add(nacionalidades.ElementAt(i).Name);
                }

                IList<PetsEN> animales = new PetsCEN().DameTodosLosAnimales();
                for (int i = 0; i < animales.Count; i++)
                {
                    Animales.Items.Add(animales.ElementAt(i).Name);
                }

                IList<CharacteristicFeaturesEN> caracteristicas = new CharacteristicFeaturesCEN().DameTodasLasCaracteristicas();
                for (int i = 0; i < caracteristicas.Count; i++)
                {
                    Caracteristicas.Items.Add(caracteristicas.ElementAt(i).Name);
                }

                IList<GenreFilmsEN> cines = new GenreFilmsCEN().DameTodosLosGenerosCine();
                for (int i = 0; i < cines.Count; i++)
                {
                    Cine.Items.Add(cines.ElementAt(i).Name);
                }

                IList<MusicalTastesEN> musicas = new MusicalTastesCEN().DameTodosLosGustosMusicales();
                for (int i = 0; i < musicas.Count; i++)
                {
                    Musica.Items.Add(musicas.ElementAt(i).Name);
                }

                IList<SportsEN> deportes = new SportsCEN().DameTodosLosDeportes();
                for (int i = 0; i < deportes.Count; i++)
                {
                    Deportes.Items.Add(deportes.ElementAt(i).Name);
                }

                IList<HobbiesEN> hobbies = new HobbiesCEN().DameTodosLosHobbies();
                for (int i = 0; i < hobbies.Count; i++)
                {
                    Hobbies.Items.Add(hobbies.ElementAt(i).Name);
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

            try
            {
                tiempo = Convert.ToDateTime(FechaNacimiento.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                ErrorInsertar.Text = "ERROR: The date of birth  is not correct";
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

                        // FALTAN LAS DEMÁS COSAS



                        usuarioCEN.QuitarNacionalidad(us.Nickname, us.Nacionalidad.Name);
                        usuarioCEN.AnyadirNacionalidad(us.Nickname, Nacionalidades.SelectedValue);

                        usuario.Modify(us.Nickname, us.Password, hairColor, eyeColor, hairLength, hairStyle, bodyType, ethnicity, religion, smoke, us.Email, tiempo, genero, orientacion, Name.Text, Surname.Text, Comment.Text, "", "", Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum.First);
                        //usuario.CambiaNacionalidadUsuario(us.Nickname, us.Nacionalidad.Name, Nationality.SelectedValue.ToString());

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
            ErrorInsertar.Text = "";
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Perfil.aspx");
        }
    }
}