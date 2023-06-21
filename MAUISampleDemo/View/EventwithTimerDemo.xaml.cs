using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class EventwithTimerDemo : ContentPage
{
    [Obsolete]
    public EventwithTimerDemo()
	{
		InitializeComponent();
        Setup();
    }

    private List<Event> AllEvents { get; set; }

    private List<Event> GetEvents()
    {
        return new List<Event>()
            {
                new Event
                {
                    EventTitle = "Camping",
                    BgColor = Color.FromArgb("#EB9999"),
                    Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(12, 23, 45, 59).Ticks)
                },

                new Event
                {
                    EventTitle = "Tony's Wedding",
                    BgColor = Color.FromArgb("#96338F"),
                    Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(270, 1, 22, 10).Ticks)
                },

                new Event
                {
                    EventTitle = "Hackathon",
                    BgColor = Color.FromArgb("#8251AE"),
                    Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(48, 11, 15, 0).Ticks)
                },

                new Event
                { 
                    EventTitle = "Exams",
                    BgColor = Color.FromArgb("#6787FF"),
                    Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 17, 29, 45).Ticks)
                },
            };
    }

    [Obsolete]
    private void Setup()
    {
        AllEvents = GetEvents();
        eventList.ItemsSource = AllEvents;
        Device.StartTimer(new TimeSpan(0, 0, 1), () =>
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                foreach (var evt in AllEvents)
                {
                    var timespan = evt.Date - DateTime.Now;
                    evt.Timespan = timespan;
                }
                eventList.ItemsSource = null;
                eventList.ItemsSource = AllEvents;
            });
            return true;
        });
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
