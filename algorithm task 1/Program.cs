namespace algorithm_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int countDigit = (int)Math.Log10(number) + 1;
            int digit, i = 0;
            if (countDigit % 2 == 0)
                i = 0;
            else
                i = i;
            while (number>0)
            {
                digit = number % 10;
                number /= 10;

                if (i%2==0)
                {
                    Console.WriteLine(digit);
                }
                i++;
            }

           
        }

    }
}