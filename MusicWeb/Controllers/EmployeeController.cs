using Microsoft.AspNetCore.Mvc;


namespace MusicWeb.Controllers
{

    public class EmployeeController:Controller
    {

        public string Name() { return "Jonas"; }


        public ContentResult Nom()
        {
            return Content("Jonas");
        }

        public string Country() { return "Sweden"; }

        public string Index()
        {
            return "Hello from Employee";
        }
    }
}