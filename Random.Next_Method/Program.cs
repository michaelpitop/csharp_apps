using System;

public class RandomProportional : Random
{
  protected override double Sample()
  {
    return Math.Sqrt(base.Sample());
  }
  public override int Next()
  {
    return (int) (Sample() * int.MaxValue);
  }
}

public class RandomSampleDemo
{
  static void Main()
  {
    const int rows = 4, cols =6;
    const int runCount = 1000000;
    const int distGroupCount = 10;
    const double intGroupSize =
      ((double)int.MaxValue + 1.0) / (double)distGroupCount;

    RandomProportional randObj = new RandomProportional();

    int[]   intCounts = new int[ distGroupCount ];
    int[]   realCounts = new int[ distGroupCount ];


        Console.WriteLine(
            "\nThe derived RandomProportional class overrides " +
            "the Sample method to \ngenerate random numbers " +
            "in the range [0.0, 1.0]. The distribution \nof " +
            "the numbers is proportional to their numeric values. " +
            "For example, \nnumbers are generated in the " +
            "vicinity of 0.75 with three times the \n" +
            "probability of those generated near 0.25.");
        Console.WriteLine(
            "\nRandom doubles generated with the NextDouble() " +
            "method:\n");

    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < cols; j++)
        Console.Write("{0,12:F8}", randObj.NextDouble());
      Console.WriteLine();
    }

      Console.WriteLine(
            "\nRandom integers generated with the Next() " +
            "method:\n");

    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < cols; j++)
        Console.Write("{0,12}", randObj.Next());
        Console.WriteLine();
    }

        Console.WriteLine(
            "\nTo demonstrate the proportional distribution, " +
            "{0:N0} random \nintegers and doubles are grouped " +
            "into {1} equal value ranges. This \n" +
            "is the count of values in each range:\n",
            runCount, distGroupCount);
        Console.WriteLine(
            "{0,21}{1,10}{2,20}{3,10}", "Integer Range",
            "Count", "Double Range", "Count");
        Console.WriteLine(
            "{0,21}{1,10}{2,20}{3,10}", "-------------",
            "-----", "------------", "-----");

    for (int i = 0; i < runCount; i++)
    {
      intCounts[ (int)((double)randObj.Next() /
        intGroupSize) ]++;
      realCounts[ (int)(randObj.NextDouble() *
    (double)distGroupCount) ]++;
    }

    for (int i = 0; i < distGroupCount; i++)
        Console.WriteLine(
                          "{0,10}-{1,10}{2,10:N0}{3,12:N5}-{4,7:N5}{5,10:N0}",
                (int)((double)i * intGroupSize),
                (int)((double)(i + 1) * intGroupSize - 1.0),
                intCounts[ i ],
                ((double)i) / (double)distGroupCount,
                ((double)(i + 1)) / (double)distGroupCount,
                realCounts[ i ]);

  }
}
