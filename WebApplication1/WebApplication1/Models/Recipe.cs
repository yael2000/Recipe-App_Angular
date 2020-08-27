using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Recipe
    {
        public string Rname { get; set; }
        public Category Rcategory { get; set; }
        public int Rtimer { get; set; }
        public int Rlevel { get; set; }
        public DateTime Rdate { get; set; }
        public List<string> Ringredients { get; set; }
        public List<string> Rpreparation { get; set; }
        public string RUcode { get; set; }
        public string Rpicture { get; set; }
        public bool Rshow { get; set; }
    }
}