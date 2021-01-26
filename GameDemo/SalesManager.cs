using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class SalesManager
    {
        public void Sale(Product product, Player player)
        {
            Console.WriteLine(product.GameName + " adlı oyun " + player.FirstName + " " + player.LastName + " adlı oyuncuya satıldı.");
        }
    }
}
