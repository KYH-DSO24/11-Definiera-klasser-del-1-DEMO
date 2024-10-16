public class Person
{
    private string name;
    public Person(string name)
    {
        if (String.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Invalid name!");
        }
        this.name = name;
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid name!");
            }
            name = value;
        }
    }


}

public class Program
{
    private static void Main(string[] args)
    {
        //Person person = new Person();   // Går inte  - kompileringsfel

        Person person = new Person("John");
        Console.WriteLine("Personens namn: {0}", person.Name);

        person = new Person("");    // Funkar OK - Är det en bugg?
        Console.WriteLine("Personens namn: {0}", person.Name);

        person.Name = "Kalle Kula";
        //person.Name = "";       // Kompilerar OK, går att köra, men ger fel vid körning
        Console.WriteLine("Personens namn efter ändring: {0}", person.Name);

        Console.WriteLine(person.ToString());



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}