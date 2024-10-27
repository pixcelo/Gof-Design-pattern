namespace GofDesignPattern.Facade
{
    public class Database
    {
        private static readonly Dictionary<string, Dictionary<string, string>> properties = new()
        {
            { "mailData", new Dictionary<string, string > { { "example@eg.com", "Tom" } } },
            { "userData", new Dictionary<string, string > { { "Tom", "example@eg.com" } } }
        };

        private Database()
        {
        }

        public static Dictionary<string, string>? GetProperties(string dbName)
        {
            if (properties.ContainsKey(dbName))
            {
                return properties[dbName];
            }
           
            return null;
        }
    }
}
