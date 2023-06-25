using Furniture_Store.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.IO;

namespace Furniture_Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KitchensTemplatesController : ControllerBase
    {
        private readonly FurnitureContext db;

        public KitchensTemplatesController(FurnitureContext context)
        {
            db = context;
        }

        //[HttpGet(Name = "GETKitchensTemplates")]
        //public List<KitchensTemplate> GETKitchensTemplates()
        //{
        //    var result = db.KitchensTemplates;

        //    return kTamplates;
           
        //}


    }
}
