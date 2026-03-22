namespace UserDomain;

class User (string Name, int Age, DateOnly DT_Birth)
{
    public string Name {get; set;} = Name;
    public int Age {get; set;} = Age;
    public DateOnly DT_Birth {get; set;} = DT_Birth;

    public void ViewData()
    {
        Console.WriteLine("------------");
        Console.WriteLine($"Name: {this.Name} ");
        Console.WriteLine($"Age: {this.Age} ");
        Console.WriteLine($"Birth: {this.DT_Birth} ");
        Console.WriteLine("------------");
    }
}