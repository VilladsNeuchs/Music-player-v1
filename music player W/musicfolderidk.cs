namespace music_player_W;
using System.IO;
using NAudio;
using NAudio.Wave;
public class musicfolderidk
{
    static string musicFolder = @"C:\Users\u55894\OneDrive - Syddansk Erhvervsskole\Desktop\Music";
    static string[] songs = Directory.GetFiles(musicFolder, "*.mp3");

    public musicfolderidk()
    {
        if (songs.Length == 0)
        {
            Console.WriteLine("No MP3 files found in the folder.");
            return;
        }
    }
    bool manualskip = false;
    static int currentSong = 0;
    private AudioFileReader audiofile = new AudioFileReader(songs[currentSong]);
    WaveOutEvent output = new WaveOutEvent();
}
