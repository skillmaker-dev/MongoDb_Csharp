using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDb
{
    internal partial class Program
    {
        public class PersonModel
        {
            [BsonId]
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public AddressModel Address { get; set; }
            [BsonElement("dob")]
            public DateTime BirthDate { get; set; }
        }
    }
}
