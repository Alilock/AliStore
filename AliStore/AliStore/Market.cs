using System;
using System.Collections.Generic;
using System.Text;

namespace AliStore
{
    internal class Market : IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products { get { return _products; } set => _products = value; }
        public int ProductLimit
        {
            get => _productLimit;
            set
            {
                _productLimit = value;
            }
        }
        private int _productLimit = 10;
        private double _totalIncome = 0;
        public double TotalIncome
        {
            get => _totalIncome;
            set => _totalIncome = value;
        }

        public void AddProduct(Product product1)
        {
            if (Products.Length < ProductLimit && HasNotNo(product1))
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product1;
            }
        }

        public void SellProduct(string No)
        {
            
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == No && _products[i].Count > 0)
                {
                    _totalIncome += _products[i].Price;
                    _products[i].Count--;
                    Console.WriteLine($"{_products[i].Name} satildi");

                }
            }
        }

        public bool HasNotNo( Product product)
        {
            
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == product.No)
                {
                    return false;
                }

            }
            return true;
        }

        public void ShowPr()
        {
            foreach (var item in _products)
            {
                Console.WriteLine($"{item.Name}, {item.Price}azn, Stokda:{item.Count} eded var");
            }
        }
        public  void ShowIncome()
        {
            Console.WriteLine($"Umumi satis: {TotalIncome}azn");
        }
    }

}
