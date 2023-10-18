// Interface definition & Implementation in two different classes & "Subtyping and subtype polymorphism" 

List<IAnimal> allAnimals = new();
Cow cow = new Cow();
Snake snake = new Snake();

allAnimals.Add(cow);
allAnimals.Add(snake);

foreach (var animal in allAnimals)
{
    animal.Sound();
}


IAnimal ianimal = new Cow();
ianimal.Sound();

public interface IAnimal
{
    public void Sound();
    public int GetNumberOfLegs();
    public string ProduceOffspringMechanic();
}

public class Cow : IAnimal
{
    public int GetNumberOfLegs()
    {
        return 4;
    }

    public string ProduceOffspringMechanic()
    {
        return "Live Birth";
    }

    public void Sound()
    {
        Console.WriteLine("Moooo");
    }
}

public class Snake : IAnimal
{
    public int GetNumberOfLegs()
    {
        return 0;
    }

    public string ProduceOffspringMechanic()
    {
        return "Egglaying";
    }

    public void Sound()
    {
        Console.WriteLine("SsSSSSSSsSS");
    }
}