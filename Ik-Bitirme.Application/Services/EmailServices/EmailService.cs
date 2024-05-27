using Ik_Bitirme.Application.Models.VMs.UserVMs;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ik_Bitirme.Application.Services.EmailServices
{
    public class EmailService : IEmailService
    {
        public async Task SendPasswordResetEmailAsync(string toEmail, string resetLink)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("your-email@example.com")); // Gönderen e-posta adresi
                email.To.Add(MailboxAddress.Parse(toEmail)); // Alıcı e-posta adresi
                email.Subject = "Password Reset"; // E-posta konusu

                var builder = new BodyBuilder();
                builder.HtmlBody = $@"
                     <html>
                     <head>
                         <style>
                             body {{
                                 font-family: Arial, sans-serif;
                                 background-color: #f4f4f4;
                                 padding: 20px;
                             }}
                             .container {{
                                 max-width: 600px;
                                 margin: auto;
                                 background-color: #fff;
                                 padding: 40px;
                                 border-radius: 5px;
                                 box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                             }}
                             h1 {{
                                 color: #333;
                             }}
                             p {{
                                 margin-bottom: 20px;
                                 line-height: 1.6;
                             }}
                             a {{
                                 color: #007bff;
                             }}
                         </style>
                     </head>
                     <body>
                         <div class='container'>
                             <h1>Password Reset</h1>
                             <p>You have requested to reset your password. Click the link below to reset your password:</p>
                             <p><a href='{resetLink}'>Reset Password</a></p>
                             <p>If you did not request a password reset, you can safely ignore this email.</p>
                             <p><em>This is an automated message, please do not reply.</em></p>
                         </div>
                     </body>
                     </html>";

                email.Body = builder.ToMessageBody();

                using var client = new SmtpClient();
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls); // SMTP sunucu bağlantısı
                await client.AuthenticateAsync("kolayik469@gmail.com", "ityvbxelnkcgvryq"); // SMTP sunucu kimlik doğrulama bilgileri
                await client.SendAsync(email); // E-postayı gönder
                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Console.WriteLine(ex.Message);
            }
        }

        public async Task SendWelcomeEmailAsync(WelcomeEmailModel model)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(MailboxAddress.Parse("your-email@example.com")); // Gönderen e-posta adresi
                emailMessage.To.Add(MailboxAddress.Parse(model.ToEmail)); // Alıcı e-posta adresi
                emailMessage.Subject = "Welcome"; // E-posta konusu

                var builder = new BodyBuilder();
                builder.HtmlBody = $@"
                             <html>
                     <head>
                         <style>
                             body {{
                                 font-family: Arial, sans-serif;
                                 background-color: #f4f4f4;
                                 padding: 20px;
                             }}
                             .container {{
                                 max-width: 600px;
                                 margin: auto;
                                 background-color: #fff;
                                 padding: 40px;
                                 border-radius: 5px;
                                 box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                             }}
                             h1 {{
                                 color: #333;
                             }}
                             p {{
                                 margin-bottom: 20px;
                                 line-height: 1.6;
                             }}
                             ul {{
                                 padding-left: 20px;
                             }}
                         </style>
                     </head>
                     <body>
                         <div class='container'>
                             <h1>Welcome, {model.Username}!</h1>
                             <p>Your registration has been successfully completed. You can now log in with the following information:</p>
                             <ul>
                                 <li><strong>Username:</strong> {model.Username}</li>
                                 <li><strong>Email:</strong> {model.Email}</li>
                                 <li><strong>Password:</strong> {model.Password}</li>
                             </ul>
                             <p>Have a great day!</p>
                         </div>
                     </body>
                     </html>";

                emailMessage.Body = builder.ToMessageBody();

                using var client = new SmtpClient();
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls); // SMTP sunucu bağlantısı
                await client.AuthenticateAsync("kolayik469@gmail.com", "ityvbxelnkcgvryq"); // SMTP sunucu kimlik doğrulama bilgileri
                await client.SendAsync(emailMessage); // E-postayı gönder
                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Console.WriteLine(ex.Message);
            }
        }
    }
}
