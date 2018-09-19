using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver01
{
  class Program
  {
    static void Main(string[] args)
    {
      var array = new[] { 1, 4, 23, 6, 4, 3, 2 };
      PrintNumbers(array);
      PrintLargestNumber(array);
    }

    private static void PrintLargestNumber(int[] array)
    {
      Console.WriteLine("someone should do this task,,");
    }

    private static void PrintNumbers(int[] array)
    {
      for(int i = 0; i < array.Length;i++) // a for-loop. a way to run through an array
      {
        Console.Write(array[i] + ", ");
      }
      Console.WriteLine(); // new line
    }
  }
}
