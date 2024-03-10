using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.Main.Database.Model
{
    [BsonIgnoreExtraElements]
    public class SensorsReadingModel
    {
        public DateTime CreatedDate;

        public Sensor Reading;

        public SensorsReadingModel(DateTime CreatedDate, double ultrasonicVal, double methaneVal, double ammoniaVal)
        {
            this.CreatedDate = CreatedDate;
            this.Reading = new Sensor
            {
                UltrasonicSensorVal = ultrasonicVal,
                MethaneSensorVal = methaneVal,
                AmmoniaSensorVal = ammoniaVal
            };
        }
    }
}
