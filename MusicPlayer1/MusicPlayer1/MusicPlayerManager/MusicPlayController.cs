using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer1.MusicPlayerManager
{
    public interface MusicPlayController
    {
        void setMusicPath(string musicPath);

        void Play();

        void Pause();

        void Stop();
    }
}
