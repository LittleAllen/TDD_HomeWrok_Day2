using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStoreService
{
    public class HarryPotterService
    {
        public object CalculatePrice(List<HarryPortterBook> books)
        {
            var totalPrice = 0;
            totalPrice = books.Sum(x => x.Price);

            if (books.Count() == books.GroupBy(x => x.Name).Count())
            {
                var discount = this.GetDiscount(books.Count());
                totalPrice = (int)(totalPrice * discount);
            }

            return totalPrice;
        }

        /// <summary>
        /// 取得折扣
        /// </summary>
        /// <param name="discountType">折扣類別</param>
        /// <returns>折扣</returns>
        private double GetDiscount(int discountType)
        {
            double discount = 1;

            switch (discountType)
            {
                case 2:
                    discount = 0.95;
                    break;

                case 3:
                    discount = 0.9;
                    break;

                case 4:
                    discount = 0.8;
                    break;

                case 5:
                    discount = 0.75;
                    break;
            }

            return discount;
        }
    }
}
