namespace isPalindrome;
public class Program
{
    public static String checkPalindrome(string input)
    {
        
        if (string.IsNullOrEmpty(input))
            return "not a plaindrome";
        input = input.ToLower();

        var min = 0;
        var max = input.Length - 1;

        while (max >= 0)
        {
            if (input[min] == input[max])
            {
                min++;
                max--;

            }
            else
            {
                return "not a palindrome";
            }
        }

        return "palindrome";
    }

     public static void Main()
     {


        Console.WriteLine(checkPalindrome("racecar"));

     }
       
}

