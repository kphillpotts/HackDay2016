using System;
using System.Collections.Generic;
using AVFoundation;
using UIKit;

namespace Live
{
    public class Animals
    {
        public class Animal
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }

            public override string ToString()
            {
                return String.Format($"{Name} - {Description}");
            }
        }

        public static List<Animal> GetAnimals()
        {
            return new List<Animals.Animal>
            {
                new Animals.Animal { Name = "Face Palm Bear", Description = "Just realized he doesn't need to compile so often", Image = "1_thumbnail.png" },
                new Animals.Animal { Name = "Shocked Cat", Description = "Can't believe it's real", Image = "2_thumbnail.png" },
                new Animals.Animal { Name = "Cute Kitten", Description = "Just loves not building all the time", Image = "3_thumbnail.png" },
                new Animals.Animal { Name = "Sad Canary", Description = "Is waiting for a build", Image = "4_thumbnail.png" },
                new Animals.Animal { Name = "Doge", Description = "Just because", Image = "6_thumbnail.png" },
                new Animals.Animal { Name = "Flower Elephant", Description = "The gift of live coding", Image = "7_thumbnail.png" },
                new Animals.Animal { Name = "Sleezy Goat", Description = "Is super impressed", Image = "9_thumbnail.png" },
                new Animals.Animal { Name = "Thoughtful Gorilla", Description = "Wonders how far he can take this", Image = "10_thumbnail.png" },
                new Animals.Animal { Name = "Grumpy Cat", Description = "Is just grumpy", Image = "11_thumbnail.png" },
                new Animals.Animal { Name = "Love Hamster", Description = "Loves live coding", Image = "12_thumbnail.png" },
                new Animals.Animal { Name = "Stoned Koala", Description = "Is like 'whoa, dude!'", Image = "13_thumbnail.png" },
                new Animals.Animal { Name = "Happy Panda", Description = "Is happy", Image = "15_thumbnail.png" },
                new Animals.Animal { Name = "Angry Bird", Description = "Hey, cool name for a game", Image = "16_thumbnail.png" },
                new Animals.Animal { Name = "Shocked Racoon", Description = "OMG!", Image = "19_thumbnail.png" },
                new Animals.Animal { Name = "Naughty Mouse", Description = "Oh, what I could do with this...", Image = "20_thumbnail.png" },
            };
        }

        public static UIColor GetRandomColor()
        {
            string[] colors;
            colors = new []
            {
                "1abc9c",
                "2ecc71",
                "3498db",
                "9b59b6",
                "34495e",
                "16a085",
                "27ae60",
                "2980b9",
                "8e44ad",
                "2c3e50",
                "f1c40f",
                "e67e22",
                "e74c3c",
                "f39c12",
                "d35400",
                "c0392b"
            };

            var hexString = colors[new Random().Next(0, colors.Length)];
            int red = Int32.Parse(hexString.Substring(0, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            int green = Int32.Parse(hexString.Substring(2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            int blue = Int32.Parse(hexString.Substring(4, 2), System.Globalization.NumberStyles.AllowHexSpecifier);

            return UIColor.FromRGB(red, green, blue);
        }
    }
}

