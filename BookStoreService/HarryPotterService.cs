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

            switch(books.Count())
            {
                case 1:
                    totalPrice = books[0].Price;
                    break;
                case 2:

                    if (books[0].Name == books[1].Name)
                    {
                        totalPrice = books.Sum(x => x.Price);
                    }
                    else
                    {
                        totalPrice = (int)(books.Sum(x => x.Price) * 0.95);
                    }

                    break;
            }

            return totalPrice;
        }
    }
}
