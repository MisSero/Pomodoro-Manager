using Pomodoro_Manager.Properties;
using System.Media;

namespace Pomodoro_Manager.Model
{
    public class AudioPlayer
    {
        private SoundPlayer _soundPlayer;
        public AudioPlayer()
        {
            _soundPlayer = new SoundPlayer(Resources.Pomodoro_Sound);
        }
        public void Play()
        {
            _soundPlayer.Play();
        }
    }
}
