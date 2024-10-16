// Första hunden: ge namn och ras via konstruktor
Console.Write("Ange namn för första hunden: ");
string dogName = Console.ReadLine();

Console.Write("Ange ras för första hunden: ");
string dogBreed = Console.ReadLine();

Dog firstDog = new Dog(dogName, dogBreed);

//Andra hunden: ge namn och ras via metoder
Dog secondDog = new Dog();

Console.Write("Ange namn för andra hunden: ");
dogName = Console.ReadLine();

Console.Write("Ange ras för andra hunden: ");
dogBreed = Console.ReadLine();

secondDog.Name = dogName;
secondDog.Breed = dogBreed;

// Skapa en tredje hund, utan ras eller namn
var thirdDog = new Dog();

// Stoppa in hundarna i en vektor:
Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

// Loopa igenom vektorn och be varje hund att skälla
foreach (Dog dog in dogs)
{
    dog.SayBau();
}




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

