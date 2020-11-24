using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib
{
    public abstract class AnyProduct
    {
        /// <summary>
        /// Список ингредиентов
        /// </summary>
        public virtual List<Ingredient> ingredients { get; protected set; }
        /// <summary>
        /// Наценка изделия
        /// </summary>
        public double markUp { get; protected set; }
        /// <summary>
        /// Получение стоимости
        /// </summary>
        /// <returns>Стоимость</returns>
        public double GetCost()
        {
            double price = 0;
            foreach(Ingredient i in ingredients)
            {
                price += i.Cost;
            }
            return price + markUp;
        }
        /// <summary>
        /// Получение калорийности
        /// </summary>
        /// <returns>Калорийность</returns>
        public double GetCalorific()
        {
            double calorific = 0;
            foreach (Ingredient i in ingredients)
            {
                calorific += i.Calorific;
            }
            return calorific;
        }
        /// <summary>
        /// Получение списка ингредиентов
        /// </summary>
        /// <returns>Список ингредиентов</returns>
        public List<Ingredient> GetIngridients()
        {
            return ingredients;
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ingredients">Список ингредиентов</param>
        /// <param name="markUp">Наценка</param>
        public AnyProduct(List<Ingredient> ingredients, double markUp)
        {
            this.ingredients = ingredients;
            this.markUp = markUp;
        }
    }
}
