using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWeb.Entities;
using MusicWeb.Data;

namespace MusicWeb.Services
{
    public class SqlMusicData : IMusicData
    {
        private MusicDbContext _db;

        public SqlMusicData(MusicDbContext dbContext)
        {
            _db = dbContext;
        }

        public void Add(Music newMusic)
        {
            _db.Add(newMusic);
            _db.SaveChanges();
        }

        public IEnumerable<Music> GetAll()
        {
            return _db.Musics;
            //throw new NotImplementedException();
        }

        public Music GetMusic(int Id)
        {
            return _db.Find<Music>(Id);
            //throw new NotImplementedException();
        }
    }
}
