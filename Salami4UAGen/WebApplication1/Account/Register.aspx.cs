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

        protected void Page_Load(object sender, EventArgs e)
        {
            //ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];


            Salami4UAGenNHibernate.CEN.Salami4UA.NationalityCEN nacion = new Salami4UAGenNHibernate.CEN.Salami4UA.NationalityCEN();          
            IList<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN> nacionalidades = nacion.DameTodaslasNacionalidades();

            NacionalidadList.SelectedValue = "Spanish";

            Salami4UAGenNHibernate.CEN.Salami4UA.HeightCEN caracteristica = new Salami4UAGenNHibernate.CEN.Salami4UA.HeightCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN> caracteristicas = caracteristica.DameTodaslasAlturas();
            
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

            for (int i = 0; i < nacionalidades.Count; i++)
            {
                
                Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacionalidad = nacionalidades.ElementAt(i);
                String s = nacionalidad.Name;
                if(i == 0)
                    for(int j = 0; j < nacionalidades.Count; j++){
                        Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacional = nacionalidades.ElementAt(j);
                        if (nacional.Name == "Spanish")
                            s = nacional.Name;
                    }

                // Insertar s en el listview
                NacionalidadList.Items.Insert(i, new ListItem(s, s));
            }

            for (int i = 0; i < caracteristicas.Count; i++)
            {

                Salami4UAGenNHibernate.EN.Salami4UA.HeightEN altura = caracteristicas.ElementAt(i);
                String s = (altura.Height).ToString();
                
                // Insertar s en el listview
                Height.Items.Insert(i, new ListItem(s, s));
            }
        }


        protected void Continuar_Click(object sender, EventArgs e)
        {
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


                MailAddress fromAddress = new MailAddress("salami4ua@gmail.com", "salamiforua");
                MailAddress toAddress = new MailAddress(Email.Text, UserName.Text);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Welcome to Salami4ua";
                message.Body = "You are now an user of Salami4ua with the account " + Email +
                    ". \n\n Your password will be " + password.ToString() + "\n\n" +
                    "Please click the following link: \n http://localhost:49837/Account/Login.aspx";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("salami4ua@gmail.com", "salamiforua");


                Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN();


                /*IList<String> musica = new List<String>();
                musica.Add("pop");

                IList<String> deportes = new List<String>();
                deportes.Add("Football");

                IList<String> hobbies = new List<String>();
                hobbies.Add("Television");

                IList<String> features = new List<String>();
                features.Add("Shy");

                IList<String> cine = new List<String>();
                features.Add("Western");*/

                Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum hairColor = (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum), ColorPelo.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum eyeColor = (Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum), ColorOjos.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum hairLength = (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum), LongitudPelo.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum hairStyle = (Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum), EstiloPelo.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum bodyType = (Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum), TiposDeCuerpo.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum ethnicity = (Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum), Etnia.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum religion = (Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum), Religion.SelectedValue);
                Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum smoke = (Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum)Enum.Parse(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum), Fumador.SelectedValue);

                usuario.New_(UserName.Text, password.ToString(), hairColor, eyeColor, hairLength, hairStyle, bodyType, ethnicity, religion, smoke, false, Email.Text, DateTime.Today);

                smtpClient.Send(message);
                Label.Text = "Check your email to log in Salami4UA! \n" + 
                    "<a href=\"https://www1.webmail.ua.es/login0.php3?idi=es\" target=\"_blank\"> WebMail  </a>";
            }
            catch (Exception ex)
            {
                Label.Text = ex.Message;
            }
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);


    }
}
