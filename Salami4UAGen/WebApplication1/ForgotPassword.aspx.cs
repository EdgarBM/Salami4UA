using System;
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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);

        protected void ContinueButton_Click(object LoginButton, EventArgs e)
        {
            try
            {
                UserCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN();

                IList<UserEN> usu1 = usuario.DameUsuarioPorNickname(Nickname.Text);
                IList<UserEN> usu2 = usuario.DameUsuarioPorEmail(Email.Text);

                if (usu1.Count == 1 && usu2.Count == 1 && usu1[0].Equals(usu2[0]))
                {
                    UserEN u1 = usu1[0];

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

                        usuario.AddValidation(Nickname.Text, password.ToString());


                    }
                    catch (Exception ex)
                    {

                    }

                    Description2.Text = "The validation code has been sended to your email, so you can now introduce your new password.";

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


        protected void SubmitButton_Click(object LoginButton, EventArgs e)
        {
            try
            {
                UserCEN usuario = new Salami4UAGenNHibernate.CEN.Salami4UA.UserCEN();
                IList<UserEN> usu1 = usuario.DameUsuarioPorNickname(Nickname2.Text);
                UserEN u1 = usu1[0];

                if (Validation.Text == u1.ValidationCode)
                {

                    if (usuario.CambiarPassword(Nickname2.Text, u1.Password, NewPasswordRecover.Text))
                    {

                        Description.Text = "";
                        Description2.Text = "";
                        Description3.Text = "The new password has been set, please log in with the current password.";
                        ErrorValidacion.Text = "";
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