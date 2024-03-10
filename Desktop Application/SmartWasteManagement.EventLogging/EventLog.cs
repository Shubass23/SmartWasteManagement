using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace SmartWasteManagement.EventLogging
{
    [BsonIgnoreExtraElements]
    public class EventLog
    {
        const string ConnectionString = "mongodb://localhost:27017";
        const string DatabaseName = "smart_waste_management";
        const string CollectionName = "event_logging";
        IMongoDatabase database { get; set; }
        MongoClient mongoclient { get; set; }
        IMongoCollection<EventMessageModel> collection { set; get; }

        public EventLog()
        {
            // Setup mongo client handler
            mongoclient = new MongoClient(ConnectionString);
            database = mongoclient.GetDatabase(DatabaseName);
            collection = database.GetCollection<EventMessageModel>(CollectionName);
        }

        public void PushEventLog(EventMessageModel loggingModel)
        {
            Task.Run(() =>
            {
                loggingModel.Timestamp = loggingModel.Timestamp.AddHours(8);
                collection.InsertOne(loggingModel);
            });
        }

        public List<EventMessageModel> GetLatestEventLog(int total_entries)
        {
            var filter = Builders<EventMessageModel>.Filter.Empty;
            var sort = Builders<EventMessageModel>.Sort.Descending(a => a.Timestamp);

            List<EventMessageModel> documents = collection
                .Find(filter)
                .Sort(sort)
                .Limit(total_entries)
                .ToList();

            return documents;
        }

        public List<EventMessageModel> GetLogByDate(DateTime dateTime)
        {
            var filter = Builders<EventMessageModel>.Filter.Gt(x => x.Timestamp, dateTime);
            var sort = Builders<EventMessageModel>.Sort.Ascending(x => x.Timestamp);
            return collection.Find(filter).Sort(sort).ToList();
        }

        public void Purge()
        {
            var filter = Builders<EventMessageModel>.Filter.Empty;
            collection.DeleteMany(filter);
        }
    }
}