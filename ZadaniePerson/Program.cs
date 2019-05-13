using System;

namespace ZadaniePerson
{
    class Program
    {       

        static void Main(string[] args)
        {
            CountAge();
        }
        static void CountAge()
        {
            IPerson person = new Person();
            while (true)
            {
                void getYear()
                {
                    Console.WriteLine("Podaj rok urodzenia");
                    string readLine = Console.ReadLine();
                    if (int.TryParse(readLine, out int year) && int.Parse(readLine) >= 0)
                    {
                        person.Year = year;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy rok urodzenia");
                        getYear();
                    }
                }
                Console.WriteLine("Podaj imię");
                person.Name = Console.ReadLine();
                getYear();
                Console.WriteLine(person.ToString());
                Console.WriteLine();
            }
        }
    }
}
