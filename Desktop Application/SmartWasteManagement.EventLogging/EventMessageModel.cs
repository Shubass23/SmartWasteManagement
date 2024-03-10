using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.EventLogging
{
    [BsonIgnoreExtraElements]
    public class EventMessageModel
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string EventSource { get; set; } = "UNDEFINED";
        public string EventType { get; set; } = "UNDEFINED";
        public string UserID { get; set; } = "00";
        public string Message { get; set; } = "UNDEFINED";
    }
}