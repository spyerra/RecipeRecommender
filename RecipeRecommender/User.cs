using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRecommender
{
    /// <summary>
    /// Represents a user in recipe recommender
    /// </summary>
    class User
    {
        #region Properties
        /// <summary>
        /// Name of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// It stores list of recipes for the user.
        /// </summary>
        public List<Recipe> Recipes { get; set; }
        #endregion

        public User()
        {
            Recipes = new List<Recipe>();
        }

        #region Methods
        /// <summary>
        /// Adds a recipe into the recipes of user.
        /// </summary>
        /// <param name="recipe"></param>
        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        /// <summary>
        /// Removes a recipe from the recipes of user.
        /// </summary>
        /// <param name="recipe"></param>
        public void RemoveRecipe(Recipe recipe)
        {
            Recipes.Remove(recipe);
        }
        #endregion
    }
}
