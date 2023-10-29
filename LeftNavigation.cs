using Microsoft.AspNetCore.Mvc;


    public class LeftNavigation : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var links = new string[] { "Home", "Employees", "Privacy" };
            return View(links);
        }
}


