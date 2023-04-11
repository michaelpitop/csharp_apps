using System;

namespace Library
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book("ME", "how to be dumb", 2);
      // book1.author = "ME";
      // book1.title = "how to be dumb";
      // book1.pages = 2;
      book1.title = "DSAD";
      Console.WriteLine(book1.title);
      Console.ReadLine();
    }
  }
}
