using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang_MVC_2120110131.Context;


namespace WebSiteBanHang_MVC_2120110131.Controllers
{
    public class Product_DetailController : Controller
    {
        /*WebsiteBanHangEntities objWebsiteBanHangEntities = new WebsiteBanHangEntities();*/

        // GET: Product_Detail
        public ActionResult Index()
        {
           /* var product= objWebsiteBanHangEntities.Product.Where(p => p.Id == Id).FirstOrDefault();*/
            return View();
        }
    }
}