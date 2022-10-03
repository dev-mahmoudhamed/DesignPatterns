namespace DesignPatterns.BridgePattern
{
    class MySQLProvider : IDbProvider
    {
        public string ConnectToDb()
        {
            return "Conneted to MySQL Database";
        }
    }
}