using ExoticFruitsApp.Models;
using System.Collections.ObjectModel;

namespace ExoticFruitsApp.ViewModels
{
    public class FruitsViewModel
    {
        public ObservableCollection<Fruits> Fruits { get; set; }
        public ObservableCollection<Markets> Markets { get; set; }
        public ObservableCollection<FruitBar> FruitBar { get; set; }

        public FruitsViewModel()
        {
            Fruits = new ObservableCollection<Fruits>
            {
                new Fruits { Picture = "Durain.png", Title = "Durian Mon Tong", Price = "$19.99", BGColor = "#f5dfba" },
                new Fruits { Picture = "Papaya.png", Title = "Hawaiian Papaya", Price = "$4.55", BGColor = "#ffc599" },
                new Fruits { Picture = "Durain.png", Title = "Durian Mon Tong", Price = "$19.99", BGColor = "#f5dfba" },
                new Fruits { Picture = "Durain.png", Title = "Durian Mon Tong", Price = "$19.99", BGColor = "#f5dfba" },
                new Fruits { Picture = "Papaya.png", Title = "Hawaiian Papaya", Price = "$4.55", BGColor = "#ffc599" },
                new Fruits { Picture = "Durain.png", Title = "Durian Mon Tong", Price = "$19.99", BGColor = "#f5dfba" }
            };

            FruitBar = new ObservableCollection<FruitBar>
            {
                new FruitBar { Picture  = "Watermelon", Quantity = "+2" },
                new FruitBar { Picture  = "Strawberry", Quantity = "+10" },
                new FruitBar { Picture  = "Mango", Quantity = "+4" }
            };

            Markets = new ObservableCollection<Markets>
            {
                new Markets { Picture = "Market1.jpg", Title = "24/7 Fruit Market", Schedule = "00:00 - 24:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market2.jpg", Title = "Fruit Valley", Schedule = "04:00 - 21:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market3.jpg", Title = "Brooklyn Fruit Valleyg", Schedule = "09:00 - 21:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market1.jpg", Title = "24/7 Fruit Market", Schedule = "00:00 - 24:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market2.jpg", Title = "Fruit Valley", Schedule = "04:00 - 21:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market3.jpg", Title = "Brooklyn Fruit Valleyg", Schedule = "09:00 - 21:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market1.jpg", Title = "24/7 Fruit Market", Schedule = "00:00 - 24:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market2.jpg", Title = "Fruit Valley", Schedule = "04:00 - 21:00", Description = "⭐ 4.9 | 📍 3 km" },
                new Markets { Picture = "Market3.jpg", Title = "Brooklyn Fruit Valleyg", Schedule = "09:00 - 21:00", Description = "⭐ 4.9 | 📍 3 km" }
            };
        }
    }
}
