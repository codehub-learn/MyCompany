using System;
using System.Collections.Generic;

namespace MyCompany
{
     // Human resources department

    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new ();
            persons.Add( new Person
                {
                    Name = "Andrew",
                    Email = "andreas@gmail.com"
                });

            persons.Add(  new Person
                {
                    Name = "Athanassios",
                    Email = "anthanassios@gmail.com"
                });

            persons.Add(new Person
            {
                Name = "Dimitrios",
                Email = "dimitrios@gmail.com"
            });

            foreach(Person person in persons)
            {
                Console.WriteLine($"{person.Name}, {person.Email}");
            }



        }

        static void DoWork() {   
            decimal price = 30;
            int packets = 2;
            decimal totalPrice = price * packets;

            Console.WriteLine($"Hello. The unit price is {price}, " +
                $"the number of packes is {packets}" +
                $" the total price is {totalPrice}");
        }

    }
}
