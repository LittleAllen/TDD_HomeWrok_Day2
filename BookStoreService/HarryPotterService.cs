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

            if(books.Count() == 2 && books[0].Name != books[1].Name)
            {
                totalPrice = (int)(totalPrice * 0.95);
            }

            return totalPrice;
        }
    }
}
