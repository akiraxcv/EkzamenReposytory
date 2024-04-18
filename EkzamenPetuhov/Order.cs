using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenPetuhov
{
    internal class Order
    {
        public string AddToOrder(string Name, int Count, int ItogPrice)
        {
            string zakaz = $"Хлеб: {Name}\nКоличество: {Count}кг\nЦена: {ItogPrice}\n\n";
            return zakaz ;
        }
    }
}
