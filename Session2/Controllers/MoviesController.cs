using Microsoft.AspNetCore.Mvc;

namespace Session2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetMovie(int id, string Name)
        {
            //return $"Movie With Id: {id}";

            //ContentResult result = new ContentResult();
            //result.Content = $"Movie With Id: {id}";
            //return result;
            return Content($"Movie With Id: {id}"); //Helper Method Inherted From ControllerBased

        }
        //[ActionName("Index")]
        //[HttpGet]
        public IActionResult TestRedirectToAction()
        {
            //RedirectResult result = new RedirectResult("URL");
            //return result;
            //return Redirect("URL");
            return RedirectToAction("GetMovie");
        }
        //public IActionResult TestModelBinding(int id , string tittle ,Movie movie) 
        //{
        //    return View(Movie);
        //}

        public IActionResult TestModelBindingFromRequest([FromBody] Movie movie)
        {
            return View(movie);
        }
    }
}
