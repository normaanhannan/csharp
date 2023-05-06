using System;

class Program {
  public static void Main (string[] args) {
    string str; 
    int length = 0; 

    Console.WriteLine("Enter a string: ");
    str = Console.ReadLine();

    length = str.Length - 1; 
    Console.Write("The characters of the string in reverse order is: ");
    while(length >= 0)
  {
    Console.Write("{0}", str[length]);
    length--;
    }
  Console.ReadLine();
  
  }
}
