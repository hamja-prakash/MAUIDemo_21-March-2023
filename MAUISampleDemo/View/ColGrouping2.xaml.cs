using MAUISampleDemo.Model;
using MvvmHelpers;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.View;

public partial class ColGrouping2 : ContentPage
{
    public List<Animal> mAnimals;
    public ObservableCollection<Grouping<string, Animal>> mAnimalsGrouping;

    public ColGrouping2()
    {
        InitializeComponent();
        mAnimalsGrouping = new ObservableCollection<Grouping<string, Animal>>();
        mAnimals = new List<Animal>();
        BindAnimals();
    }

    public void BindAnimals()
    {
        try
        {
            mAnimals.Add(new Animal
            {
                AnimalType = "Bears",
                Name = "American Black Bear",
                Location = "North America",
                Details = "Details about the bear go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
            });

            mAnimals.Add(new Animal
            {
                AnimalType = "Bears",
                Name = "Asian Black Bear",
                Location = "Asia",
                Details = "Details about the bear go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
            });

            mAnimals.Add(new Animal
            {
                AnimalType = "Monkeys",
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Details about the monkey go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            mAnimals.Add(new Animal
            {
                AnimalType = "Monkeys",
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "Details about the monkey go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            mAnimals.Add(new Animal
            {
                AnimalType = "Monkeys",
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "Details about the monkey go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            var items = from item in mAnimals
                        orderby
                        item.AnimalType
                        group item by item.AnimalType.ToUpper().ToString() into categoryGroup
                        select new Grouping<string, Animal>(categoryGroup.Key, categoryGroup);

            foreach (var item in items)
                mAnimalsGrouping.Add(item);
            clvAnimals.ItemsSource = mAnimalsGrouping;

        }
        catch (Exception ex)
        {
            var msg = ex.Message;
        }
    }
}