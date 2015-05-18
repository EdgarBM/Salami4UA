using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.Enumerated.Salami4UA;

namespace WebApplication1
{
    public partial class Buscar : System.Web.UI.Page
    {
        List<UserEN> listaUsuarios;

        protected void Page_Load(object sender, EventArgs e)
        {
            listaUsuarios = new List<UserEN>();


            NationalityCEN nacion = new NationalityCEN();
            IList<NationalityEN> nacionalidades = nacion.DameTodaslasNacionalidades();

            HeightCEN altura = new HeightCEN();
            IList<HeightEN> Alturas = altura.DameTodaslasAlturas();
            int i;

            if (TiposDeCuerpo.Items.Count == 0)
            {
                i = 0;
                foreach (BodyTypeEnum type in Enum.GetValues(typeof(BodyTypeEnum)))
                {
                    TiposDeCuerpo.Items.Insert(i++, type.ToString());
                }
            }

            if (Etnia.Items.Count == 0)
            {
                i = 0;
                foreach (EthnicityEnum etnia in Enum.GetValues(typeof(EthnicityEnum)))
                {
                    Etnia.Items.Insert(i++, etnia.ToString());
                }
            }

            if (ColorOjos.Items.Count == 0)
            {
                i = 0;
                foreach (EyeColorEnum color in Enum.GetValues(typeof(EyeColorEnum)))
                {
                    ColorOjos.Items.Insert(i++, color.ToString());
                }
            }

            if (ColorPelo.Items.Count == 0)
            {
                i = 0;
                foreach (HairColorEnum color in Enum.GetValues(typeof(HairColorEnum)))
                {
                    ColorPelo.Items.Insert(i++, color.ToString());
                }
            }


            if (LongitudPelo.Items.Count == 0)
            {
                i = 0;
                foreach (HairLengthEnum hair in Enum.GetValues(typeof(HairLengthEnum)))
                {
                    LongitudPelo.Items.Insert(i++, hair.ToString());
                }
            }

            if (EstiloPelo.Items.Count == 0)
            {
                i = 0;
                foreach (HairStyleEnum hair in Enum.GetValues(typeof(HairStyleEnum)))
                {
                    EstiloPelo.Items.Insert(i++, hair.ToString());
                }
            }


            if (Religion.Items.Count == 0)
            {
                i = 0;
                foreach (ReligionEnum religion in Enum.GetValues(typeof(ReligionEnum)))
                {
                    Religion.Items.Insert(i++, religion.ToString());
                }
            }


            if (Fumador.Items.Count == 0)
            {
                i = 0;
                foreach (SmokeEnum smoke in Enum.GetValues(typeof(SmokeEnum)))
                {
                    Fumador.Items.Insert(i++, smoke.ToString());
                }
            }

            if (NacionalidadList.Items.Count == 0)
            {
                i = 0;
                NacionalidadList.Items.Insert(i++, "Spanish");
                foreach (NationalityEN nacional in nacionalidades)
                {
                    if (nacional.Name != "Spanish")
                        NacionalidadList.Items.Insert(i++, nacional.Name);
                }
            }



            if (Height.Items.Count == 0)
            {
                i = 0;
                foreach (HeightEN height in Alturas)
                {
                    Height.Items.Insert(i++, height.Height.ToString());
                }
            }


            //BusquedaExigente();
        }

        protected void Search_Click(object sender, EventArgs e)
        {

            if (StrictSearch.Checked)
            {
                BusquedaExigente();
            }

            else if (CalmSearch.Checked)
            {
                BusquedaTranquila();
            }

        }


        protected List<UserEN> filtraUsuariosNuevos(List<UserEN> usuariosPorAhora, List<UserEN> usuariosNuevos)
        {
            List<UserEN> usuarios = new List<UserEN>();
            usuarios.AddRange(usuariosPorAhora);

            foreach (UserEN usuarioEN in usuariosNuevos)
            {
                if (!usuariosPorAhora.Contains(usuarioEN))
                {
                    usuarios.Add(usuarioEN);
                }
            }

            return usuarios;
        }

        private void BusquedaTranquila()
        {
            listaUsuarios.Clear();

            UserCEN userCen = new UserCEN();

            {
                List<UserEN> listaPorGenero = new List<UserEN>();
                if (RadioWoman.Checked)
                {
                    listaPorGenero.AddRange(userCen.DameUsuarioPorGender(GenderEnum.Woman));
                }
                else if (RadioMan.Checked)
                {
                    listaPorGenero.AddRange(userCen.DameUsuarioPorGender(GenderEnum.Man));
                }

                listaUsuarios.AddRange(listaPorGenero);
            }


            if (TiposDeCuerpo.SelectedIndex != -1)
            {
                List<UserEN> listaPorCuerpo = new List<UserEN>();
                string tipoDeCuerpo = TiposDeCuerpo.SelectedValue;

                listaPorCuerpo.AddRange(userCen.DameUsuarioPorBodyType(
                   (BodyTypeEnum)Enum.Parse(typeof(BodyTypeEnum), tipoDeCuerpo)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorCuerpo);
            }

            if (Etnia.SelectedIndex != -1)
            {
                string etnia = Etnia.SelectedValue;
                List<UserEN> listaPorEtnia = new List<UserEN>();

                listaPorEtnia.AddRange(userCen.DameUsuarioPorEthnicity(
                    (EthnicityEnum)Enum.Parse(typeof(EthnicityEnum), etnia)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorEtnia);

            }

            if (ColorOjos.SelectedIndex != -1)
            {
                string ojos = ColorOjos.SelectedValue;
                List<UserEN> listaPorColorOjos = new List<UserEN>();

                listaPorColorOjos.AddRange(userCen.DameUsuarioPorEyeColor(
                    (EyeColorEnum)Enum.Parse(typeof(EyeColorEnum), ojos)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorColorOjos);

            }


            if (ColorPelo.SelectedIndex != -1)
            {
                string pelo = ColorPelo.SelectedValue;
                List<UserEN> listaPorColorPelo = new List<UserEN>();

                listaPorColorPelo.AddRange(userCen.DameUsuarioPorHairColor(
                    (HairColorEnum)Enum.Parse(typeof(HairColorEnum), pelo)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorColorPelo);

            }


            if (LongitudPelo.SelectedIndex != -1)
            {
                string cabello = LongitudPelo.SelectedValue;
                List<UserEN> listaPorLongitudPelo = new List<UserEN>();

                listaPorLongitudPelo.AddRange(userCen.DameUsuarioPorHairLength(
                    (HairLengthEnum)Enum.Parse(typeof(HairLengthEnum), cabello)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorLongitudPelo);
            }

            if (EstiloPelo.SelectedIndex != -1)
            {
                string peinado = EstiloPelo.SelectedValue;
                List<UserEN> listaPorEstiloPelo = new List<UserEN>();

                listaPorEstiloPelo.AddRange(userCen.DameUsuarioPorHairStyle(
                    (HairStyleEnum)Enum.Parse(typeof(HairStyleEnum), peinado)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorEstiloPelo);
            }

            if (Religion.SelectedIndex != -1)
            {
                string religion = Religion.SelectedValue;
                List<UserEN> listaPorReligion = new List<UserEN>();

                listaPorReligion.AddRange(userCen.DameUsuarioPorReligion(
                    (ReligionEnum)Enum.Parse(typeof(ReligionEnum), religion)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorReligion);
            }


            if (Fumador.SelectedIndex != -1)
            {
                string fumador = Fumador.SelectedValue;
                List<UserEN> listaPorFumador = new List<UserEN>();

                listaPorFumador.AddRange(userCen.DameUsuarioPorFumar(
                    (SmokeEnum)Enum.Parse(typeof(SmokeEnum), fumador)));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorFumador);
            }

            if (NacionalidadList.SelectedIndex != -1)
            {
                string valor = NacionalidadList.SelectedValue;
                List<UserEN> listaPorNacionalidad = new List<UserEN>();
                NationalityEN nacion = new NationalityEN();
                nacion.Name = valor;

                listaPorNacionalidad.AddRange(
                    userCen.DameUsuarioPorNacionalidad(nacion));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorNacionalidad);
            }

            if (Height.SelectedIndex != -1)
            {
                string altura = Height.SelectedValue;
                List<UserEN> listaPorAltura = new List<UserEN>();
                HeightEN height = new HeightEN();

                height.Height = Int32.Parse(altura);

                listaPorAltura.AddRange(
                    userCen.DameUsuarioPorAltura(height));

                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorAltura);

            }

            if (MinAge.Text.Trim() != "" && MaxAge.Text.Trim() != "")
            {
                List<UserEN> listaPorEdad = new List<UserEN>();
                int actualYear = DateTime.Today.Year;
                int minAge = actualYear - Convert.ToInt32(MaxAge.Text);
                int maxAge = actualYear - Convert.ToInt32(MinAge.Text);
                listaPorEdad.AddRange(userCen.DameUsuarioPorRangoEdad(maxAge, minAge));
                listaUsuarios = filtraUsuariosNuevos(listaUsuarios, listaPorEdad);
            }

            LabelSalami.Text = "Found " + listaUsuarios.Count + " Salami's";

            GridView1.DataSource = listaUsuarios;
            GridView1.DataBind();
        }

        private void BusquedaExigente()
        {
            listaUsuarios.Clear();

            UserCEN userCen = new UserCEN();

            {
                List<UserEN> listaPorGenero = new List<UserEN>();
                if (RadioWoman.Checked)
                {
                    listaPorGenero.AddRange(userCen.DameUsuarioPorGender(GenderEnum.Woman));
                }
                else if (RadioMan.Checked)
                {
                    listaPorGenero.AddRange(userCen.DameUsuarioPorGender(GenderEnum.Man));
                }

                listaUsuarios.AddRange(listaPorGenero);
            }


            if (TiposDeCuerpo.SelectedIndex != -1)
            {
                List<UserEN> listaPorCuerpo = new List<UserEN>();
                string tipoDeCuerpo = TiposDeCuerpo.SelectedValue;

                listaPorCuerpo.AddRange(userCen.DameUsuarioPorBodyType(
                   (BodyTypeEnum)Enum.Parse(typeof(BodyTypeEnum), tipoDeCuerpo)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorCuerpo)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (Etnia.SelectedIndex != -1)
            {
                string etnia = Etnia.SelectedValue;
                List<UserEN> listaPorEtnia = new List<UserEN>();

                listaPorEtnia.AddRange(userCen.DameUsuarioPorEthnicity(
                    (EthnicityEnum)Enum.Parse(typeof(EthnicityEnum), etnia)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorEtnia)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (ColorOjos.SelectedIndex != -1)
            {
                string ojos = ColorOjos.SelectedValue;
                List<UserEN> listaPorColorOjos = new List<UserEN>();

                listaPorColorOjos.AddRange(userCen.DameUsuarioPorEyeColor(
                    (EyeColorEnum)Enum.Parse(typeof(EyeColorEnum), ojos)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorColorOjos)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }


            if (ColorPelo.SelectedIndex != -1)
            {
                string pelo = ColorPelo.SelectedValue;
                List<UserEN> listaPorColorPelo = new List<UserEN>();

                listaPorColorPelo.AddRange(userCen.DameUsuarioPorHairColor(
                    (HairColorEnum)Enum.Parse(typeof(HairColorEnum), pelo)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorColorPelo)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }


            if (LongitudPelo.SelectedIndex != -1)
            {
                string cabello = LongitudPelo.SelectedValue;
                List<UserEN> listaPorLongitudPelo = new List<UserEN>();

                listaPorLongitudPelo.AddRange(userCen.DameUsuarioPorHairLength(
                    (HairLengthEnum)Enum.Parse(typeof(HairLengthEnum), cabello)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorLongitudPelo)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (EstiloPelo.SelectedIndex != -1)
            {
                string peinado = EstiloPelo.SelectedValue;
                List<UserEN> listaPorEstiloPelo = new List<UserEN>();

                listaPorEstiloPelo.AddRange(userCen.DameUsuarioPorHairStyle(
                    (HairStyleEnum)Enum.Parse(typeof(HairStyleEnum), peinado)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorEstiloPelo)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (Religion.SelectedIndex != -1)
            {
                string religion = Religion.SelectedValue;
                List<UserEN> listaPorReligion = new List<UserEN>();

                listaPorReligion.AddRange(userCen.DameUsuarioPorReligion(
                    (ReligionEnum)Enum.Parse(typeof(ReligionEnum), religion)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorReligion)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }


            if (Fumador.SelectedIndex != -1)
            {
                string fumador = Fumador.SelectedValue;
                List<UserEN> listaPorFumador = new List<UserEN>();

                listaPorFumador.AddRange(userCen.DameUsuarioPorFumar(
                    (SmokeEnum)Enum.Parse(typeof(SmokeEnum), fumador)));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorFumador)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (NacionalidadList.SelectedIndex != -1)
            {
                string valor = NacionalidadList.SelectedValue;
                List<UserEN> listaPorNacionalidad = new List<UserEN>();
                NationalityEN nacion = new NationalityEN();
                nacion.Name = valor;

                listaPorNacionalidad.AddRange(
                    userCen.DameUsuarioPorNacionalidad(nacion));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorNacionalidad)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (Height.SelectedIndex != -1)
            {
                string altura = Height.SelectedValue;
                List<UserEN> listaPorAltura = new List<UserEN>();
                HeightEN height = new HeightEN();

                height.Height = Int32.Parse(altura);

                listaPorAltura.AddRange(
                    userCen.DameUsuarioPorAltura(height));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorAltura)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }

            if (MinAge.Text.Trim() != "" && MaxAge.Text.Trim() != "")
            {
                List<UserEN> listaPorEdad = new List<UserEN>();
                int actualYear = DateTime.Today.Year;
                int minAge = actualYear - Convert.ToInt32(MaxAge.Text);
                int maxAge = actualYear - Convert.ToInt32(MinAge.Text);
                listaPorEdad.AddRange(userCen.DameUsuarioPorRangoEdad(maxAge, minAge));

                {
                    List<UserEN> listaAux = new List<UserEN>();
                    foreach (UserEN u in listaPorEdad)
                    {
                        if (listaUsuarios.Contains(u))
                            listaAux.Add(u);
                    }

                    listaUsuarios = listaAux;
                }
            }


            LabelSalami.Text = "Found " + listaUsuarios.Count + " Salami's";

            /*
            Tabla.Rows.Clear();
            TableHeaderRow hRow = new TableHeaderRow();
            TableHeaderCell hCell1 = new TableHeaderCell();
            TableHeaderCell hCell2 = new TableHeaderCell();

            hCell1.Text = "Username";
            hCell2.Text = "Email";
            hRow.Cells.Add(hCell1);
            hRow.Cells.Add(hCell2);
            Tabla.Rows.Add(hRow);

            TableRow row = null;
            foreach (UserEN user in listaUsuarios)
            {
                row = new TableRow();
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();

                row.BorderWidth = 1;

                cell1.Text = user.Nickname;
                cell2.Text = user.Email;

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                Tabla.Rows.Add(row);
            }
            */


            GridView1.DataSource = listaUsuarios;
            GridView1.DataBind();
        }




    }
}