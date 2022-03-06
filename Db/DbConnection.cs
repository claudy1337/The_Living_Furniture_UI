using MongoDB.Driver;


namespace The_Living_Furniture_UI.Db
{
    public class DbConnection
    {
        private static string _connectionString = "mongodb://localhost:27017";
        private static MongoClient _client = new MongoClient(_connectionString);
        IMongoClient MongoClient = (IMongoClient)_client.GetDatabase("testFurnitured");
    }
}
