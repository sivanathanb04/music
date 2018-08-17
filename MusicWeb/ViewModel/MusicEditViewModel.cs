using MusicWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace MusicWeb.ViewModel
{
    public class MusicEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}
