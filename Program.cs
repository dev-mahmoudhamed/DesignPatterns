using DesignPatterns.DecoratorPattern;
using DesignPatterns.BuilderPattern;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(String[] args)
        {
            BuilderApp app = new();
            app.Run();
        }
    }
}
