using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace LinuxShop.Mongodb
{
    public class MongoDbHelper
    {
        //Mongodb连接
        //private MongoServerAddress mongodbAddress = null;
        private  MongoClientSettings mongodbClientSettings = new MongoClientSettings();
        private MongoClient client;

        public MongoDbHelper(string address= "120.26.106.144",int port = 27017)
        {
            MongoServerAddress mongodbAddress = new MongoServerAddress("120.26.106.144", 27017);
            mongodbClientSettings.Server = mongodbAddress;
            client = new MongoDB.Driver.MongoClient(mongodbClientSettings);
        }
        /// <summary>
        /// 数据库集合
        /// </summary>
        public IMongoDatabase MongoDatabase
        {
            get {
                if (!string.IsNullOrWhiteSpace(MongodbDatabaseString))
                {
                    return client.GetDatabase(MongodbDatabaseString);
                }
                else
                {
                    return client.GetDatabase("MobilePhoneShopping");
                }
            }
                
        }
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string MongodbDatabaseString{ get; set; }
        public IMongoCollection<T> GetMongodbCollection<T>(string collectionName)
        {
            return MongoDatabase.GetCollection<T>(collectionName);
            
        }
    }
}
