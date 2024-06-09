namespace OperatorExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var sum = a + b;
            var Subtract = a - b;
            var Multiply = a * b;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($" {a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

            // var is implicit type inference 

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
        }
        // define a method - which performs some functionality. that can
        // be used over and over again
        public static double AreaOfCircle(double radius)

        {
            // this is the scope of the method 
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
         }
    }
}
