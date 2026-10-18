using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readmeee
{
    /// <summary>
    /// Класс для расчёта скидок в системе заказов компании «Цветочек»
    /// (доставка цветов).
    /// </summary>
    public class DiscountCalculator
    {
            /// <summary>
            /// Размер скидки для товаров, по которым не было заказов в прошлом месяце (30%).
            /// </summary>
            public const decimal DiscountRate = 0.30m;

            /// <summary>
            /// Рассчитывает цену со скидкой 30%, если по товару
            /// не было заказов в прошлом месяце.
            /// </summary>
            /// <param name="basePrice">Базовая цена товара.</param>
            /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом месяце.</param>
            /// <returns>Цена со скидкой или базовая цена.</returns>
            public decimal GetDiscountedPrice(decimal basePrice, bool hasOrdersLastMonth)
            {
                if (hasOrdersLastMonth)
                    return basePrice;

                return basePrice * (1m - DiscountRate);
            }

            /// <summary>
            /// Проверяет корректность базовой цены товара.
            /// </summary>
            /// <param name="basePrice">Проверяемая цена.</param>
            /// <returns>true, если цена неотрицательна; иначе false.</returns>
            public bool IsValidPrice(decimal basePrice)
            {
                return basePrice >= 0m;
            }
    }

        /// <summary>
        /// Точка входа программы: демонстрация расчёта скидки
        /// в системе заказов компании «Цветочек».
        /// </summary>
    internal class Program
    {
            /// <summary>
            /// Запускает демонстрационный расчёт и выводит результат в консоль.
            /// </summary>
            /// <param name="args">Аргументы командной строки (не используются).</param>
           
        static void Main(string[] args)
        {
                var calculator = new DiscountCalculator();

                decimal price = 1000m;
                decimal discounted = calculator.GetDiscountedPrice(price, false);

                Console.WriteLine("Компания «Цветочек» — доставка цветов");
                Console.WriteLine($"Базовая цена: {price}");
                Console.WriteLine($"Цена со скидкой 30%: {discounted}");
                Console.WriteLine("Бихе Кирилл, Группа И-42");

                Console.ReadKey();
        }
    }
}