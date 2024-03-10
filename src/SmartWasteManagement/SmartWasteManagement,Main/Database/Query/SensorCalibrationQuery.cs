using MongoDB.Driver;
using SmartWasteManagement.Main.Database;
using SmartWasteManagement.Main.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.Main.Database.Query
{
    public class SensorCalibrationQuery
    {
        const string CollectionName = "sensors_calibration";
        MongoDBHandler db_handler { get; set; }
        IMongoCollection<SensorCalibrationModel> db_collection { get; set; }

        public SensorCalibrationQuery(MongoDBHandler handler)
        {
            db_handler = handler ;
            db_collection = db_handler.Database.GetCollection<SensorCalibrationModel>(CollectionName);
        }

        // ==================

        public List<SensorCalibrationModel> GetAllSensorsCalibrations()
        {
            var filter = Builders<SensorCalibrationModel>.Filter.Empty;
            var sort = Builders<SensorCalibrationModel>.Sort.Descending(a => a.CalibrationDate);

            var documents = db_collection.Find(filter).Sort(sort).ToList();

            return documents;
        }

        public SensorCalibrationModel GetLatestSensorsCalibration()
        {
            var filter = Builders<SensorCalibrationModel>.Filter.Empty;
            var sort = Builders<SensorCalibrationModel>.Sort.Descending(a => a.CalibrationDate);

            var documents = db_collection.Find(filter).Sort(sort).First();

            return documents;
        }

        public bool PushSensorCalibration(SensorCalibrationModel calib)
        {
            bool push_success;
            try
            {
                db_collection.InsertOne(calib);
                push_success = true;
            }
            catch
            {
                push_success = false;
            }
            return push_success;
        }
    }
}
