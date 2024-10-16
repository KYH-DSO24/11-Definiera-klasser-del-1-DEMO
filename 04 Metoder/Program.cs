public class Point
{
    private int xCoord;
    private int yCoord;

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

    public double CalcDistance(Point p)
    {
        double result = Math.Sqrt(
            (p.xCoord - this.xCoord) * (p.xCoord - this.xCoord) +
            (p.yCoord - this.yCoord) * (p.yCoord - this.yCoord));

        return result;
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        Point punkt1 = new Point(2, 3);
        Point p2 = new Point(5, 7);     // Skillnad i x = 3, skillnad i y = 4

        Console.WriteLine("Avstånd från punkt1 till p2: {0}", punkt1.CalcDistance(p2)); // avstånd = roten ur (3*3 + 4*4) = 5
        Console.WriteLine("Avstånd från p2 till punkt1: {0}", p2.CalcDistance(punkt1)); // samma som ovan


        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}