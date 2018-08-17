using MusicWeb.Entities;
using System.Collections.Generic;

namespace MusicWeb.Services
{
    public interface IMusicData
    {
        IEnumerable<Music> GetAll();
        Music GetMusic(int Id);
        void Add(Music newMusic);
    }
}
