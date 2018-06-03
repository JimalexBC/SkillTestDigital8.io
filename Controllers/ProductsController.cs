using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Digital8.Areas;
using Digital8.Providers;
using System.Threading;
using System.Security.Principal;

using Digital8.Models;



namespace Digital8.Controllers
{
    public class ProductsController : ApiController
    {
        //Data context for Products

        Product[] products = new Product[]
        {
            new Product { ID = 1, Name = "ORANGE", Category = "FRUIT" },
            new Product { ID = 2, Name = "PUMPKIN", Category = "VEGETABLE"},
            new Product { ID = 3, Name = "TOMATO", Category = "VEGETABLE"},
            new Product { ID = 4, Name = "STRAWBERRY", Category = "FRUIT"},
            new Product { ID = 5, Name = "YOGURT", Category = "MILK"},
            new Product { ID = 6, Name = "BREAD WHOLE GRAIN ", Category = "GRAIN"},
            new Product { ID = 7, Name = "BEEF ", Category = "MEAT" }
        };


        //public IEnumerable<Product> GetProducts()
        //{
        //    return products;
        //}


        public IHttpActionResult GetProduct(int id)
        {

            var product = products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        public HttpResponseMessage GetProducts(string category = "All")
        {


            switch (category.ToLower())
            {
                case "all":
                    return Request.CreateResponse(HttpStatusCode.OK, products.ToList());
                case "vegetable":
                    return Request.CreateResponse(HttpStatusCode.OK,
                       products.Where(e => e.Category.ToLower() == "vegetable").ToList());
                case "fruit":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        products.Where(e => e.Category.ToLower() == "fruit").ToList());
                case "milk":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        products.Where(e => e.Category.ToLower() == "milk").ToList());
                case "grain":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        products.Where(e => e.Category.ToLower() == "grain").ToList());
                case "meat":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        products.Where(e => e.Category.ToLower() == "meat").ToList());

                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest,
                          "Value for category must be 'vegetable','fruit','milk','grain','meat', or All. " + category + " is invalid.");
            }



        }
    }
}
