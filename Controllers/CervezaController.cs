using System.Collections.Generic;
using System.Linq;
using Asp.NetCoreWebApiEx.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreWebApiEx.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CervezaController: ControllerBase
    {

        //le pasamos el metodo de acceso o nomenclatura
        [HttpGet]
        public IEnumerable<Cerveza> Get(){

            using (var db = new CervezaDBContext()){

                IEnumerable<Cerveza> cervezas = db.Cervezas.ToList();
                return cervezas;
            }
        }
    }
}