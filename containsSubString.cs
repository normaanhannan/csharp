using System;

class Program {
  public static void Main (string[] args) {
    string str1, str2;
    bool m;

    Console.WriteLine("Enter the bigger string: ");
    str1 = Console.ReadLine();

    Console.WriteLine("Enter the smaller string you want to check: ");
    str2 = Console.ReadLine();

    m = str1.Contains(str2);
    if (m == true){
      Console.WriteLine("The smaller string is a part of the bigger string");
    
    }
    else{
      Console.WriteLine("This smaller string is not contained in the bigger string");
    }
    
    
  }
}
