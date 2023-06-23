using System.Media;

namespace Pomodoro_Manager.Model
{
    public class AudioPlayer
    {
        string _soundPath = @"../../../../Resourses/End Pomodoro Sound.wav";
        SoundPlayer _soundPlayer;
        public AudioPlayer()
        {
            _soundPlayer = new SoundPlayer(_soundPath);
        }
        public void Play()
        {
            _soundPlayer.Play();
        }
    }
}
