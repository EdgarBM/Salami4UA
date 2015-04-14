using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            Salami4UAGenNHibernate.CEN.Salami4UA.NationalityCEN nacion = new Salami4UAGenNHibernate.CEN.Salami4UA.NationalityCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN> nacionalidades = nacion.DameTodaslasNacionalidades();

            Salami4UAGenNHibernate.CEN.Salami4UA.HeightCEN altura = new Salami4UAGenNHibernate.CEN.Salami4UA.HeightCEN();
            IList<Salami4UAGenNHibernate.EN.Salami4UA.HeightEN> alturas = altura.DameTodaslasAlturas();


            int i = 0;
            foreach (String type in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.BodyTypeEnum)))
            {
                TiposDeCuerpo.Items.Insert(i++, type);
            }


            i = 0;
            foreach (String etnia in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.EthnicityEnum)))
            {
                Etnia.Items.Insert(i++, etnia);
            }


            i = 0;
            foreach (String color in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.EyeColorEnum)))
            {
                ColorOjos.Items.Insert(i++, color);
            }


            i = 0;
            foreach (String color in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairColorEnum)))
            {
                ColorPelo.Items.Insert(i++, color);
            }



            i = 0;
            foreach (String hair in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairLengthEnum)))
            {
                LongitudPelo.Items.Insert(i++, hair);
            }


            i = 0;
            foreach (String hair in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.HairStyleEnum)))
            {
                EstiloPelo.Items.Insert(i++, hair);
            }



            i = 0;
            foreach (String religion in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.ReligionEnum)))
            {
                Religion.Items.Insert(i++, religion);
            }



            i = 0;
            foreach (String smoke in Enum.GetValues(typeof(Salami4UAGenNHibernate.Enumerated.Salami4UA.SmokeEnum)))
            {
                Fumador.Items.Insert(i++, smoke);
            }


            i = 0;
            NacionalidadList.Items.Insert(i++, "Spanish");
            foreach (Salami4UAGenNHibernate.EN.Salami4UA.NationalityEN nacional in nacionalidades)
            {
                if(nacional.Name != "Spanish")
                    NacionalidadList.Items.Insert(i++, nacional.Name);
            }



            i = 0;
            foreach (Salami4UAGenNHibernate.EN.Salami4UA.HeightEN height in alturas)
            {
                Height.Items.Insert(i++, height.ToString());
            }

            
        }



        protected void Search_Click(object sender, EventArgs e)
        {
            CleanFilter(); 

        }


        private void CleanFilter()
        {
            TiposDeCuerpo.SelectedIndex = -1;
            Etnia.SelectedIndex = -1;
            ColorOjos.SelectedIndex = -1;
            ColorPelo.SelectedIndex = -1;
            LongitudPelo.SelectedIndex = -1;
            EstiloPelo.SelectedIndex = -1;
            Religion.SelectedIndex = -1;
            Fumador.SelectedIndex = -1;
            NacionalidadList.SelectedIndex = -1;
            Height.SelectedIndex = -1;
        }
    }
}