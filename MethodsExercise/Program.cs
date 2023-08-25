namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I want to be, the very _,");
            var line1 = Console.ReadLine();

            Console.WriteLine("That no one ever _.");
            var line2 = Console.ReadLine();

            Console.WriteLine("To catch them is my real _,");
            var line3 = Console.ReadLine();

            Console.WriteLine("To train them is my _.");
            var line4 = Console.ReadLine();

            Console.WriteLine($"I want to be, the very {line1}, that no one ever {line2}. \n" +
            $"To catch them is my real {line3}, to train them is my {line4}.");

            //Console.WriteLine(Exercise2.Add(2,4));
            Console.WriteLine(Exercise2.Add(2,4,1,8,9));

            //Console.WriteLine(Exercise2.Multiply(4,6));
            Console.WriteLine(Exercise2.Multiply(1,2,3));

            //Console.WriteLine(Exercise2.Subtract(8,4));
            Console.WriteLine(Exercise2.Subtract(10,5,3,1));

            //Console.WriteLine(Exercise2.Divide(10,2));
            Console.WriteLine(Exercise2.Divide(15,3,5));
        }
    }
}
