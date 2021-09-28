// Ryan von Lutzow
// Smoothie Extra Credit
// 9-28-21

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Smoothie;

namespace Smoothie
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> IngredientNames = new List<string>();
            List<double> IngredientPrices = new List<double>();

            Smoothie s = new Smoothie(IngredientNames, IngredientPrices);

            s.IngredientNames.Add("Strawberry");
            s.IngredientNames.Add("Banana");
            s.IngredientNames.Add("Mango");
            s.IngredientNames.Add("Blueberry");
            s.IngredientNames.Add("Raspberry");
            s.IngredientNames.Add("Apple");
            s.IngredientNames.Add("Pineapple");
            s.IngredientPrices.Add(1.50);
            s.IngredientPrices.Add(0.50);
            s.IngredientPrices.Add(2.50);
            s.IngredientPrices.Add(1.00);
            s.IngredientPrices.Add(1.00);
            s.IngredientPrices.Add(1.75);
            s.IngredientPrices.Add(3.50);

            s.GetName();


        }

    }

}