using MongoDB.Driver;
using SmartWasteManagement.Main.Database.Model;
using SmartWasteManagement.Main.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWasteManagement.Main.Database.Query
{
    public class UserCredentialQuery
    {
        const string CollectionName = "user_credential";
        MongoDBHandler db_handler { get; set; }
        IMongoCollection<UserCredentialModel> db_collection { get; set; }

        public UserCredentialQuery(MongoDBHandler handler)
        {
            db_handler = handler;
            db_collection = db_handler.Database.GetCollection<UserCredentialModel>(CollectionName);
        }

        // ==================

        public bool UserExistByName(string firstName)
        {
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.FirstName, firstName);
            var documents = db_collection.Find(filter);
            var total = documents.CountDocuments();

            if (total == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UserExistByID(string user_id)
        {
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_id);
            var documents = db_collection.Find(filter);
            var total = documents.CountDocuments();

            if (total == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public UserCredentialModel GetUserInfo(string user_id)
        {
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_id);
            var user_info = db_collection.Find(filter);
            var total_output = user_info.CountDocuments();

            if (total_output == 0)
            {
                return new UserCredentialModel();
            }
            else
            {
                return user_info.First();
            }
        }

        public List<UserCredentialModel> GetUserList()
        {
            var filter = Builders<UserCredentialModel>.Filter.Empty;
            var user_info = db_collection.Find(filter).ToList();

            return user_info;
        }

        public bool AddNewUser(string user_id, string firstName, string lastName, string password)
        {
            // Check if user exist
            bool user_exist = UserExistByID(user_id);
            if (user_exist)
            {
                return false;
            }

            // Create document for new user
            var document = new UserCredentialModel
            {
                UserID = user_id,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                LastLogin = DateTime.Now,
                LastLogout = DateTime.Now,
                CreationDate = DateTime.Now
            };

            // Push new user data to database
            bool push_success;
            try
            {
                db_collection.InsertOne(document);
                push_success = true;
            }
            catch
            {
                push_success = false;
            }

            return push_success;
        }

        public bool AddNewUser(UserCredentialModel user_data)
        {
            // Check if user exist
            bool user_exist = UserExistByID(user_data.UserID);
            if (user_exist)
            {
                return false;
            }

            // Push new user data to database
            bool push_success;
            try
            {
                db_collection.InsertOne(user_data);
                push_success = true;
            }
            catch
            {
                push_success = false;
            }

            return push_success;
        }

        public bool EditUser(string user_id, string firstName = null, string lastName = null, string password = null)
        {
            // Find the document based on user ID
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_id);
            var result = db_collection.Find(filter);
            var count = result.CountDocuments();
            if (count == 0 || count > 1)
            {
                return false;
            }

            // Get the document and update the data
            var document = Builders<UserCredentialModel>.Update;
            var updates = new List<UpdateDefinition<UserCredentialModel>>();
            if (firstName != null)
            {
                updates.Add(document.Set(x => x.FirstName, firstName));
            }
            if (lastName != null)
            {
                updates.Add(document.Set(x => x.LastName, lastName));
            }
            if (password != null)
            {
                updates.Add(document.Set(x => x.Password, password));
            }

            // Update the document at the database
            bool push_success;
            try
            {
                db_collection.UpdateMany(filter, document.Combine(updates));
                push_success = true;
            }
            catch
            {
                push_success = false;
            }

            return push_success;
        }

        public bool EditUser(UserCredentialModel user_data)
        {
            // Find the document based on user ID
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_data.UserID);
            var result = db_collection.Find(filter);
            var count = result.CountDocuments();
            if (count == 0 || count > 1)
            {
                return false;
            }

            // Get the document and update the data
            var document = Builders<UserCredentialModel>.Update
                .Set(a => a.FirstName, user_data.FirstName)
                .Set(a => a.LastName, user_data.LastName)
                .Set(a => a.UserID, user_data.UserID)
                .Set(a => a.Password, user_data.Password);

            // Update the document at the database
            bool push_success;
            try
            {
                db_collection.UpdateOne(filter, document);
                push_success = true;
            }
            catch
            {
                push_success = false;
            }

            return push_success;
        }

        public bool RemoveUser(string user_id)
        {
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_id);
            var result = db_collection.Find(filter);
            var count = result.CountDocuments();

            if (count == 0 || count > 1) // 
            {
                return false;
            }
            else
            {
                db_collection.DeleteOne(filter);
            }

            // Delete filtered document
            bool success;
            try
            {
                db_collection.DeleteOne(filter);
                success = true;
            }
            catch
            {
                success = false;
            }

            return success;
        }

        public bool UpdateLoginTime(string user_id, DateTime? time = null)
        {
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_id);
            var count = db_collection.Find(filter).CountDocuments();
            if (count == 0 || count > 1)
            {
                return false;
            }

            // Get the document and update the data
            var document = Builders<UserCredentialModel>.Update;
            var updates = new List<UpdateDefinition<UserCredentialModel>>();
            if (time == null)
            {
                updates.Add(document.Set(x => x.LastLogin, DateTime.Now));
            }
            else
            {
                updates.Add(document.Set(x => x.LastLogin, time));
            }

            // Update the document at the database
            bool push_success;
            try
            {
                db_collection.UpdateOne(filter, document.Combine(updates));
                push_success = true;
            }
            catch
            {
                push_success = false;
            }

            return push_success;
        }

        public bool UpdateLogoutTime(string user_id, DateTime? time = null)
        {
            var filter = Builders<UserCredentialModel>.Filter.Eq(x => x.UserID, user_id);
            var count = db_collection.Find(filter).CountDocuments();
            if (count == 0 || count > 1)
            {
                return false;
            }

            // Get the document and update the data
            var document = Builders<UserCredentialModel>.Update;
            var updates = new List<UpdateDefinition<UserCredentialModel>>();
            if (time == null)
            {
                updates.Add(document.Set(x => x.LastLogout, DateTime.Now));
            }
            else
            {
                updates.Add(document.Set(x => x.LastLogout, DateTime.Now));
            }

            // Update the document at the database
            bool push_success;
            try
            {
                db_collection.UpdateOne(filter, document.Combine(updates));
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
