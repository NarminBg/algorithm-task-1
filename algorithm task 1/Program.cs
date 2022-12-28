namespace algorithm_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int countDigit = (int)Math.Log10(number) + 1;
       
            Console.WriteLine(countDigit);
        }

    }
}
