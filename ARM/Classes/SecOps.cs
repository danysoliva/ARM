using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM.Classes;
using System.Net;
using System.Net.Mail;
using System.Data;
//using Microsoft.Exchange.WebServices.Data;

namespace ARM.Classes
{
    class SecOps
    {
        public DataSet ValidateUser(string user, string password)
        {
            DataSet toreturn = new DataSet();
            DataOperations dp = new DataOperations();

//            toreturn = dp.ACS_GetSelectData(@"  SELECT TOP 1 [id]
//			                                            ,[nombre]
//			                                            ,[tipo]
//			                                            ,[defaultheme]
//                                              FROM [dbo].[conf_usuarios]
//                                             WHERE [usuario] = '" + user + @"'
//                                               AND [encpass] = HASHBYTES('SHA1', '" + password + @"');");

            toreturn = dp.ACS_GetSelectData(@"  SELECT TOP 1 [id]
			                                            ,[nombre]
			                                            ,[tipo]
			                                            ,[defaultheme]
                                                        ,[ADUser]
                                              FROM [dbo].[conf_usuarios]
                                             WHERE [ADUser] = '" + user + @"';");

            if (toreturn.Tables[0].Rows.Count > 0)
            {
                return toreturn;
            }
            else
            {
                return null;
            }
        }

        public void SendEmailAlert_GD(DataSet Receivers, int ColumnNumber, string Subject, string Body, bool isHTML)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("apps@aquafeedhn.com", "Aquafeed Apps");

            foreach (DataRow row in Receivers.Tables[0].Rows)
            {
                message.To.Add(new MailAddress(row[ColumnNumber].ToString()));
            }

            message.Subject = Subject;
            message.Body = Body;
            message.IsBodyHtml = isHTML;

            smtp.EnableSsl = false;
            smtp.Port = 80;
            smtp.Host = "smtpout.secureserver.net";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("apps@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(message);
        }

        public void SendEmailAlert_SingleContact_GD(string Receiver, int ColumnNumber, string Subject, string Body, bool isHTML)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("apps@aquafeedhn.com", "Aquafeed Apps");

            message.To.Add(new MailAddress(Receiver));

            message.Subject = Subject;
            message.Body = Body;
            message.IsBodyHtml = isHTML;

            smtp.EnableSsl = false;
            smtp.Port = 80;
            smtp.Host = "smtpout.secureserver.net";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("apps@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(message);
        }

        //public void SendEmail_EX(/*DataSet Receivers, int ColumnNumber, string Subject, string Body, bool isHTML*/)
        //{
        //    ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2007_SP1);

        //    service.Credentials = new WebCredentials("david.riega@aquafeedhn.com", "3vilM0nk3y07&");

        //    service.TraceEnabled = true;
        //    service.TraceFlags = TraceFlags.All;

        //    service.AutodiscoverUrl("david.riega@aquafeedhn.com", RedirectionUrlValidationCallback);

        //    EmailMessage email = new EmailMessage(service);

        //    email.ToRecipients.Add("test@aquafeedhn.com");

        //    email.Subject = "HelloWorld";
        //    email.Body = new MessageBody("This is the first email I've sent by using the EWS Managed API");

        //    email.Send();
        //}

        private static bool RedirectionUrlValidationCallback(string redirectionURL) 
        {
            // The default for the validation callback is to reject the URL.
            bool result = false;

            Uri redirectionUri = new Uri(redirectionURL);

            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }

        public string GetTableHTML(DataSet Information)
        {
            try
            {
                string messageBody = "<font>El Siguiente es un correo de prueba, por favor hacer caso omiso. </font><br><br>";

                if (Information.Tables[0].Rows.Count == 0)
                    return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style =\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";

                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;

                foreach (DataColumn column in Information.Tables[0].Columns)
                {
                    messageBody += htmlTdStart + column.ColumnName + " " + htmlTdEnd;
                }

                messageBody += htmlHeaderRowEnd;

                foreach (DataRow Row in Information.Tables[0].Rows)
                {
                    messageBody = messageBody + htmlTrStart;

                    foreach (DataColumn column in Information.Tables[0].Columns)
                    {
                        messageBody += htmlTdStart + Row[column.ColumnName] + " " + htmlTdEnd;
                    }

                    messageBody = messageBody + htmlTrEnd;
                }

                messageBody = messageBody + htmlTableEnd;


                return messageBody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
