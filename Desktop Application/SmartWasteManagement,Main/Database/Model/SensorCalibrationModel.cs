using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.Main.Database.Model
{
    [BsonIgnoreExtraElements]
    public class SensorCalibrationModel
    {
        public DateTime CalibrationDate;

        public Sensor ThresholdVal;
    }

    public class Sensor
    {
        public double UltrasonicSensorVal;

        public double MethaneSensorVal;

        public double AmmoniaSensorVal;
    }
}
