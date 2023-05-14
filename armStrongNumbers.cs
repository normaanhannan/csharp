namespace forLoop.cs;
class Program
{
    static void Main(string[] args)
    {
int lower = 200;
        int higher = 500;
        int i;
        int temp1;
        int temp2;
        int remainder;
        int n = 0;
        double result = 0;

        for (i = lower + 1; i < higher; ++i)
        {
            temp2 = i;
            temp1 = i;


            while (temp1 != 0)
            {
                temp1 /= 10;
                ++ n;
            }

            while(temp2 != 0)
            {
                remainder = temp2 % 10;
                result += Math.Pow(remainder, n);
                temp2 /= 10;

            }
            if (result == i)
            {
                Console.WriteLine(i);
            }
            n = 0;
            result = 0;

        }


    }
}
