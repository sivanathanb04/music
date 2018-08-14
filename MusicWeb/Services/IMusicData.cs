using MusicWeb.Models;
using System.Collections.Generic;

namespace MusicWeb.Services
{
    public interface IMusicData
    {
        IEnumerable<Music> GetAll();
    }
}
