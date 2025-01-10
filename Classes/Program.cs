namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();

            newCar.Make = "Jeep";
            newCar.Model = "Cherokee";
            newCar.Year = 1999;
            
            Console.WriteLine($"Make: {newCar.Make}");
            Console.WriteLine($"Model: {newCar.Model}");
            Console.WriteLine($"Year: {newCar.Year}");
        }
    }
}
