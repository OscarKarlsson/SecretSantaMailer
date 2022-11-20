using ConsoleApp2.DataManagement;
using ConsoleApp2.Models;

Randomizer randomizer = new Randomizer();
Mailer mailer = new Mailer();

Console.WriteLine("Insert Credentials for sender email\nEmail:");
string senderEmail = Console.ReadLine();
Console.WriteLine("Password:");
string senderPassword = Console.ReadLine();

List<Person> people = new List<Person>();
List<Person> peopleRnd = new List<Person>();

bool newPerson = true;

while (newPerson)
{
    Console.WriteLine("Insert name of person:");
    string personName = Console.ReadLine();
    Console.WriteLine("Insert their Email:");
    string personEmail = Console.ReadLine();
    people.Add(new Person { Name = personName, Email = personEmail });
    Console.WriteLine("Would you like to add another person? (y/n)");
    if (Console.ReadLine().ToUpper() == "N")
    {
        newPerson = false;
    }
}

peopleRnd = randomizer.personList(people);

mailer.Send(senderEmail, senderPassword, peopleRnd);