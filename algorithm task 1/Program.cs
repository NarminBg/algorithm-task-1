namespace algorithm_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededin cut yerde duran reqemlerinin kvadrati:");
            int number = 123046;
            int sum = 0, a;
            ;
            while (number != 0)
            {

                a = number % 10;
                number = number / 100;
                sum += Convert.ToInt32(Math.Pow(a, 2));
            }
            Console.WriteLine(sum);
        }
    }
}