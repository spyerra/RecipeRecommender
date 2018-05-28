using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRecommender
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipe1 = new Recipe();
            recipe1.RecipeName = "Shakshuka";
            recipe1.Ingredients = new List<string>() { "Tomatoes","Eggs", "Onion", "Salt", };
            Console.WriteLine(string.Join(",", recipe1.Ingredients));

            var user1 = new User();
            user1.UserName = "Charles";
            user1.AddRecipe(recipe1);
            var user2 = new User();
            user2.UserName = "Mike";
            user2.AddRecipe(recipe1);


            Console.ReadKey();
        }
    }
}
