using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApiCall
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowRestaurants();
            ShowReviews(5915530);
        }

        private static void ShowRestaurants()
        {
            var response = ZomatoInfo.GetRestaurants();

            var restaurants = response.Restaurants;

            Console.WriteLine($"Results found : {response.ResultsFound}");
            Console.WriteLine($"Results shown : {response.ResultsShown}");
            Console.WriteLine();

            Console.WriteLine($"{"ID",-10} {"NAME",-40} {"CUISINES",-50} {"LOCATION",-40}");
            foreach (var r in restaurants)
            {
                var restaurant = r.Restaurant;
                Console.WriteLine($"{restaurant.ID,-10} {restaurant.Name,-40} {restaurant.Cuisines,-50} {restaurant.Location.LocalityVerbose,-40}");
            }

            Console.ReadLine();
        }

        private static void ShowReviews(int restaurantId)
        {
            var response = ZomatoInfo.GetReviews(restaurantId);

            var reviews = response.UserReviews;

            Console.WriteLine($"Results found : {response.ResultsFound}");
            Console.WriteLine($"Results shown : {response.ResultsShown}");
            Console.WriteLine();

            Console.WriteLine($"{"RATING",-6} {"REVIEW", -100}");
            foreach (var r in reviews)
            {
                var review = r.Review;
                Console.WriteLine($"{review.Rating,6} {review.ReviewText,-100}");
            }

            Console.ReadLine();
        }
    }
}
