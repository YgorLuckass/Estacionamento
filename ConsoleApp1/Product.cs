using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;

namespace ConsoleApp1 {
    internal class Product
    {
      public int Number { get; set; }

      public Product(int number)
      {
          Number = number;
      }



    }
}
