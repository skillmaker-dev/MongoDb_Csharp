using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MongoDb
{
    internal partial class Program
    {
        public class MongoClass
        {
            private IMongoDatabase db;

            public MongoClass(string database)
            {
                var client = new MongoClient();
                db = client.GetDatabase(database);
  
            }

            public void InsertRecord<T>(string table,T record)
            {
                var collection = db.GetCollection<T>(table);
                collection.InsertOne(record);

            }

            public List<T> GetAllRecords<T> (string table)
            {
                var collection = db.GetCollection<T>(table);
                return collection.Find(new BsonDocument()).ToList();
            }

            public T GetRecordById<T> (string table,Guid id)
            {
                var collection = db.GetCollection<T>(table);
                var filter = Builders<T>.Filter.Eq("Id",id);
                var filteredList = collection.Find(filter).FirstOrDefault();

                return filteredList;
            }

            public void UpsertRecord<T>(string table,Guid id,T record)
            {
                var collection = db.GetCollection<T>(table);
                var result = collection.ReplaceOne(new BsonDocument("_id", id), record, new ReplaceOptions { IsUpsert = true });

            }

            public void DeleteRecord<T>(string table,Guid id)
            {
                var collection = db.GetCollection<T>(table);
                var filter = Builders<T>.Filter.Eq("Id", id);
                collection.DeleteOne(filter);
            }
        }
    }
}
