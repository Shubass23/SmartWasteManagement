using MongoDB.Driver;
using SmartWasteManagement.Main.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.Main.Database.Query
{
    public class InspectionResultQuery
    {
        const string CollectionName = "inspection_result";
        MongoDBHandler db_handler { get; set; }
        IMongoCollection<InspectionResultModel> db_collection { get; set; }

        public InspectionResultQuery(MongoDBHandler handler)
        {
            db_handler = handler;
            db_collection = db_handler.Database.GetCollection<InspectionResultModel>(CollectionName);
        }

        /// <summary>
        /// Insert inspection result data to database
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool AddResult(InspectionResultModel result)
        {
            // Push new user data to database
            bool push_success;
            try
            {
                db_collection.InsertOne(result);
                push_success = true;
            }
            catch
            {
                push_success = false;
            }

            return push_success;
        }

        /// <summary>
        /// Get list of latest inspection result sorted ascending order by creation time 
        /// </summary>
        /// <param name="max_entries"></param>
        /// <returns></returns>
        public List<InspectionResultModel> GetResultList(int max_entries = 100)
        {
            var filter = Builders<InspectionResultModel>.Filter.Empty;
            var sort = Builders<InspectionResultModel>.Sort.Descending(a => a.CreatedDate);

            var documents = db_collection
                .Find(filter)
                .Sort(sort)
                .Limit(max_entries)
                .ToList();

            return documents;
        }

        /// <summary>
        /// Get list of latest inspection result sorted ascending order by creation time 
        /// </summary>
        /// <param name="max_entries"></param>
        /// <returns></returns>
        public List<InspectionResultModel> GetResultListByDate(DateTime from_date, DateTime to_date)
        {
            var filter = Builders<InspectionResultModel>.Filter.Lte(x => x.CreatedDate, to_date) &
                Builders<InspectionResultModel>.Filter.Gte(x => x.CreatedDate, from_date);
            var sort = Builders<InspectionResultModel>.Sort.Descending(a => a.CreatedDate);
            var documents = db_collection.Find(filter).Sort(sort).ToList();

            return documents;
        }

        public void Purge()
        {
            var filter = Builders<InspectionResultModel>.Filter.Empty;
            db_collection.DeleteMany(filter);
        }
    }
}
