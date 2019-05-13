using System;

namespace ZadaniePerson
{
    internal class Person : IPerson
    {
        public int Year { get; set; }
        public string Name { get; set; }

        public int GetAge()
        {
            return DateTime.Today.Year - Year;            
        }
        public override string ToString()
        {
            return $"{Name} ma aktualnie {GetAge()} lat";
        }
    }   
}