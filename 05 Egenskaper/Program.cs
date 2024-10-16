public class Point
{
    private int _xCoord;
    private int _yCoord;

    public int XCoord
    {
        get { return _xCoord; }
        set { _xCoord = value; }
    }

    public int YCoord
    {
        get { return _yCoord; }
        set { _yCoord = value; }
    }

}

public class UserProfile
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{UserId}: {FirstName} {LastName}";
    }
}

public class Person
{
    private readonly UserProfile _profile;
    private readonly List<string> _addresses;

    public Person(UserProfile profile, List<string> addresses)
    {
        _profile = profile;
        _addresses = addresses;
    }

    public UserProfile Profile { get { return _profile; } }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.XCoord = 1;
        p1.YCoord = 5;

        UserProfile profile = new UserProfile()
        {
            FirstName = "Claes",
            LastName = "Engelin",
            UserId = 12345
        };

        Console.WriteLine(profile);

        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}