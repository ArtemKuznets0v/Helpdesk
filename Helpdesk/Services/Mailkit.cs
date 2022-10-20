
//using Chilkat;
//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Auth.OAuth2.Flows;
//using Google.Apis.Gmail.v1;
//using MailKit.Net.Imap;
//using Npgsql;
//using NPoco.FluentMappings;
//using System.Diagnostics;
//using System.Net.Mail;

//namespace Helpdesk.Services
//{

//    public static class Mailkit
//    {
//        public static void logingmail()
//        {
//            Chilkat.Imap imap = new Chilkat.Imap();


//            imap.KeepSessionLog = true;


//            imap.Ssl = true;
//            imap.Port = 993;
//            bool success = imap.Connect("imap.gmail.com");
//            if (success != true)
//            {
//                Debug.WriteLine(imap.LastErrorText);
//                return;
//            }


//            success = imap.Login("username@gmail.com", "myPassword");
//            if (success != true)
//            {
//                Debug.WriteLine(imap.LastErrorText);
//                return;
//            }

//            success = imap.SelectMailbox("Inbox");
//            if (success != true)
//            {
//                Debug.WriteLine(imap.LastErrorText);
//                return;
//            }


//            Debug.WriteLine(imap.SessionLog);


//            success = imap.Disconnect();

//        }
//    }







