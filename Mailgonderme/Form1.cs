using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Mailgonderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MailMessage Eposta = new MailMessage();

        void Mailgonder()
        {
           
            Eposta.From = new MailAddress("Email@outlook.com");//ancaqq outlook olan domainle isleyir
            Eposta.To.Add(textBox1Epost.Text.ToString());
            Eposta.Subject = textBoxMovzu.Text.ToString();
            Eposta.Body = textBoxMesaj.Text.ToString();

          

            SmtpClient client = new SmtpClient();
            //Smtp.Host = "smtp.live.com";  evveler bele iwleyirdi
            client.Host = "smtp-mail.outlook.com";//hal hazirda bele iwleyir.@outlook.com oldugu ucun
            //client.Host = "smtp.gmail.com";//iwlemirr nedense
            client.EnableSsl = true;
            client.Port = 587;  // portlar 25,2525,465,587  en guvenlisi 587-dir
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("Email@outlookcom", "Password");

            client.Send(Eposta);

            MessageBox.Show("Mail gonderildi..");
            textBox1Epost.Text=string.Empty;
            textBoxMesaj .Text = string.Empty;
            textBoxMovzu.Text = string.Empty;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Mailgonder();
        }
    }
}