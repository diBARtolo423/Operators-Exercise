namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle:");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaofCircle(radius));
        }
        public static double AreaofCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area; 
            
        }
    }
}
