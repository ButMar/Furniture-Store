using Furniture_Store.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.IO;

namespace Furniture_Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KitchensTemplatesController : ControllerBase
    {

        [HttpGet(Name = "GETKitchensTemplates")]
        public List<KitchensTemplate> GETKitchensTemplates()
        {
            var kTamplates = new List<KitchensTemplate>();

            var tamplate1 = new KitchensTemplate();
            tamplate1.KitchenType = "a";
            tamplate1.KitchenDescription = "direct";
            kTamplates.Add(tamplate1);

            var tamplate2 = new KitchensTemplate();
            tamplate2.KitchenType = "b";
            tamplate2.KitchenDescription = "cornerLeft";
            kTamplates.Add(tamplate2);

            var tamplate3 = new KitchensTemplate();
            tamplate3.KitchenType = "c";
            tamplate3.KitchenDescription = "cornerRight";
            kTamplates.Add(tamplate3);

            var tamplate4 = new KitchensTemplate();
            tamplate4.KitchenType = "d";
            tamplate4.KitchenDescription = "pSimilar";
            kTamplates.Add(tamplate4);

            return kTamplates;
           //return Content($"available kitchen configurations: {tamplate1.KitchenDescription}, {tamplate2.KitchenDescription}, " +
           //    $"{tamplate3.KitchenDescription}");

        }



    }
}
