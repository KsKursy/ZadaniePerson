namespace ZadaniePerson
{
    internal interface IPerson
    {
        int Year { get; set; }
        string  Name { get; set; }
        int GetAge();
    }
}