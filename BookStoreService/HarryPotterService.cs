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
                switch (books.Count())
                {
                    case 2:
                        totalPrice = (int)(totalPrice * 0.95);
                        break;

                    case 3:
                        totalPrice = (int)(totalPrice * 0.9);
                        break;

                    case 4:
                        totalPrice = (int)(totalPrice * 0.8);
                        break;
                }
            }

            return totalPrice;
        }
    }
}
