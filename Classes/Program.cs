namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "acura";
            myCar.Model = "tlx";
            myCar.Year = 2018;

            var lexus = new Car();
            {
                Make = "lexus",
                Model = "rx450",
                Year = 2023
            };

        var honda = new Car("civic", "hatchback", 2021);
        var carList = new List<Car>() { myCar, lexus, honda };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
