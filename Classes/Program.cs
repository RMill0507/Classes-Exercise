namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();//Contructor -Creates new instance in Car class
            myCar.Make = "Chevy";
            myCar.Model = "Sliverado";
            myCar.Year = "2014";
            Console.WriteLine(myCar.Make); 
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);

            var ford = new Car()
            {
                Make = "Ford",
                Model = "Raptor",
                Year = "2018"
            };

        }
    }
}
