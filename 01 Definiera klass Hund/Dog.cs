public class Dog
{
    private string name;
    private string breed;

    public Dog()
    {

    }

    public Dog(string name, string breed)
    {
        this.name = name;
        this.breed = breed;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public void SayBau()
    {
        // Skriv ut hundens namn. Om namnet är null, skriv ut "[unnamed dog]"
        Console.WriteLine("{0} said: Wooof!", this.name ?? "[unnamed dog]");
    }
}
