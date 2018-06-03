using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Digital8.Models;

namespace Digital8.Controllers
{
    public class CategoryController : ApiController
    {
        Category[] categories = new Category[]
       {
            new Category { ID = 1, Name = "FRUIT" },
            new Category { ID = 2, Name = "VEGETABLE"},
            new Category { ID = 3, Name = "MILK"},
            new Category { ID = 4, Name = "GRAIN"},
            new Category { ID = 5,  Name = "MEAT" }
       };


        public HttpResponseMessage GetProductCategory(string category = "All")
        {


            switch (category.ToLower())
            {
                case "all":
                    return Request.CreateResponse(HttpStatusCode.OK, categories.ToList());
                case "vegetable":
                    return Request.CreateResponse(HttpStatusCode.OK,
                       categories.Where(e => e.Name.ToLower() == "vegetable").ToList());
                case "fruit":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        categories.Where(e => e.Name.ToLower() == "fruit").ToList());
                case "milk":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        categories.Where(e => e.Name.ToLower() == "milk").ToList());
                case "grain":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        categories.Where(e => e.Name.ToLower() == "grain").ToList());
                case "meat":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        categories.Where(e => e.Name.ToLower() == "meat").ToList());

                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest,
                          "Value for category must be 'vegetable','fruit','milk','grain','meat', or All. " + category + " is invalid.");
            }
        }
    }
}
            //public IHttpActionResult Index(string searchString)
            //{
            //    using (Digital8DatbaseEntities entities = new Digital8DatbaseEntities())
            //    {
            //        var product = entities.Products.FirstOrDefault(p => p.Category == searchString);
            //        if (product == null)
            //        {
            //            return NotFound();
            //        }
            //        return Ok(product);
            //    }
            //}


        
    
