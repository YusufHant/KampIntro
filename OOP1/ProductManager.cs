using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation - kümülatif yollama
        public void Add(Product product)
        {
            product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName);
        }

       
        public void BiseyYap(int sayi)
        {
            sayi = 99;
            Console.WriteLine(sayi);
        }
    }
}
