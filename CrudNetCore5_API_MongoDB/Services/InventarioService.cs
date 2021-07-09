using CrudNetCore5_API_MongoDB.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5_API_MongoDB.Services
{
    public class InventarioService
    {
        private IMongoCollection<Inventario> _inventario;
        public InventarioService(IConnectionStrings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var dataBase = cliente.GetDatabase(settings.Database);
            _inventario = dataBase.GetCollection<Inventario>(settings.Collection);
        }
        public List<Inventario> Get()
        {
            return _inventario.Find(x => true).ToList();
        }

        public Inventario Create(Inventario inventario)
        {
            _inventario.InsertOne(inventario);
            return inventario;
        }
        public void Update(string Id, Inventario inventario)
        {
            _inventario.ReplaceOne(x => x.Id == Id, inventario);
        }
        public void Delete(string Id)
        {
            _inventario.DeleteOne(x => x.Id == Id);
        }
    }
}
