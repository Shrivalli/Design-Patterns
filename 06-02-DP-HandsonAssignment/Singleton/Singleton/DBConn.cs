namespace Singleton
{
    public sealed class DBConn
    {
       
        private static readonly DBConn instance = new DBConn();

        private DBConn()
        {

        }
        public static DBConn getInstance()
        {    
                return instance;   
        }

    }
}
