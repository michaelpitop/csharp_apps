using System;

public class Program
{
  public static void Main()
  {
    string[] orderIDs = { "B123", "B124", "C123", "C546", "A890" };

    foreach (string orderID in orderIDs)
    {
      if (orderID.StartsWith("A"))
      {
        Console.WriteLine(orderID);
      }
    }
  }
}
