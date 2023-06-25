using Furniture_Store.Model;
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

        public DetailController(FurnitureContext context)
        {
            db = context;
        }

        //[HttpGet(Name = "GETAllDetail")]
        //public List<Detail> GETAllDetail()
        //{
        //    DbSet<Detail> resultDBdetail = db.Details;

        //    List<Detail> detailFromDB = resultDBdetail.ToList();

        //    return detailFromDB;
        //}


        [HttpGet(Name = "GETDetail")]
        public List<Detail> GETspecialDetail(string color)
        {
            List<Detail> resultDBdetail = db.Details.Where(x => x.Color == color).ToList();

            return resultDBdetail;

        }





    }
}
