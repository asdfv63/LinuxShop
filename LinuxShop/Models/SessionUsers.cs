using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace LinuxShop.Models
{
    [BsonIgnoreExtraElements]
    public class SessionUsers:Users
    {
        public string SessionId { get; set; }
        public DateTime ExpireTime { get; set; }
        public Role Role { get; set; }
        public List<Permission> Permission { get; set; }
    }
}
