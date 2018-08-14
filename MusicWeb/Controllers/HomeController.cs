using Microsoft.AspNetCore.Mvc;
using MusicWeb.Services;

namespace MusicWeb.Controllers
{
    public class HomeController:Controller
    {
        private IMusicData _musicData;
        public HomeController(IMusicData musicData)
        {
            _musicData = musicData;
        }
        public ViewResult Index()
        {
            return View(_musicData.GetAll());
        }
    }
}