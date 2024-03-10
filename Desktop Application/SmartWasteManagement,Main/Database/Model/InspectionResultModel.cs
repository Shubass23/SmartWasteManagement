using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.Main.Database.Model
{
    [BsonIgnoreExtraElements]
    public class InspectionResultModel
    {
        public DateTime? CreatedDate { get; set; }
        public string? ImageName { get; set; }
        public string? Result { get; set; }

        public InspectionResultModel(DateTime CreatedDate, string ImageName, string Result) 
        { 
            this.CreatedDate = CreatedDate;
            this.ImageName = ImageName;
            this.Result = Result;
        }
    }
}

