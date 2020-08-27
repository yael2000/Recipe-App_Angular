using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{ 
    [EnableCors(methods:"*",headers:"*",origins:"*")]
//    [ EnableCors(methods:"*",headers:"*",origins:"*")]

    
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult check() {
              string n = "aaaaaaaaaa";
               int p = 111111;
            foreach (var index in DataBase.userList)
            {
                if (index.Upassword == p && index.Ucode == n)
                    return Ok(index);
                else if (index.Upassword != p && index.Ucode != n)
                    return Ok("User dosn't exist");
                else if (index.Upassword != p && index.Ucode == n)
                    return Ok("Incorrect password");
            }
            return null;
        }
       [HttpGet]
      public IHttpActionResult GetAllUser()
      {
            return Ok(DataBase.userList); 
      }
        [HttpGet]
       public IHttpActionResult GetAllCategory()
       {
            return Ok(DataBase.categoryList);
       }
        [HttpGet]
        public IHttpActionResult GetAllRecipe()
        {
            return Ok(DataBase.recipelist);
        }

        [HttpGet]
        public IHttpActionResult GetRecipe(string name)
        {
            foreach (var index in DataBase.recipelist)
            {
                if (index.Rname == name)
                    return Ok(index);
            }
            return null;
        }


        [HttpPost]
        public IHttpActionResult AddNewUser(User u)
        {
            DataBase.userList.Add(u);
            return Ok(true);
        }
        [HttpPost]
        public IHttpActionResult AddNewRecipe(Recipe r)
        {
            //foreach (var index in DataBase.categoryList)
            //{
            //    if (r.Rcategory.Cnane == index.Cnane)
            //        r.Rcategory = index; 
            //}
           
            DataBase.recipelist.Add(r);
            return Ok(true);
        }

        [HttpPost]
        public IHttpActionResult updateRecipe( Recipe[] listRecipe)
        {
            foreach (var index in DataBase.recipelist)
            {
                if (index.Rname == listRecipe[1].Rname)
                {
                   index.Rcategory = listRecipe[0].Rcategory;
                    index.Rdate = listRecipe[0].Rdate;
                    index.Ringredients = listRecipe[0].Ringredients;
                    index.Rlevel = listRecipe[0].Rlevel;
                    index.Rname = listRecipe[0].Rname;
                    index.Rpicture = listRecipe[0].Rpicture;
                    index.Rpreparation = listRecipe[0].Rpreparation;
                    index.Rtimer = listRecipe[0].Rtimer;
                    return Ok(index);

                }
            }
            return null;

            //    DataBase.recipelist.Add();
            //return Ok(true);
        }



    }
  
}
