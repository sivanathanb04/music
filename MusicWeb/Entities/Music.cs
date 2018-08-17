using MusicWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace MusicWeb.Entities
{
    public class Music
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Display(Name ="Music Genre",Description ="Choose Genre")]
        public Genres Genre { get; set; }
    }
}
