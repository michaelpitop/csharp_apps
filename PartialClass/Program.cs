using System;

namespace PartialClasses
{
  public class Program
  {
    static void Main(string[] args)
    {
      Development development = new Development();
      development.Backend();
      development.Frontend();
      development.Database();
    }
  }

  public partial class Development
  {
    public void Frontend() => Console.WriteLine("This is the frontend part of development");
  }

  public partial class Development
  {
    public void Backend() => Console.WriteLine("This is the backend part of development");
  }

  public partial class Development
  {
    public void  Database() => Console.WriteLine("This is when the database part of development.");
  }
}
