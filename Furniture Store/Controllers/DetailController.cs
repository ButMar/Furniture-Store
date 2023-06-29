using Furniture_Store.Model;
using Furniture_Store.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Furniture_Store.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DetailController : ControllerBase
    {
        private readonly FurnitureContext db;
        private PriceClient priceClient;

        public DetailController(FurnitureContext context)
        {
            db = context;
            priceClient = new PriceClient();
        }

        //[HttpGet(Name = "GETAllDetail")]
        //public List<Detail> GETAllDetail()
        //{
        //    DbSet<Detail> resultDBdetail = db.Details;

        //    List<Detail> detailFromDB = resultDBdetail.ToList();

        //    return detailFromDB;
        //}


        [HttpGet(Name = "GETDetail")]
        public List<DetailResponse> GETspecialDetail(string color)
        {
            List<Detail> resultDBdetail = db.Details.Where(x => x.Color == color).ToList();
            List<DetailResponse> responses = new List<DetailResponse>();

            foreach (Detail detail in resultDBdetail)
            {
                var response = new DetailResponse(detail);
                response.Price = priceClient.GetPriceAsync("https://localhost:7258/Price?price_id="+ detail.DatailId).Result.Price1;
                response.Price += 1000;
                responses.Add(response);

            }

            return responses;
        }





    }
}
