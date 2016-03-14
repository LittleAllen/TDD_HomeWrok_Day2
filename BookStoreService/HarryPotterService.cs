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
            totalPrice = books[0].Price;

            return totalPrice;
        }
    }
}
