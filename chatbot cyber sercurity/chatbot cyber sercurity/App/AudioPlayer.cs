using System.Media;

namespace CyberBot.App
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string path)
        {
            try
            {
                using SoundPlayer player = new SoundPlayer(path);
                player.PlaySync(); // PlaySync waits until audio is done
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error playing greeting]: {ex.Message}");
                Console.ResetColor();
            }
        }
    }

    public class SoundPlayer : IDisposable
    {
        public SoundPlayer(string path)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // TODO release managed resources here
        }

        public  SoundPlayer()
        {
            throw new NotImplementedException();
        }

        public void PlaySync()
        {
            throw new NotImplementedException();
        }
    }
}

