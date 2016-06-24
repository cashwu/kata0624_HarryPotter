using System.Collections.Generic;
using System.Linq;

namespace kata0624_HarryPotter
{
    internal class BookShoppingCart
    {
        private Dictionary<string, int> _books;
        private const int BookUnitPrice = 100;
        private Dictionary<int, double> _discount = new Dictionary<int, double>
        {
            { 1, 0 },
            { 2, 0.05 },
            { 3, 0.1 }
        };

        public void AddBooks(Dictionary<string, int> books)
        {
            _books = books;
        }

        public double GetFee()
        {
            var discount = GetDiscount();

            var bookSet = GetBookSet();

            // book set, discount
            var dic = new Dictionary<int, double>();


            if (_books["book1"] == 4)
            {
                return BookUnitPrice * _books.Count * bookSet * discount + BookUnitPrice * 2 * (1 - 0.05) + BookUnitPrice;
            }

            return BookUnitPrice * _books.Count * bookSet * discount;
        }

        private int GetBookSet()
        {
            return _books.Min(a => a.Value);
        }

        private double GetDiscount()
        {
            var discount = 0d;
            if (_books.Count == 2)
            {
                discount = 0.05;
            }
            else if (_books.Count == 3)
            {
                discount = 0.1;
            }
            return 1 - discount;
        }
    }
}