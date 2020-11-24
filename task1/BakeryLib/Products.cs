using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public enum SortState
    {
        Cost,
        Calorific
    }
    public class Products
    {
        AnyProduct[] _products;
        public int countOfProd { get { return _products.Count(); } }
        public Products()
        {
            ReadFile();
        }
        public void ReadFile()
        {
            string filePath = Directory.GetCurrentDirectory() + @"\BakeryProducts.txt";
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            int countOfProducts = 0;
            foreach(string line in lines)
            {
                string[] temp = line.Split(' ');
                int count = int.Parse(temp[1]);
                if(count != 0)
                    countOfProducts += count;
            }
            _products = new AnyProduct[countOfProducts];
            foreach(string line in lines)
            {
                string[] temp = line.Split(' ');
                int count = int.Parse(temp[1]);
                switch(temp[0])
                {
                    case "Bread":
                        for (int i = 0; i < count; i++)
                            Add(_products, new Bread());
                        break;
                    case "Bun":
                        for (int i = 0; i < count; i++)
                            Add(_products, new Bun());
                        break;
                    case "Loaf":
                        for (int i = 0; i < count; i++)
                            Add(_products, new Loaf());
                        break;
                }
            }
        }
        public AnyProduct[] ArraySort(SortState sortState)
        {
            AnyProduct temp;
            AnyProduct[] prods = new AnyProduct[countOfProd];
            Array.Copy(_products, prods, countOfProd);
            for(int i = 0; i < countOfProd; i++)
            {
                for(int j = i + 1; j < countOfProd; j++)
                {
                    switch(sortState)
                    {
                        case SortState.Calorific:
                            if(prods[j].GetCalorific() < prods[i].GetCalorific())
                            {
                                temp = prods[j];
                                prods[j] = prods[i];
                                prods[i] = temp;
                            }
                            break;
                        case SortState.Cost:
                            if (prods[j].GetCost() < prods[i].GetCost())
                            {
                                temp = prods[j];
                                prods[j] = prods[i];
                                prods[i] = temp;
                            }
                            break;
                    }
                }
            }
            return prods;
        }
        public AnyProduct[] TakeIdentical(double cost, double calorific)
        {
            AnyProduct[] prods = new AnyProduct[countOfProd];
            for(int i = 0; i < countOfProd; i++)
            {
                if (_products[i].GetCalorific() == calorific && _products[i].GetCost() == cost)
                    Add(prods, _products[i]);
            }
            return prods;
        }

        public AnyProduct[] TakeIfMore(Ingredient ingredient)
        {
            AnyProduct[] prods = new AnyProduct[countOfProd];
            List<Ingredient> ingredients;
            for (int i = 0; i < countOfProd; i++)
            {
                ingredients = _products[i].GetIngridients();
                for(int j = 0; j < ingredients.Count(); j++)
                {
                    if (ingredients[j] == ingredient && ingredients[j].Volume > ingredient.Volume)
                        Add(prods, _products[i]);
                }    
            }
            return prods;
        }
        public AnyProduct[] TakeByCount(int count)
        {
            AnyProduct[] prods = new AnyProduct[countOfProd];
            for (int i = 0; i < countOfProd; i++)
            {
                if (_products[i].GetIngridients().Count() == count)
                    Add(prods, _products[i]);
            }
            return prods;
        }
        public void Add(AnyProduct[] prods, AnyProduct product)
        {
            for(int i = 0; i < prods.Count(); i++)
            {
                if (prods[i] == null)
                {
                    prods[i] = product;
                    break;
                }
            }
        }
    }
}
