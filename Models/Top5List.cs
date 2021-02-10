using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sage_HW4.Models
{
    public class Top5List
    {
        //constructor for Ranking so it is read only
        public Top5List(int rank)
        {
            RestRanking = rank;
        }

        // Create attributes
        [Required]
        public int? RestRanking { get; set; }
        [Required]
        public string RestName { get; set; }
        public string? FavDish { get; set; }
        [Required]
        public string RestAddress { get; set; }
        public string? RestPhone { get; set; }
        public string? RestWebsite { get; set; } = "Coming Soon";

        public static Top5List[] GetTop5List()
        {
            //creates objects
            Top5List r1 = new Top5List(1)
            {
                RestName = "Guru's",
                FavDish = null,
                RestAddress = "770 N University Ave.",
                RestPhone = "541-399-7822",
                //RestWebsite = "https:gurus.com"
            };

            Top5List r2 = new Top5List(2)
            {
                RestName = "Zupa's",
                FavDish = "Chicken Salad",
                RestAddress = "Right by Cafe Rio :)",
                RestPhone = "801-977-8844",
                RestWebsite = "https://zupas.com/"
            };

            Top5List r3 = new Top5List(3)
            {
                RestName = "Cafe Rio",
                FavDish = "The Salad",
                RestAddress = "Right by zupas",
                RestPhone = "801-210-8844",
                RestWebsite = "https://caferio.com/"
            };

            Top5List r4 = new Top5List(4)
            {
                RestName = "JJ Burger",
                FavDish = "The $2 Burger",
                RestAddress = "2020 W Center St.",
                RestPhone = "801-377-8844",
                RestWebsite = "https://jjburger.com/"
            };

            Top5List r5 = new Top5List(5)
            {
                RestName = "Chip Cookies",
                FavDish = "The OG Choclate Chip",
                RestAddress = "127 E State St.",
                RestPhone = "721-777-8844",
                RestWebsite = "https://chip.com/"
            };

            //output results to a List
            return new Top5List[] { r1, r2, r3, r4, r5 };
        }
    }
}
