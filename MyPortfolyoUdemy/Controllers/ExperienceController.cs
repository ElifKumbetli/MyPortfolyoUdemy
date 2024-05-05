using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    //Deneyim
    public class ExperienceController : Controller
    {
        MyPortfolioContext contex = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = contex.Experiences.ToList();
            return View(values);
        }


        [HttpGet]//Sayfa ilk açıldığında çalışacak

        public IActionResult CreatExperience()
        {
            return View();
        }

        [HttpPost] //Satfada bir butona basıldığında çalışacak,buton tetiklendiğinde
        public IActionResult CreatExperience(Experience experience)
        {
            contex.Experiences.Add(experience);
            contex.SaveChanges();//Değişiklikleri kaydet
            return RedirectToAction("ExperienceList");//Tekrar buraya yönlendir
        }

        public IActionResult DeleteExperience(int id)//silme işlemi id ye göre
        {
            var value = contex.Experiences.Find(id);//silinecek şeyi bul
            contex.Experiences.Remove(value);//Valueden gelen değeri sil
            contex.SaveChanges();//Değişiklikleri kayıt et
            return RedirectToAction("ExperienceList");//ExperienceList e yönlendir
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = contex.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            contex.Experiences.Update(experience);
            contex.SaveChanges();//Değişiklikleri kaydet
            return RedirectToAction("ExperienceList");
        }
    }
}
