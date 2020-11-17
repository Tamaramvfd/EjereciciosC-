using System;
using System.Collections.Generic;

namespace ForeachanList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var names = new List<string>() { "John", "Mary", "Sue", "Greg", "Yolanda", "Jose", "Bill" };

            foreach (var nombre in names)
            {
                Console.WriteLine("Hello " + nombre);
            }

            Console.ReadLine();

            List<PersonModel> person = GetPeople();
            foreach (PersonModel personas in person)
            {
                Console.WriteLine($"Hello { personas.Nombre}{personas.Apellido }");
            }
        }
        private static List<PersonModel> GetPeople()
        {
            List<PersonModel> nombres = new List<PersonModel>();
            nombres.Add(new PersonModel { Nombre = "Tim", Apellido = "Corey" });
            nombres.Add(new PersonModel { Nombre = "Bill", Apellido = "McCoy" });
            nombres.Add(new PersonModel { Nombre = "Mary", Apellido = "Jones" });
            nombres.Add(new PersonModel { Nombre = "Sue", Apellido = "Smith" });

            return nombres;
        }
    }
}
