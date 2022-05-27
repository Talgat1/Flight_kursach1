using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight.Mongo.Model;
using MongoDB.Bson.Serialization.Attributes;

namespace Flight_kursach.Services.Identity
{
    [BsonIgnoreExtraElements]
    public class TestSiteUser : MongoUser
    {
    }
}
