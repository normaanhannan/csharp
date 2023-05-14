namespace forLoop.cs;
class Program
{
    static void Main(string[] args)
    {
int no = 10;

           Console.WriteLine("Multiplication Table : ");
           for (int i = 1; i <= no; i++)
           {
               for (int j = 1; j <= no; j++)
               {
                   Console.Write(i * j + "            ");

               }
               Console.WriteLine("\n");



           }
