using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Furniture_Store.Model;
using Microsoft.EntityFrameworkCore.Storage;



namespace Furniture_Store.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class CalculateController : ControllerBase
    {

        [HttpGet  (Name = "GETCalculate")]
        public object GETCalculate(string type, [Range(800, 2000)] int aSideLeft, [Range(2000, 10000)]  int bSideCentre, [Range(800, 10000)]  int cSideRight)
        {
            var sizeInfo = new Calculate();

            if (ModelState.IsValid)
            {
                sizeInfo.ASideLeft = aSideLeft - 600;
                sizeInfo.BSideCentre = bSideCentre - 2000;
                sizeInfo.CSideRight = cSideRight - 600;
                return Content ($"aSideLeft = {sizeInfo.ASideLeft}, " +
                               $"bSideCentre = {sizeInfo.BSideCentre}, " + 
                               $"cSideRight = {sizeInfo.CSideRight} ");
            }
            else
            {
                return Content ($"the size are not correct");
            }


            //if (type == "d")
            //{
            //    if (aSideLeft > 800 && bSideCentre > 2000 && cSideRight > 800)
            //    {
            //        sizeInfo.aSideLeft = aSideLeft - 600;
            //        sizeInfo.bSideCentre = bSideCentre - 2000;
            //        sizeInfo.cSideRight = cSideRight - 600;
            //    }
            //}

            //return sizeInfo;

        }


    }
}


