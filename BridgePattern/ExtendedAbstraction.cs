namespace DesignPatterns.BridgePattern
{
    class ExtendedAbstraction : AbstractDbProvider
    {
        public ExtendedAbstraction(IDbProvider dbProvider) : base(dbProvider)
        {
        }

        public override string Connect()
        {
            return "This is Extended provider " + _dbProvider.GetType().Name + "\n" + _dbProvider.ConnectToDb();
        }
    }
}