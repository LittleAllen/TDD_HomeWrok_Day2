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

            if (books.Count() == 2 && books.GroupBy(x => x.Name).Count() == 2)
            {
                totalPrice = (int)(totalPrice * 0.95);
            }
            else if (books.Count() == 3 && books.GroupBy(x => x.Name).Count() == 3)
            {
                totalPrice = (int)(totalPrice * 0.9);
            }

            return totalPrice;
        }
    }
}
