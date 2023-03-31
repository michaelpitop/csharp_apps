
class GlazerCalc
{
  static void Main()
  {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        widthString = System.Console.ReadLine();
        width = double.Parse(widthString);

        heightString = System.Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * ( width + height ) * 3.25 ;
        glassArea = 2 * ( width + height ) ;
        System.Console.WriteLine( "The length of the wood is " + woodLength + "  feet") ;
        System.Console.WriteLine( "The area of the glass is " + glassArea + "  square metres") ;
  }
}
