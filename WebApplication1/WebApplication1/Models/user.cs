using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public string Ucode { get; set; }
        public string Uname { get; set; }
        public string Uadress { get; set; }
        public string Umail { get; set; }
        public int Upassword { get; set; }
    }
}