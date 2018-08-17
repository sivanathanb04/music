using MusicWeb.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MusicWeb.Services
{
    public class MockMusicData : IMusicData
    {
        private List<Music> _songs;
        public MockMusicData()
        {
            _songs = new List<Music>
            {
                new Music{Id=1,Title="Back Street Boys",Genre=Models.Genres.Jazz},
                new Music{ Id=2,Title="Aqua",Genre=Models.Genres.Pop},
                new Music{Id=3,Title="Amine",Genre=Models.Genres.Classic }
            };
        }

        public void Add(Music newMusic)
        {
            newMusic.Id = _songs.Max(v => v.Id)+1;
            _songs.Add(newMusic);
        }

        public IEnumerable<Music> GetAll()
        {
            return _songs;
        }

        public Music GetMusic(int Id)
        {
            return _songs.FirstOrDefault(v=>v.Id==Id);
        }
    }
}
