using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using PTPMQL.Models;
namespace PTPMQL.Controllers{
    public class DemoController : Controller
    {
        giaiphuongtrinh gpt= new giaiphuongtrinh();
        public IActionResult Index(){    
            return View();
        }
        [HttpPost]
        public IActionResult Index(String heSoA, string hesoB){
            // tisnh nghiem pt
            //1.Khai bao bien
           
            //2.gan gia tri gui tu view len
            double a= Convert.ToDouble(heSoA);
           double b= Convert.ToDouble(hesoB);
           string Thongbao = gpt.giaiphuongtrinhbacmot(a,b);
    
        ViewBag.mess1= Thongbao;
            return View();

        }
        [HttpPost]
          public IActionResult Create(DemoController std)
    {
    
        return View();
    }
    };
}


