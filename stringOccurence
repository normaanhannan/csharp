  using System.Xml.Linq;

namespace stringOccurrence;
class Program
{
    static void Main(string[] args)
    {
        String input = "toronto";
        Console.WriteLine("String: " +input);
        while (input.Length > 0)
        {
            Console.Write(input[0] + " = ");
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), String.Empty);
            }
        }
    }
