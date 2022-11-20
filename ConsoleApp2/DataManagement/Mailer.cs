using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ConsoleApp2.DataManagement
{
    internal class Mailer
    {
        internal void Send(string username, string password, List<Person> persons)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true,
            };

            for (int i = 0; i < persons.Count(); i++)
            {
                if (i == persons.Count() - 1)
                {
                    smtpClient.Send(username, persons[i].Email, "Secret Santa Drawing", "You have "
                    + persons[0].Name + " as your Secret Santa");
                }
                smtpClient.Send(username, persons[i].Email, "Secret Santa Drawing", "You have "
                    + persons[i + 1].Name + " as your Secret Santa");
            }
        }
    }
}