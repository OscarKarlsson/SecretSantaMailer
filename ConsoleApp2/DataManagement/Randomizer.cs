using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2.DataManagement
{
    internal class Randomizer
    {
        private Random rng = new Random();

        internal List<Person> personList(List<Person> persons)
        {
            List<Person> personRandom = new List<Person>();

            while (persons.Count() >= 0)
            {
                int rnd = rng.Next(persons.Count());
                personRandom.Add(persons[rnd]);
                persons.RemoveAt(rnd);
            }

            return personRandom;
        }
    }
}