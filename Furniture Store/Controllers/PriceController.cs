﻿using Furniture_Store.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Furniture_Store.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PriceController : ControllerBase
    {
        private readonly PriceContext db;

        public PriceController(PriceContext context)
        {
            db = context;
        }



        [HttpGet(Name = "GETPrice")]
        public List<Price> GETPrice(string name, int sum )
        {
            List<Price> resultDBPrice = db.Price.Where(x => x.Name == name && x.Price1 > sum).ToList(); 

            return resultDBPrice;

        }

    }

}