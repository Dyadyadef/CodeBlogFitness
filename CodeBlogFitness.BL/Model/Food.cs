using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BLTests
{
    [Serializable]
    public class Food
    {
        public string Name { get; set; }
        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get;}
        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get;}
        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get;}
        /// <summary>
        /// Калории.
        /// </summary>
        public double Calories { get;}
        private double CalloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }
        private double FatsOnGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOnGramm { get { return Carbohydrates / 100.0; } }

        public Food(string name) : this(name, 0, 0, 0, 0)
        {
            // TODO: проверка

            Name = name;
        }
        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            // TODO: проверка


            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;


        }
        public override string ToString()
        {
            return Name;
        }
    }
}
