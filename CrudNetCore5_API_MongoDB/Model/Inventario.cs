using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5_API_MongoDB.Model
{
    public class Inventario
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("clave")]
        public string Clave { get; set; }
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }
        [BsonElement("existencia")]
        public int Existencia { get; set; }
        [BsonElement("precio")]
        public double Precio { get; set; }
        [BsonElement("costo")]
        public double Costo { get; set; }
    }
}
