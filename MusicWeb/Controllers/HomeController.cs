using Microsoft.AspNetCore.Mvc;
using MusicWeb.Services;
using MusicWeb.ViewModel;
using MusicWeb.Entities;
using System.Linq;

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
            var model = _musicData.GetAll().Select(music => new MusicViewModel { Id = music.Id, Title = music.Title, Genre = music.Genre.ToString() });
            return View(model);
        }
        public IActionResult Detail(int Id)
        {
            var model = _musicData.GetMusic(Id);
            if (model == null) return RedirectToAction("Index");
            var vmodel = new MusicViewModel { Id=model.Id,Title=model.Title,Genre= model.Genre.ToString() };
            return View(vmodel);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MusicEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Music = new Music
                {
                    Title = model.Title,
                    Genre = model.Genre
                };
                _musicData.Add(Music);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }            
        }
    }
}