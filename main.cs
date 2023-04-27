/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    string[]arr=UserInput();
    ResultOutput(arr);
    Console.WriteLine();
    Console.WriteLine(CountCalculation(arr));
  }
  
  
  public static int CountCalculation(string[]arr)
  {
      int count=0;
      for(int i=0;i<arr.Length;i++)
      {
          if(arr[i].Length<=3)
          {
              count++;
          }
      }
      return count;
  }
  
  public static string[]UserInput()
  {
      Console.WriteLine("Enter arr size");
      int arr_length=int.Parse(Console.ReadLine());
      string[]str_arr=new string[arr_length];
      
      for(int i=0;i<str_arr.Length;i++)
      {
          Console.WriteLine("Enter "+i+" str");
          str_arr[i]=Console.ReadLine();
      }
      return str_arr;
  }
  
  public static void ResultOutput(string[]arr)
  {
      for(int i=0;i<arr.Length;i++)
      {
          Console.Write(arr[i]);
          if(i<(arr.Length-1))
          {
              Console.Write(", ");
          }
      }
  }
}