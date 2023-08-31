using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffettuaOrdine
{
    internal class Order
    {
        public static List<Product> products = new List<Product>();
        public const int Servizio = 3;

        

      public static void menu()
        {
            Console.WriteLine("==============MENU==============");
            Console.WriteLine("1:  Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2:  Insalata di pollo (€ 5.20)");
            Console.WriteLine("3:  Pizza Margherita (€ 10.00)");
            Console.WriteLine("4:  Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5:  Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6:  Insalata di riso (€ 8.00)");
            Console.WriteLine("7:  Frutta di stagione (€ 5.00)");
            Console.WriteLine("8:  Pizza fritta (€ 5.00)");
            Console.WriteLine("9:  Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10: Panino Hamburger (€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
            string choice = Console.ReadLine();
            if(choice == "1" ) {
                Product prodotto = new Product("Coca Cola 150ml", 2.50);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "2")
            {
                Product prodotto = new Product("Insalata di pollo", 5.20);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "3")
            {
                Product prodotto = new Product("Pizza margherita", 10.00);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "4")
            {
                Product prodotto = new Product("Pizza 4 formaggi", 12.50);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "5")
            {
                Product prodotto = new Product("Pz patatine fritte", 3.50);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "6")
            {
                Product prodotto = new Product("Insalata di riso", 8.00);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "7")
            {
                Product prodotto = new Product("Frutta di stagione", 5.00);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "8")
            {
                Product prodotto = new Product("Pizza fritta", 5.00);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "9")
            {
                Product prodotto = new Product("Piadina vegetariana", 6.00);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "10")
            {
                Product prodotto = new Product("Panino hamburger", 7.90);
                products.Add(prodotto);
                menu();
            }
            else if (choice == "11")
            {
                Console.WriteLine("Ecco di seguito il tuo ordine");
                foreach (Product product in products)
                {
                    Console.WriteLine(product.Name);
                }
                getTotal();
            }
            else
            {
                Console.WriteLine("Comando non riconosciuto, per favore segui il menu");
                menu();
            }
            
          
        }

      private static void getTotal()
        {
            double total = 0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            total += Servizio;
            Console.WriteLine($"Il totale da pagare è di: {total} Eur");
        }
        
       
    }
}
