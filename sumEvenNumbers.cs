namespace forLoop.cs;
class Program
{
    static void Main(string[] args)
    {
        int i;
        int num = 600;
        int sum = 0;

        for (i =2; i <= num; i += 2)
        {
            sum += i;

        }
        Console.WriteLine("Sum of all numbers between 1 to " + num + " = " + sum);


    }
}
