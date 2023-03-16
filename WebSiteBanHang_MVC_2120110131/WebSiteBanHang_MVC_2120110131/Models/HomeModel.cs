using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSiteBanHang_MVC_2120110131.Context;

namespace WebSiteBanHang_MVC_2120110131.Models
{
    public class HomeModel
    {
        public List<Product> ListProduct { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}