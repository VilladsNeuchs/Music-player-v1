namespace music_player_W;

using System.IO;
using NAudio;
using NAudio.Wave;

public class MusicFinder
{
    static string CreateMusicFolder = @"c:\Music\";
    static string MusicFolder = @"C:\Music";
    static string[] songs;

    static MusicFinder()
    {
        Directory.CreateDirectory(CreateMusicFolder);
        songs = Directory.GetFiles(MusicFolder, "*.mp3");
    }

    public MusicFinder()
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
    
    //
    // static string CreateMusicFolder = @"c:\Music\";
    // static string MusicFolder = @"C:\Music";
    // static string[] songs = Directory.GetFiles(MusicFolder, "*.mp3");
    //
    // public MusicFinder()
    // {
    //     Directory.CreateDirectory(CreateMusicFolder);
    //     if (songs.Length == 0)
    //     {
    //         Console.WriteLine("No MP3 files found in the folder.");
    //         return;
    //     }
    // }
    //
    // bool manualskip = false;
    // static int currentSong = 0;
    // private AudioFileReader audiofile = new AudioFileReader(songs[currentSong]);
    // WaveOutEvent output = new WaveOutEvent();
}