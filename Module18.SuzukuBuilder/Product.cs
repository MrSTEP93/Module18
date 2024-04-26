using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.SuzukuBuilder
{
    public class Product
    {
        string _type;
        
        // parts
        Dictionary<string, string> _parts = new Dictionary<string, string>();

        // ctor
        public Product(string type)
        {
            _type = type;
        }

        // indexer
        public string this [string key]
        {
            set
            {
                _parts[key] = value;
            }
        }

        /// <summary>
        /// Method for getting product information
        /// </summary>
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид транспортного средства: {_type}");
            Console.WriteLine($" Рама: {_parts["frame"]}");
            Console.WriteLine($" Двигатель: {_parts["engine"]}");
            Console.WriteLine($" Колесья: {_parts["wheels"]}");
            Console.WriteLine($" Двери: {_parts["doors"]}");
        }
    }
}
