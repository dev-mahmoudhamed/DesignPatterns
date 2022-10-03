namespace DesignPatterns.BridgePattern
{
    class AbstractDbProvider
    {
        protected IDbProvider _dbProvider;

        public AbstractDbProvider(IDbProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }

        public virtual string Connect()
        {
            return "This is Abstract Provider " + _dbProvider.GetType().Name + "\n" + _dbProvider.ConnectToDb();
        }
    }
}