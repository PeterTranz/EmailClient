using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class ComposeEmail : MonoSingleton<ComposeEmail>
{
    /*
    Sending an email core function
    */
    public AppManager _AppManager;

    public InputField RecieverField;
    public InputField SenderField;
    public InputField SubjectField;
    public InputField MessageField;

    public string RecieverEmail;
    public string SenderEmail;
    public string Subject;
    public string Message;

    private void GUI() {
        if (RecieverField)  {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
            RecieverEmail = RecieverField.text;
        }

        if (SenderField) {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
            SenderEmail = SenderField.text;
        }

        if (SubjectField) {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
            Subject = SubjectField.text;
        }

        if (MessageField) {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
            Message = MessageField.text;
        }

    }

    public void Send() {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(SenderEmail);
            mail.To.Add(RecieverEmail);
            mail.Subject = Subject;
            mail.Body = Message;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 465;

            smtpServer.Credentials = new System.Net.NetworkCredential("Gmail", "Gmail password") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };

            smtpServer.Send(mail);
            Debug.Log("success");
            UIManager.instance.CheckInbox();
    }
}
