using MAUISampleDemo.Model;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace MAUISampleDemo.View;

public partial class DataGridDemo : ContentPage
{
    private readonly HttpClient httpClient = new();

    public bool IsRefreshing { get; set; }
    public ObservableCollection<Monkey> Monkeys { get; set; } = new();
    public Command RefreshCommand { get; set; }
    public Monkey SelectedMonkey { get; set; }

    public DataGridDemo()
	{
        RefreshCommand = new Command(async () =>
        {
            // Simulate delay
            await Task.Delay(2000);
            await LoadMonkeys();
            IsRefreshing = false;
            OnPropertyChanged(nameof(IsRefreshing));
        });

        BindingContext = this;
        InitializeComponent();
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await LoadMonkeys();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Monkeys.Clear();
    }

    private async Task LoadMonkeys()
    {
        var monkeys = await httpClient.GetFromJsonAsync<Monkey[]>("https://montemagno.com/monkeys.json");

        Monkeys.Clear();

        foreach (Monkey monkey in monkeys)
        {
            Monkeys.Add(monkey);
        }
    }

    //private void LoadMonkeys()
    //{
    //    //var monkeys = await httpClient.GetFromJsonAsync<Monkey[]>("https://montemagno.com/monkeys.json");

    //    Monkeys.Clear();
    //    Monkeys.Add(new Monkey
    //    {
    //        Name = "Baboon",
    //        Location = "Africa & Asia",
    //        Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
    //        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
    //        Population = 10000
    //    });

    //    Monkeys.Add(new Monkey
    //    {
    //        Name = "Capuchin Monkey",
    //        Location = "Central & South America",
    //        Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
    //        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
    //        Population = 23000
    //    });

    //    Monkeys.Add(new Monkey
    //    {
    //        Name = "Blue Monkey",
    //        Location = "Central and East Africa",
    //        Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
    //        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg",
    //        Population = 12000
    //    });

    //    Monkeys.Add(new Monkey
    //    {
    //        Name = "Squirrel Monkey",
    //        Location = "Central & South America",
    //        Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
    //        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/saimiri.jpg",
    //        Population = 11000,
    //    });

    //    Monkeys.Add(new Monkey
    //    {
    //        Name = "Baboon",
    //        Location = "Africa & Asia",
    //        Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
    //        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
    //        Population = 10000
    //    });

    //    //Monkeys.Clear();

    //    //foreach (Monkey monkey in monkeys)
    //    //{
    //    //    Monkeys.Add(monkey);
    //    //}
    //}
}