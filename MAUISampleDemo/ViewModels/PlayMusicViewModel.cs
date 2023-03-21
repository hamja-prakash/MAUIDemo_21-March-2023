using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;
using System.ComponentModel;

namespace MAUISampleDemo.ViewModels
{
    //public class PlayMusicViewModel : INotifyPropertyChanged
    //{
    //    readonly IDispatcher dispatcher;
    //    IAudioPlayer audioPlayer;
    //    IAudioManager audioManager;
    //    TimeSpan animationProgress;
    //    bool isPositionChangeSystemDriven;
    //    bool isDisposed;

    //    public PlayMusicViewModel()
    //    {
    //        //this.audioManager = audioManager;
    //        this.dispatcher = Microsoft.Maui.Dispatching.Dispatcher.GetForCurrentThread();
    //        audioManager = AudioManager.Current;
    //        IsPlaying = false;
    //        Duration = 1;
    //        Audio();
    //    }

    //    public async Task Audio()
    //    {
    //        audioPlayer = audioManager.CreatePlayer(
    //                        await FileSystem.OpenAppPackageFileAsync("audio.mp3"));
    //        Duration = audioPlayer.Duration;
    //    }

    //    public bool isPlaying;

    //    public TimeSpan animationprogress;

    //    public double duration;
    //    // public double Duration => audioPlayer?.Duration ?? 1;

    //    private double _currentPosition = 0;

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public double CurrentPosition
    //    {
    //        get { return _currentPosition; }
    //        set { SetProperty(ref _currentPosition, value); }
    //    }
    //    //public double CurrentPosition
    //    //{
    //    //    get => audioPlayer?.CurrentPosition ?? 0;
    //    //    set
    //    //    {
    //    //        if (audioPlayer is not null &&
    //    //            audioPlayer.CanSeek &&
    //    //            isPositionChangeSystemDriven is false)
    //    //        {
    //    //            audioPlayer.Seek(value);
    //    //        }
    //    //    }
    //    //}

    //    [RelayCommand]
    //    public void Play()
    //    {
    //        audioPlayer.Play();

    //        UpdatePlaybackPosition();
    //        IsPlaying = true;
    //    }

    //    [RelayCommand]
    //    void Pause()
    //    {
    //        if (audioPlayer.IsPlaying)
    //        {
    //            audioPlayer.Pause();
    //        }
    //        else
    //        {
    //            audioPlayer.Play();
    //        }

    //        UpdatePlaybackPosition();
    //        IsPlaying = false;
    //    }

    //    [RelayCommand]
    //    void Stop()
    //    {
    //        if (audioPlayer.IsPlaying)
    //        {
    //            audioPlayer.Stop();

    //            Animationprogress = TimeSpan.Zero;

    //            IsPlaying = false;
    //        }
    //    }

    //    void UpdatePlaybackPosition()
    //    {
    //        if (audioPlayer?.IsPlaying is false)
    //        {
    //            return;
    //        }

    //        dispatcher.DispatchDelayed(
    //            TimeSpan.FromMilliseconds(16),
    //            () =>
    //            {
    //                Console.WriteLine($"{CurrentPosition} with duration of {Duration}");

    //                isPositionChangeSystemDriven = true;

    //                isPositionChangeSystemDriven = false;

    //                UpdatePlaybackPosition();
    //            });
    //    }
    //}

    //protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}

    //public event PropertyChangedEventHandler PropertyChanged;
}
