using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Product
    {
        private string _packageType;
        private List<string> _items = new List<string>();

        public Product(string PacakgeType)
        {
            this._packageType = PacakgeType;
        }
        public void Add(string part)
        {
            _items.Add(part);
        }
        public void show()
        {
            Console.WriteLine("Package Details....");
            Console.WriteLine(_packageType);
            foreach(var str in _items)
            {

                Console.WriteLine(str);
            }
        }
    }
}
