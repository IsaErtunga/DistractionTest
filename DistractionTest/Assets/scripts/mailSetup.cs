using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class mailSetup : MonoBehaviour
{
    public static string bodyMessage;
    private static string recipientEmail = "distraction.answers@gmail.com"; 
    private static string password = "alexausamafriahannesisa"; 

    public static void sendEmail()
    {
        MailMessage mail = new MailMessage();
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Timeout = 10000;
        smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpServer.UseDefaultCredentials = false;
        smtpServer.Port = 587;

        mail.From = new MailAddress(recipientEmail);
        mail.To.Add(new MailAddress(recipientEmail));

        mail.Subject = "test1";
        mail.Body = bodyMessage;

        smtpServer.Credentials = new System.Net.NetworkCredential(recipientEmail, password) as ICredentialsByHost; smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        };
        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        smtpServer.Send(mail);
    }

    public static void gameFinished()
    {
        ProblemInput.times[0, 0] = 1f;
        ProblemInput.times[0, 1] = 2f;
        ProblemInput.times[0, 2] = 3f;
        ProblemInput.times[1, 0] = 4f;
        ProblemInput.times[1, 1] = 5f; 
        foreach (float element in ProblemInput.times)
        {
            mailSetup.bodyMessage +=  "#  #" + element.ToString();
        }
        mailSetup.sendEmail();

    }

}
