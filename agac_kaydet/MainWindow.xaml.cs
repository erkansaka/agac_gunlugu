using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;

namespace WpfTreeCommand
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            txtReceiverEmail = txtReceiverEmail;
            txtSenderPassword = txtSenderPassword;
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            // "tree" komutunu çalıştırma
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c tree";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            // Çıktıyı okuma ve txt dosyasına yazma
            string output = process.StandardOutput.ReadToEnd();
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            File.WriteAllText(fileName, output);

            process.WaitForExit();

            // E-posta gönderme işlemi
            string senderEmail = txtSenderEmail.Text;
            string senderPassword = txtSenderPassword.Password;
            string receiverEmail = txtReceiverEmail.Text;
            string subject = "Tree Komutu Çıktısı";
            string body = "Tree komutunun çıktısı ekteki dosyada yer almaktadır.";

            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential(senderEmail, senderPassword);

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("ahmetpakcal@gmail.com", "abxc");

            mail.To.Add("ahmetpakcal@mail.com");
            mail.Subject = "E-Posta Konusu"; mail.IsBodyHtml = true; mail.Body = "E-Posta İçeriği";


            sc.Send(mail);


            MessageBox.Show("E-posta başarıyla gönderildi.");
        }
    }
}
