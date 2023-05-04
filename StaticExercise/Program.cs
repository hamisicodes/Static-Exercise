namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(60);
            var farenheit = TempConverter.CelsiusToFahrenheit(30);

            Console.WriteLine($"60 farenheit to celsius is {celsius} celsius");
            Console.WriteLine($"30 celsius to farenheit is {farenheit} farenheit");
        }
    }
}
