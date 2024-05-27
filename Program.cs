public class Program
{

    public static void Main(string[] args)
    {

        Cars objCars = new Cars(1, 2);
        objCars.RangeRover();
        objCars.Swift();

    }
}
public class Cars
{
    private int TyreCount;// universal variable
    private int Numberofseat;// universal variable

    public Cars() // Non paramitarized Constructor
    {
        Console.WriteLine("This is car constructor");
    }

    public Cars(int noofstearings) // Non paramitarized Constructor
    {
        Console.WriteLine("This is car constructor");
    }

    public Cars(int tyreCount, int numberofseat) // 1 pararamitarized Constructor
    {
        TyreCount = tyreCount; // Initialiazing the value
        Numberofseat = numberofseat;
        Console.WriteLine("This is car 1 pararamitarized constructor");
    }

    public void RangeRover()
    {
        Console.WriteLine("This is Rage Rover car and it has tyres " + TyreCount + " and Seat Count: " + Numberofseat);
    }

    public void Swift()
    {
        Console.WriteLine("This is Swift car and it has tyres:" + TyreCount + " and Seat Count: " + Numberofseat);
    }
}

