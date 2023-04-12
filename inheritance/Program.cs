// ok saw this exercise in a YouTube video so i thought i would copy it to learn it
// its about inheritance between classes methods and how to override whichever you want

using System;

namespace LearningInheritance
{
  class Base
  {
    // this will the base class that the inheritor would copy the methods
    public string CustomMethod1 = "result1";

    public virtual void CustomMethod2()
    {
      Console.WriteLine("Custom output");
    }
  }

  class Inheritor : Base
  {
    // we will inherite the first Method but override the second to give us a different output
    public override void CustomMethod2()
    {
      Console.WriteLine("second Output");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Inheritor newInheritor = new Inheritor();
      newInheritor.CustomMethod2();
      Console.WriteLine(newInheritor.CustomMethod1);


      Base newBase = new Base();
      newBase.CustomMethod2();

      // if we run this program now it should give us

      // second Output

      // result 1

      // Custom output

      // we succesfully overrode the second output to a new one
    }
  }
}
