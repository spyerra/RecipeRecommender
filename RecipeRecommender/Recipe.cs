using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRecommender
{
    /// <summary>
    /// 
    /// </summary>
    class Recipe
    {
        #region Properties
        /// <summary>
        /// Name of the recipe.
        /// </summary>
        public string RecipeName { get; set; }
        /// <summary>
        /// Ingredients for the recipe.
        /// </summary>
        public List<string> Ingredients { get; set; }

        /// <summary>
        /// Instructions for the recipe.
        /// </summary>
        public string Instructions { get; set; }
        #endregion

    }
}
