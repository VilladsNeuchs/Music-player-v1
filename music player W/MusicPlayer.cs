
using System.IO;
using NAudio;
using NAudio.Gui; 
using NAudio.Wave;

public class MusicPlayer
{
    private AudioFileReader audioFile;
    private bool manualSkip = false;
    private int currentSong = 0;
    private WaveOutEvent output;
    private string[] songs;
    

    public void Init()
    {
        var musicFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "Music"
            );
        songs = Directory.GetFiles(musicFolder, "*.mp3");
        if (songs.Length == 0)
            return;
        playSong(currentSong);
        var hello = new VolumeSlider();
    }

    private void playSong(int index)
    {
        if (output != null)
        {
            output.PlaybackStopped -= OnPlaybackStoppped; // remove event
            output.Stop();
            output.Dispose();
        }

        audioFile?.Dispose();

        audioFile = new AudioFileReader(songs[index]);
        output = new WaveOutEvent();

        output.Init(audioFile);
        output.PlaybackStopped += OnPlaybackStoppped; // reattach AFTER init
        output.Play();

    }

    private void OnPlaybackStoppped(object sender, StoppedEventArgs e)
    {
        if (manualSkip)
        {
            manualSkip = false;
            return;
        }

        currentSong++;
        if (currentSong >= songs.Length)
            currentSong = 0;
        
        playSong(currentSong);
    }

    public void Next()
    {
        currentSong++;
        if (currentSong >= songs.Length)
            currentSong = 0;
        
        playSong(currentSong);
    }

    public void Previous()
    {
        manualSkip =  true;

        currentSong--;
        if(currentSong < 0)
            currentSong = songs.Length - 1;
        
        playSong(currentSong);
    }

    public void TogglePause()
    {
        if (output.PlaybackState == PlaybackState.Playing)
            output.Pause();
        else
            output.Play();
    }

    public void forward15()
    {
        if (audioFile == null)return ;
            
        
        var newTime = audioFile.CurrentTime + TimeSpan.FromSeconds(15);
        if (newTime > audioFile.TotalTime)
            newTime = audioFile.TotalTime;

        audioFile.CurrentTime = newTime;
    }
    public void backward15()
    {
        if (audioFile == null) return;

        var newTime = audioFile.CurrentTime - TimeSpan.FromSeconds(15);
        if (newTime < TimeSpan.Zero)
            newTime = TimeSpan.Zero;

        audioFile.CurrentTime = newTime;
    }
    public TimeSpan GetCurrentTime()
    {
        return audioFile?.CurrentTime  ?? TimeSpan.Zero;
    }

    public TimeSpan GetTotalTime()
    {
        return audioFile?.TotalTime ?? TimeSpan.FromSeconds(1);
    }
    
    

    

}