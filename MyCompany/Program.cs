using System;
using System.Collections.Generic;
using System.IO;

namespace MyCompany
{
     // Human resources department

    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new ();


            //persons.Add( new Person
            //    {
            //        Name = "Andrew",
            //        Email = "andreas@gmail.com"
            //    });

            //persons.Add(  new Person
            //    {
            //        Name = "Athanassios",
            //        Email = "anthanassios@gmail.com"
            //    });

            //persons.Add(new Person
            //{
            //    Name = "Dimitrios",
            //    Email = "dimitrios@gmail.com"
            //});

            using StreamReader file = new("Data.txt");
            string line;

            while ((line= file.ReadLine())!=null)
            {
               // Console.WriteLine(line);
                string[] words = line.Split(",");

                Person person = new ()
                {
                    Name = words[0],
                    Email = words[1],
                    Balance = Decimal.Parse(words[2]),
                    RegistrationDate = DateTime.Parse(words[3])
                };
                persons.Add(person);
            }





            foreach (Person person in persons)
            {
               // person.IncreaseBalance(50);
                 string text = $"{person.Name}, {person.Email}, {person.Balance}, {person.RegistrationDate}";
                Console.WriteLine(text);

              //  file.WriteLine(text);

            }



            //HrDepartment hr = new();
            //hr.IncreaseBalance(5);

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
