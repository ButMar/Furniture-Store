using Furniture_Store.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

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
            //tamplate1.Type = 'a';
            //tamplate1.Description = "direct";
            kTamplates.Add(tamplate1);

            var tamplate2 = new KitchensTemplate();
            //tamplate2.Type = 'b';
            //tamplate2.Description = "cornerLeft";
            kTamplates.Add(tamplate2);

            var tamplate3 = new KitchensTemplate();
            //tamplate3.Type = 'c';
            //tamplate3.Description = "cornerRight";
            kTamplates.Add(tamplate3);

            var tamplate4 = new KitchensTemplate();
            //tamplate4.Type = 'd';
            //tamplate4.Description = "pSimilar";
            kTamplates.Add(tamplate4);

            return kTamplates;
        }


       
    }
}
