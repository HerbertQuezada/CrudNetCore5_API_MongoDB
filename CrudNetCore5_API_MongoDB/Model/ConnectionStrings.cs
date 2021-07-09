using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5_API_MongoDB.Model
{
    public class ConnectionStrings: IConnectionStrings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }
    public interface IConnectionStrings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}
