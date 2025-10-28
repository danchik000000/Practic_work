using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Product
    {
        private decimal price;
        private decimal discount;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть отрицательной!");
                price = value;
            }
        }

        public decimal Discount
        {
            get { return discount; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Скидка должна быть от 0 до 100%");
                discount = value;
            }
        }
        public string Name { get; set; } 
        public decimal FinalPrice => Price * (1 - Discount / 100); 
        public Product(string name, decimal price, decimal discount)
        {
            Name = name;
            Price = price; 
            Discount = discount; 
        }

        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice:F2} (скидка {Discount}%)");
        }
    }
}
