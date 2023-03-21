using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.ViewModels
{
    public class MusicPlayViewModel : INotifyPropertyChanged
    {
        readonly IDispatcher dispatcher;
        IAudioPlayer audioPlayer;
        IAudioManager audioManager;
        TimeSpan animationProgress;
        bool isPositionChangeSystemDriven;
        bool isDisposed;

        public MusicPlayViewModel()
        {
            //this.audioManager = audioManager;
            this.dispatcher = Dispatcher.GetForCurrentThread();
            audioManager = AudioManager.Current;
            Audio();
            PlayCommand = new Command(Play);
            PauseCommand = new Command(Pause);
            StopCommand = new Command(Stop);
        }

        public double CurrentPosition
        {
            get => audioPlayer?.CurrentPosition ?? 0;
            set
            {
                if (audioPlayer is not null &&
                    audioPlayer.CanSeek &&
                    isPositionChangeSystemDriven is false)
                {
                    audioPlayer.Seek(value);
                }
            }
        }

        public double Volume
        {
            get => audioPlayer?.Volume ?? 1;
            set
            {
                if (audioPlayer != null)
                {
                    audioPlayer.Volume = value;
                }
            }
        }

        public double Speed
        {
            get => audioPlayer?.Speed ?? 1;
            set
            {
                try
                {
                    if (audioPlayer?.CanSetSpeed ?? false)
                    {
                        audioPlayer.Speed = Math.Round(value, 1, MidpointRounding.AwayFromZero);
                        NotifyPropertyChanged();
                    }
                }
                catch (Exception ex)
                {
                    App.Current.MainPage.DisplayAlert("Speed", ex.Message, "OK");
                }
            }
        }

        public double MinimumSpeed => audioPlayer?.MinimumSpeed ?? 1;
        public double MaximumSpeed => audioPlayer?.MaximumSpeed ?? 1;

        public bool CanSetSpeed => audioPlayer?.CanSetSpeed ?? false;

        public Command PlayCommand { get; set; }
        public Command PauseCommand { get; set; }
        public Command StopCommand { get; set; }

        public double Duration => audioPlayer?.Duration ?? 1;


        public async Task Audio()
        {
            audioPlayer = audioManager.CreatePlayer(
                            await FileSystem.OpenAppPackageFileAsync("audio.mp3"));
            NotifyPropertyChanged(nameof(Duration));
            NotifyPropertyChanged(nameof(CanSetSpeed));
            NotifyPropertyChanged(nameof(MinimumSpeed));
            NotifyPropertyChanged(nameof(MaximumSpeed));
            audioPlayer.Stop();
        }

        public bool IsPlaying => audioPlayer?.IsPlaying ?? false;

        public void Play()
        {
            audioPlayer.Play();
            UpdatePlaybackPosition();
            NotifyPropertyChanged(nameof(IsPlaying));
        }

        void Pause()
        {
            if (audioPlayer.IsPlaying)
            {
                audioPlayer.Pause();
            }
            else
            {
                audioPlayer.Play();
            }

            UpdatePlaybackPosition();
            NotifyPropertyChanged(nameof(IsPlaying));
        }

        public TimeSpan AnimationProgress
        {
            get => animationProgress;
            set
            {
                animationProgress = value;
                NotifyPropertyChanged();
            }
        }

        void Stop()
        {
            if (audioPlayer.IsPlaying)
            {
                audioPlayer.Stop();

                AnimationProgress = TimeSpan.Zero;
                NotifyPropertyChanged(nameof(IsPlaying));
            }
        }

        void UpdatePlaybackPosition()
        {
            if (audioPlayer?.IsPlaying is false)
            {
                return;
            }

            dispatcher.DispatchDelayed(
                TimeSpan.FromMilliseconds(16),
                () =>
                {
                    Console.WriteLine($"{CurrentPosition} with duration of {Duration}");

                    isPositionChangeSystemDriven = true;
                    NotifyPropertyChanged(nameof(CurrentPosition));
                    isPositionChangeSystemDriven = false;

                    UpdatePlaybackPosition();
                });
        }
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
    

