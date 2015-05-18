using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace WebApplication1.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void InicializarValores()
        {
            Label.Text = "";

            Salami4UAGenNHibernate.CEN.Salami4UA.NacionalidadCEN nacion = new Salami4UAGenNHibernate.CEN.Salami4UA.NacionalidadCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.NacionalidadEN> nacionalidades = nacion.DameTodaslasNacionalidades();

            NacionalidadList.SelectedValue = "Spanish";

            Salami4UAGenNHibernate.CEN.Salami4UA.AlturaCEN altura = new Salami4UAGenNHibernate.CEN.Salami4UA.AlturaCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.AlturaEN> alturas = altura.DameTodaslasAlturas();

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

            Fumador.Items.Insert(0, new ListItem(nosmoke, nosmoke));
            Fumador.Items.Insert(1, new ListItem(ocassionally, ocassionally));
            Fumador.Items.Insert(2, new ListItem(often, often));

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

            for (int i = 0; i < nacionalidades.Count; i++)
            {

                Salami4UAGenNHibernate.EN.Salami4UA.NacionalidadEN nacionalidad = nacionalidades.ElementAt(i);
                String s = nacionalidad.Name;
                if (i == 0)
                    for (int j = 0; j < nacionalidades.Count; j++)
                    {
                        Salami4UAGenNHibernate.EN.Salami4UA.NacionalidadEN nacional = nacionalidades.ElementAt(j);
                        if (nacional.Name == "Spanish")
                            s = nacional.Name;
                    }

                // Insertar s en el listview
                NacionalidadList.Items.Insert(i, new ListItem(s, s));
            }

            Salami4UAGenNHibernate.CEN.Salami4UA.CaracteristicasCEN caracteristica = new Salami4UAGenNHibernate.CEN.Salami4UA.CaracteristicasCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicasEN> caracteristicas = caracteristica.DameTodasLasCaracteristicas();


            for (int i = 0; i < caracteristicas.Count; i++)
            {
                Salami4UAGenNHibernate.EN.Salami4UA.CaracteristicasEN car = caracteristicas.ElementAt(i);
                String s = car.Name;
                ListaCaracteristicas.Items.Add(s);
            }

            for (int i = 0; i < alturas.Count; i++)
            {

                Salami4UAGenNHibernate.EN.Salami4UA.AlturaEN altura1 = alturas.ElementAt(i);
                String s = (altura1.Height).ToString();

                // Insertar s en el listview
                Height.Items.Insert(i, new ListItem(s, s));
            }

            Salami4UAGenNHibernate.CEN.Salami4UA.AnimalesCEN animal = new Salami4UAGenNHibernate.CEN.Salami4UA.AnimalesCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.AnimalesEN> animales = animal.DameTodosLosAnimales();


            for (int i = 0; i < animales.Count; i++)
            {
                Salami4UAGenNHibernate.EN.Salami4UA.AnimalesEN an = animales.ElementAt(i);
                String s = an.Name;
                ListaAnimales.Items.Add(s);
            }


            Salami4UAGenNHibernate.CEN.Salami4UA.CinesCEN cine = new Salami4UAGenNHibernate.CEN.Salami4UA.CinesCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.CinesEN> cines = cine.DameTodosLosGenerosCine();


            for (int i = 0; i < cines.Count; i++)
            {
                Salami4UAGenNHibernate.EN.Salami4UA.CinesEN genre = cines.ElementAt(i);
                String s = genre.Name;
                ListaCine.Items.Add(s);
            }

            Salami4UAGenNHibernate.CEN.Salami4UA.MusicasCEN musica = new Salami4UAGenNHibernate.CEN.Salami4UA.MusicasCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.MusicasEN> musicas = musica.DameTodosLosGustosMusicales();

            for (int i = 0; i < musicas.Count; i++)
            {
                Salami4UAGenNHibernate.EN.Salami4UA.MusicasEN mus = musicas.ElementAt(i);
                String s = mus.Name;
                ListaMusica.Items.Add(s);
            }

            Salami4UAGenNHibernate.CEN.Salami4UA.DeportesCEN deporte = new Salami4UAGenNHibernate.CEN.Salami4UA.DeportesCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.DeportesEN> deportes = deporte.DameTodosLosDeportes();

            for (int i = 0; i < deportes.Count; i++)
            {
                Salami4UAGenNHibernate.EN.Salami4UA.DeportesEN sport = deportes.ElementAt(i);
                String s = sport.Name;
                ListaDeportes.Items.Add(s);
            }

            Salami4UAGenNHibernate.CEN.Salami4UA.AficionesCEN hobbie = new Salami4UAGenNHibernate.CEN.Salami4UA.AficionesCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.AficionesEN> hobbies = hobbie.DameTodosLosHobbies();

            for (int i = 0; i < hobbies.Count; i++)
            {
                Salami4UAGenNHibernate.EN.Salami4UA.AficionesEN hob = hobbies.ElementAt(i);
                String s = hob.Name;
                ListaHobbies.Items.Add(s);

            }

            TermsOfUseLink.Text = "Terms and conditions of use.";
            TermsOfUseLink.NavigateUrl = "../Terms.aspx";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InicializarValores();
            }
        }


        protected void Continuar_Click(object sender, EventArgs e)
        {
            bool ok = true;
            EliminarErroresAnteriores(); // Pone en blanco los errores de los textbox

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();
            try
            {
                StringBuilder password = new StringBuilder();
                char ch;
                int n;
                for (int i = 0; i < 5; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    n = Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65));
                    password.Append(ch); password.Append(n);
                }


                MailAddress fromAddress = new MailAddress("salami4ua@gmail.com", "Salami4UA");
                MailAddress toAddress = new MailAddress(Email.Text, UserName.Text);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Welcome to Salami4ua";
                message.Body = "You are now an user of Salami4ua with the account " + UserName.Text +
                    ". \n\n Your password will be " + password.ToString() + "\n\n" +
                    "Please click the following link: \n http://localhost:49837/Account/Login.aspx";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("salami4ua@gmail.com", "salamiforua");


                Salami4UAGenNHibernate.CEN.Salami4UA.UsuarioCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UsuarioCEN();


                IList<string> animales = new List<string>();
                foreach (ListItem elemento in ListaAnimales.Items)
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
                foreach (ListItem elemento in ListaCaracteristicas.Items)
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
                foreach (ListItem elemento in ListaCine.Items)
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
                foreach (ListItem elemento in ListaMusica.Items)
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
                foreach (ListItem elemento in ListaDeportes.Items)
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
                foreach (ListItem elemento in ListaHobbies.Items)
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
                Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke = (Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum), Fumador.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum genero = (Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.GenderEnum), Genero.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum orientacion = (Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.LikesEnum), Orientacion.SelectedValue);

                DateTime tiempo = new DateTime();

                try
                {
                    tiempo = Convert.ToDateTime(FechaNacimiento.Text);
                    var age = GetAge(tiempo);
                    if (age < 18)
                    {
                        ErrorUnderAge.Text = "You must be 18 years old";
                        ok = false;
                    }
                    else
                    {
                        ErrorUnderAge.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    ok = false;
                }

                IList<Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN> listaUsuarios = new List<Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN>();
                listaUsuarios = usuario.DameUsuarioPorNickname(UserName.Text);

                if (listaUsuarios.Count != 0)
                {
                    ok = false;
                    ErrorNickname.Text = "ERROR: This nickname already exists. Please select another one.";
                    UserName.Text = "";

                }

                if (!TermsOfUse.Checked)
                {
                    ok = false;
                    ErrorTerms.Text = "You have to accept the terms of use.";
                }
                else
                {
                    ErrorTerms.Text = "";
                }

                if (ok)
                {

                    usuario.New_(UserName.Text, password.ToString(), hairColor, eyeColor, hairLength, hairStyle, bodyType, ethnicity, religion, smoke, Email.Text,
                        tiempo, genero, orientacion, Name.Text, Surname.Text, Comment.Text, "", "Carrera", Salami4UAGenNHibernate.Enumerated.Salami4UA.CourseEnum.First,
                        NacionalidadList.SelectedValue, Int32.Parse(Height.SelectedValue), animales, cines, musicas, caracteristicas, deportes, hobbies);
                        


                    smtpClient.Send(message);
                    Label.Text = "Your account has been created! Check your email to log in Salami4UA! \n" +
                        "<a href=\"https://www1.webmail.ua.es/login0.php3?idi=es\" target=\"_blank\"> WebMail  </a>" +
                        "\nPlease log in <a href=\"/Account/Login.aspx\">here</a>." +
                        "\n\n Regards, Salami4UA Team.";

                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                Label.Text = ex.Message;
            }
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);

        private void EliminarErroresAnteriores()
        {
            ErrorHobbies.Text = "";
            ErrorDeportes.Text = "";
            ErrorCine.Text = "";
            ErrorMusica.Text = "";
            ErrorCaracteristicas.Text = "";
            ErrorNickname.Text = "";
            ErrorTerms.Text = "";
            ErrorUnderAge.Text = "";
        }

        protected void ListaCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }

    }
}
