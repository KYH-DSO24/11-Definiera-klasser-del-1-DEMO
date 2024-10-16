
public class Person
{
    public string Name { get; set; }
    public override string ToString()
    {
        return "Hello! My name is " + Name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];

        for (int i = 0; i < total; i++)
        {
            Console.Write("Ange namn för person nummer {0}: ", i);
            persons[i] = new Person() { Name = Console.ReadLine() };
        }

        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
