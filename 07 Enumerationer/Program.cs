enum DayOfWeek
{
    Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun
}

public enum CoffeeSize
{
    Small = 100,
    Normal = 150,
    Double = 300
}

public class Coffee
{
    public CoffeeSize size;
    public Coffee(CoffeeSize size)
    {
        this.size = size;
    }

    public CoffeeSize Size
    {
        get { return size; }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        DayOfWeek day = DayOfWeek.Wed;
        Console.WriteLine("Weekday {0}, value = {1}", day, (int)day);

        Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
        var doubleCoffee = new Coffee(CoffeeSize.Double);

        Console.WriteLine("The {0} coffee is {1} ml", normalCoffee.Size, (int)normalCoffee.Size);
        Console.WriteLine("The {0} coffee is {1} ml", doubleCoffee.Size, (int)doubleCoffee.Size);

        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
// HEllo World



//***************************************
