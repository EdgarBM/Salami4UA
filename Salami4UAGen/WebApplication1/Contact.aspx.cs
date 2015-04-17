using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class Contact : System.Web.UI.Page
    {
        // executed loading the page
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        // function that sends an email to our gmail account
        protected void send_Click(object sender, EventArgs e)
        {

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();
            try
            {

                MailAddress fromAddress = new MailAddress("salami4ua@gmail.com");
                MailAddress toAddress = new MailAddress("salami4ua@gmail.com", TextBox2.Text);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = TextBox3.Text;
                message.Body = TextBox4.Text + "\n " + TextBox2.Text;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("salami4ua@gmail.com", "salamiforua");
                smtpClient.Send(message);
                Label1.Text = "Message sended. Thank you for collaborating with Salami4UA!";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }

            catch (Exception ex)
            {
                Label1.Text = "The message cannot be send!"; 

            }
        }




    }
}