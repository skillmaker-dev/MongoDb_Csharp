using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDb
{
    internal partial class Program
    {
        public class NamesModel
        {
            [BsonId]
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
