 using System;

namespace KampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1,"Pantolon",1000,"Rhat Pantolon");
            Product product2 = new Product(2, "Etek", 50, "İş eteği");
            Product product3 = new Product(3, "Elbise", 450, "Özel günler elbisesi");
            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Numrarası:"+products[i].id);
                Console.WriteLine("Ürün Adı:" + products[i].ProductName);
                Console.WriteLine("Ürün Fiyatı:" + products[i].ProductPrice);
                Console.WriteLine("Ürün Hakkında:" + products[i].ProductAbout);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine( "For döngüsü bitti" );
            foreach (Product item in products)
            {
                Console.WriteLine("Ürün Numrarası:" + item.id);
                Console.WriteLine("Ürün Adı:" + item.ProductName);
                Console.WriteLine("Ürün Fiyatı:" + item.ProductPrice);
                Console.WriteLine("Ürün Hakkında:" + item.ProductAbout);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("Foreach döngüsü bitti");
            int deger = 0;
            while (deger<products.Length)
            {
                Console.WriteLine("Ürün Numrarası:" + products[deger].id);
                Console.WriteLine("Ürün Adı:" + products[deger].ProductName);
                Console.WriteLine("Ürün Fiyatı:" + products[deger].ProductPrice);
                Console.WriteLine("Ürün Hakkında:" + products[deger].ProductAbout);
                Console.WriteLine("---------------------------");
                deger++;
            }
            Console.WriteLine("While döngüsü bitti");
        }
    }
    class Product
    {
        public Product(int id
            ,String productName,
            int productPrice,
            String productAbout
            )
            
        
        {
            this.id = id;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductAbout = productAbout;
        }
        public int id { get; set; }
        public String ProductName { get; set; }
        public int ProductPrice { get; set; }
        public String ProductAbout { get; set; }
    }
}
