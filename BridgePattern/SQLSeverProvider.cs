namespace DesignPatterns.BridgePattern
{
    class SQLSeverProvider : IDbProvider
    {
        public string ConnectToDb()
        {
            return "Connected to SQL Server Database..";
        }
    }
}