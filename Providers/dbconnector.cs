using System;
using Microsoft.Extensions.Configuration; // Use this to read the appsettings.json file
using MongoDB.Bson;
using MongoDB.Driver;

namespace Vue2Spa.Providers
{
    public abstract class dbconnector
    {
        private readonly IConfiguration configuration;
        private readonly IMongoDatabase db;

        /// <summary>
        /// Creates an instance of the connector for use in the rest of the queries
        /// Note, Can't you remove the private readonly configuration and just use the iConfig instance in the ctor
        /// </summary>
        /// <param name="iConfig"></param>
        public dbconnector(IConfiguration config)
        { 
            // Create a connection to the server
            configuration = config.GetSection("MongoSettings");

            MongoClient client = new MongoClient(configuration.GetSection("ConnectionString").Value);
            db = client.GetDatabase(configuration.GetSection("db").Value);
        }

        /// <summary>
        /// Very generic implmentation of inserting a document to the todo collection
        /// Test method to insert a document to the mongodb
        /// </summary>
        /// <param name="obj"></param>
        public void InsertDocument(BsonDocument doc)
        {
            var collection = db.GetCollection<BsonDocument>(configuration.GetSection("collection").Value);
            collection.InsertOne(doc);
        }

        public BsonDocument CreateTodoItem(string text)
        {
            // Refactor
            var doc = new BsonDocument();
            doc.Add(new BsonElement("Text", text));
            doc.Add(new BsonElement("Complete", false));
            doc.Add(new BsonElement("Guid", Guid.NewGuid()));
            
            return doc;
        }
    }
}