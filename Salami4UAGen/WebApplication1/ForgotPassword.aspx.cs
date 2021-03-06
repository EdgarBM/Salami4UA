﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

namespace WebApplication1
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        private string admin = "admin";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
                Session.Clear();
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);

        protected void ContinueButton_Click(object LoginButton, EventArgs e)
        {
            
            try
            {
                UsuarioCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UsuarioCEN();

                IList<UsuarioEN> usu1 = usuario.DameUsuarioPorNickname(Nickname.Text.ToLower());
                IList<UsuarioEN> usu2 = usuario.DameUsuarioPorEmail(Email.Text);

                // Si el nombre de usuario y email son correctos
                if (usu1.Count == 1 && usu2.Count == 1 && usu1[0].Equals(usu2[0]))
                {
                    UsuarioEN u1 = usu1[0];

                    // Si todavia no tiene un codigo de validacion
                    if (u1.ValidationCode == "")
                    {

                        ErrorValidacion.Text = "";
                        Description.Text = "";

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
                            MailAddress toAddress = new MailAddress(Email.Text, Nickname.Text);
                            message.From = fromAddress;
                            message.To.Add(toAddress);
                            message.Subject = "Recover Password";
                            message.Body = "We have received a request to recover the password for the " + Nickname.Text +
                                " account. \n\n If you did this request your activation code will be " + password.ToString() + "\n\n" +
                                "\n\n If you haven't done this request just ignore this email. \n\n Regards, Salami4UA Team.";
                            smtpClient.EnableSsl = true;
                            smtpClient.Credentials = new System.Net.NetworkCredential("salami4ua@gmail.com", "salamiforua");

                            smtpClient.Send(message);

                            usuario.AddValidation(Nickname.Text.ToLower(), password.ToString());

                            try
                            {
                                string msg = Nickname.Text.ToLower() + " has requested to recover his password.";

                                MensajesCEN mensajeCen = new MensajesCEN();
                                mensajeCen.New_(msg, Nickname.Text.ToLower(), admin);


                                UsuarioCEN usuarioCen = new UsuarioCEN();
                                UsuarioCEN usuarioCen2 = new UsuarioCEN();

                                IList<string> mensajes = usuarioCen2.DameMensajesRecibidosPorUsuario(admin);
                                if (!mensajes.Contains(Nickname.Text.ToLower()))
                                {
                                    mensajes.Add(Nickname.Text.ToLower());
                                    usuarioCen.ModificarMensajesRecibidos(admin, mensajes);
                                }

                            }
                            catch (Exception)
                            {
                            }


                        }
                        catch (Exception ex)
                        {

                        }

                        Description2.Text = "The validation code has been sended to your email, so you can now introduce your new password.";
                    }

                    // Si ya tiene un codigo de validacion
                    else
                    {
                        ErrorValidacion.Text = "You already have a validation code. Look up your email." +
                            "\n If you didn't have a validation code, please contact us here http://localhost:49837/Contact.aspx";
                    }
                }

                else
                {
                    ErrorValidacion.Text = "The nickname or the email are wrong.";

                }



            }
            catch (Exception ex)
            {
                ErrorValidacion.Text = "The nickname or the email are wrong.";
            }

        
        }

        protected void ValidationCodeButton_Click(object ValidationCodeButton, EventArgs e)
        {
            try
            {
                ErrorValidacion.Text = "";
                Description.Text = "";
                Description2.Text = "You can now introduce your new password.";
            }
            catch (Exception ex)
            {
            }
        }


        protected void SubmitButton_Click(object LoginButton, EventArgs e)
        {
            try
            {
                UsuarioCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UsuarioCEN();
                IList<UsuarioEN> usu1 = usuario.DameUsuarioPorNickname(Nickname2.Text.ToLower());
                UsuarioEN u1 = usu1[0];

                if (Validation.Text == u1.ValidationCode)
                {

                    if (usuario.CambiarPassword(Nickname2.Text.ToLower(), u1.Password, Account.Login.GetMd5Hash(NewPasswordRecover.Text)))
                    {

                        Description.Text = "";
                        Description2.Text = "";
                        Description3.Text = "The new password has been set, enjoy with Salami4UA.";
                        ErrorValidacion.Text = "";

                        // Email to the admin
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                        MailMessage message = new MailMessage();
                        try
                        {
                            IList<Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN> user = new List<Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN>();
                            user = usuario.DameUsuarioPorNickname(Nickname2.Text.ToLower());
                            Salami4UAGenNHibernate.EN.Salami4UA.UsuarioEN usuario1 = user.ElementAt(0);

                            // Message to the admin
                            try
                            {
                                string msg = usuario1.Nickname + " has recovered his password.";

                                MensajesCEN mensajeCen = new MensajesCEN();
                                mensajeCen.New_(msg, usuario1.Nickname, admin);

                                UsuarioCEN usuarioCen = new UsuarioCEN();
                                UsuarioCEN usuarioCen2 = new UsuarioCEN();

                                IList<string> mensajes = usuarioCen2.DameMensajesRecibidosPorUsuario(admin);
                                if (!mensajes.Contains(usuario1.Nickname))
                                {
                                    mensajes.Add(usuario1.Nickname);
                                    usuarioCen.ModificarMensajesRecibidos(admin, mensajes);
                                }
                            }
                            catch (Exception){}

                            MailAddress fromAddress = new MailAddress("salami4ua@gmail.com", "Salami4UA");
                            MailAddress toAddress = new MailAddress(u1.Email, Nickname2.Text);
                            message.From = fromAddress;
                            message.To.Add(toAddress);
                            message.Subject = "Salami4UA - Change password";
                            message.Body = "Your password has been changed. Thank you for using Salami4UA as " + Nickname2.Text + ". \n\n " +
                                "Please click the following link: \n http://localhost:49837/Account/Login.aspx" +
                                "\n\n Regards, Salami4UA Team.";
                            smtpClient.EnableSsl = true;
                            smtpClient.Credentials = new System.Net.NetworkCredential("salami4ua@gmail.com", "salamiforua");

                            smtpClient.Send(message);

                            usuario.AddValidation(Nickname2.Text.ToLower(), "");
                            Session["login"] = Nickname2.Text.ToLower();

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else
                    {
                        ErrorValidacion.Text = "The password cannot be changed.";
                    }
                }
                else
                {
                    ErrorValidacion.Text = "The validation code is not correct, try again.";
                }
            }

            catch (Exception e1)
            {
                ErrorValidacion.Text = "The password cannot be changed, try again.";
            }
        }

    }
}