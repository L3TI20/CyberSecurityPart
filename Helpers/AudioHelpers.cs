namespace CyberSecurityAwarenessBot.Helpers
{
    /// <summary>
    /// Plays the WAV voice greeting on startup.
    /// Identical behaviour to Part 1 VoiceGreeting class — same WAV file reused.
    /// </summary>
    public class AudioHelper
    {
        private const string WavFile = "C:\\Users\\L3TI\\source\\repos\\CyberSecurityPart\\GReeting.wav";

        public void PlayVoiceGreeting()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, WavFile);
                if (!File.Exists(path)) return;
                if (OperatingSystem.IsWindows()) PlayWav(path);
            }
            catch { /* fail silently */ }
        }

        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        private static void PlayWav(string path)
        {
            using var p = new System.Media.SoundPlayer(path);
            p.PlaySync();
        }
    }
}