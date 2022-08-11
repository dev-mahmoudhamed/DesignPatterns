using DesignPatterns.DecoratorPattern;

namespace DesignPatterns.ObserverPattern
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var plainText  = new PlainText("hello world");
            Console.WriteLine(plainText.getText());
            Console.WriteLine(plainText.getSize());

            var upper = new ToUpperCaseDecorator(plainText);
            Console.WriteLine(upper.getText());
            Console.WriteLine(upper.getSize());

            var upperPlus = new ToUpperWithStarsDecorator(upper);
            Console.WriteLine(upperPlus.getText());
            Console.WriteLine(upperPlus.getSize());
        }
    }
}
