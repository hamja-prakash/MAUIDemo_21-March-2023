using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.ViewModels
{
    public partial class EventwithTimerViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public ObservableCollection<Event> AllEvents { get; set; }

        public EventwithTimerViewModel()
        {
            AllEvents = GetEvents();
            var timer = Application.Current.Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) =>
            {
                foreach (var evt in AllEvents)
                {
                    var timespan = evt.Date - DateTime.Now;
                    evt.Timespan = timespan;
                }
            };
        }

        public ObservableCollection<Event> GetEvents()
        {
            AllEvents = new ObservableCollection<Event>();
            AllEvents.Add(new Event
            {
                EventTitle = "Camping",
                BgColor = Color.FromArgb("#EB9999"),
                //Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(12, 23, 45, 59).Ticks)
                Date = DateTime.Now.Date.AddDays(1).Add(new TimeSpan(13, 0, 0))
            });

            AllEvents.Add(new Event
            {
                EventTitle = "Tony's Wedding",
                BgColor = Color.FromArgb("#96338F"),
                Date = DateTime.Now.Date.AddDays(1).Add(new TimeSpan(14, 0, 0, 0)),
                //Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(270, 1, 22, 10).Ticks)
            });

            AllEvents.Add(new Event
            {
                EventTitle = "Hackathon",
                BgColor =  Color.FromArgb("#8251AE"),
                Date = DateTime.Now.AddDays(1).Add(new TimeSpan(17, 0, 0))
                //Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(48, 11, 15, 0).Ticks)
            });

            AllEvents.Add(new Event
            {
                EventTitle = "Exams",
                BgColor = Color.FromArgb("#6787FF"),
                Date = DateTime.Now.AddDays(1).Add(new TimeSpan(18, 0, 0))
                // Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 17, 29, 45).Ticks)
            });
            return AllEvents;
        }
    }

    public class Event
    {
        public DateTime Date { get; set; }
        public string EventTitle { get; set; }
        public TimeSpan Timespan { get; set; }
        public string Days => Timespan.Days.ToString("00");
        public string Hours => Timespan.Hours.ToString("00");
        public string Minutes => Timespan.Minutes.ToString("00");
        public string Seconds => Timespan.Seconds.ToString("00");
        public Color BgColor { get; set; }
    }
}
