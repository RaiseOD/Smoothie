// Ryan von Lutzow
// Smoothie Class
// 9-28-21

using System;
using System.Collections.Generic;
using System.Text;

namespace Smoothie
{
    class Smoothie
    {

        public List<string> IngredientNames = new List<string>();
        public List<double> IngredientPrices = new List<double>();

        public Smoothie(List<string> IngredientNames, List<double> IngredientPrices)
        {
            
            IngredientNames = this.IngredientNames;
            IngredientPrices = this.IngredientPrices;

        }

        public void GetName()
        {

            Console.WriteLine("Ingredients: ");

            Console.WriteLine(IngredientNames.Count);
            
            if (IngredientNames.Count > 1)
            {

                for (var i = 0; i < IngredientNames.Count - 1; i++)
                {

                    Console.Write(IngredientNames[i] + ", ");

                }

                Console.Write(IngredientNames[IngredientNames.Count - 1] + " Fusion ");

            }
            else
            {

                Console.Write(IngredientNames[0] + "Smoothie ");

            }

        }

        public void GetCost()
        {



        }

        public void GetPrice()
        {



        }

    }

}
