using MongoDB.Driver;

namespace SmartWasteManagement.Main.Database
{
    public class MongoDBHandler
    {
        string ConnectionString { get; set; } = "mongodb+srv://Shubass:test1234@cluster0.guugpkj.mongodb.net/?retryWrites=true&w=majority";
        string UserName { get; set; } = "root";
        string Password { get; set; } = "root";

        const string DatabaseName = "smart_waste_management";

        public MongoClient MongoClient { get; set; }
        public IMongoDatabase Database { get; set; }

        public MongoDBHandler(string connectionString, string userName, string password)
        {
            ConnectionString = connectionString;
            UserName = userName;
            Password = password;
            MongoClient = new MongoClient(ConnectionString);
            Database = MongoClient.GetDatabase(DatabaseName);
        }

        public MongoDBHandler(string connectionString)
        {
            ConnectionString = connectionString;
            MongoClient = new MongoClient(ConnectionString);
            Database = MongoClient.GetDatabase(DatabaseName);
        }

        public MongoDBHandler()
        {
            MongoClient = new MongoClient(ConnectionString);
            Database = MongoClient.GetDatabase(DatabaseName);
        }

        public bool IsAlive()
        {
            throw new NotImplementedException();
        }
    }
}