namespace DesignPatterns.BridgePattern
{
    class BridgeApp
    {
        public static void Run()
        {
            AbstractDbProvider abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new AbstractDbProvider(new MySQLProvider());
            Console.WriteLine(abstraction.Connect());

            Console.WriteLine("***************************");

            abstraction = new ExtendedAbstraction(new SQLSeverProvider());
            Console.WriteLine(abstraction.Connect());
        }
    }
}