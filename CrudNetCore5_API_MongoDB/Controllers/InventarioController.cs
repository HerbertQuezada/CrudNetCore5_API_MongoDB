using CrudNetCore5_API_MongoDB.Model;
using CrudNetCore5_API_MongoDB.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5_API_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : Controller
    {
        private InventarioService _inventarioService;

        public InventarioController(InventarioService inventarioService)
        {
            _inventarioService = inventarioService;
        }

        [HttpGet]
        public ActionResult<List<Inventario>> Get() { 
            return _inventarioService.Get(); 
        }

        [HttpPost]
        public ActionResult<Inventario> Create( Inventario inventario)
        {
            _inventarioService.Create(inventario);
            return Ok(inventario);
        }
        [HttpPut]
        public ActionResult Update(Inventario inventario)
        {
            _inventarioService.Update(inventario.Id, inventario);
            return Ok();
        }   
        [HttpDelete("{Id}")]
        public ActionResult Delete(string Id)
        {
            _inventarioService.Delete(Id);
            return Ok();
        }   
    }
}
