using System.Collections.Generic;
using MusicWeb.Models;

namespace MusicWeb.Services
{
    public class MockMusicData : IMusicData
    {
        private IEnumerable<Music> _songs;
        public MockMusicData()
        {
            _songs = new List<Music>
            {
                new Music{Id=1,Title="Back Street Boys"},
                new Music{ Id=2,Title="Aqua"},
                new Music{Id=3,Title="Amine" }
            };
        }
        public IEnumerable<Music> GetAll()
        {
            return _songs;
        }
    }
}
