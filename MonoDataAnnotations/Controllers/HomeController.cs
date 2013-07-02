namespace MonoDataAnnotations.Controllers
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult WithUrlAttribute(WithUrlAttributeViewModel model)
        {
            return this.View(model);
        }

        [HttpGet]
        public ActionResult WithoutUrlAttribute(WithoutUrlAttributeViewModel model)
        {
            return this.View(model);
        }

        public class WithUrlAttributeViewModel
        {
            [Url]
            public string Url { get; set; }
        }

        public class WithoutUrlAttributeViewModel
        {
            public string Url { get; set; }
        }
    }
}