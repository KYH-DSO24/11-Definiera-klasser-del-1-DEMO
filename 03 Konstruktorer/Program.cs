public class Point
{
    private int xCoord;
    private int yCoord;

    //public Point()
    //{
    //    this.xCoord = 0;
    //    this.yCoord = 0;
    //}
    public Point() : this(0, 0)
    {

    }

    public Point(int xCoord, int yCoord)
    {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    }

    public int XCoord
    {
        get { return xCoord; }
        set { xCoord = value; }
    }
    public int YCoord
    { 
        get { return yCoord; } 
        set { yCoord = value; } 
    }
}

public class Person
{
    public string name;
    public int age;
    public Person()
    {
        this.name = string.Empty;
        this.age = 0;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

public class AlarmClock
{
    public int hours = 10;
    public int minutes = 20;

    // Parameterlös konstruktor
    public AlarmClock()
    {
        
    }

    // Konstruktor med parametrar
    public AlarmClock(int hours, int minutes)
    {
        this.hours = hours;
        this.minutes = minutes;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Point point1 = new Point();
        var point2 = new Point(2, 3);

        Console.WriteLine("Punkt 1: ({0}, {1})", point1.XCoord, point1.YCoord);
        Console.WriteLine("Punkt 2: ({0}, {1})", point2.XCoord, point2.YCoord);

        var person = new Person("Claes", 103);
        Console.WriteLine("{0} är {1} år gammal", person.name, person.age);

        var alarmClock1 = new AlarmClock();
        Console.WriteLine("Väckarklocka 1: tid = {0}:{1}", alarmClock1.hours, alarmClock1.minutes);

        var alarmClock2 = new AlarmClock(15, 30);
        Console.WriteLine("Väckarklocka 2: tid = {0}:{1}", alarmClock2.hours, alarmClock2.minutes);

        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}