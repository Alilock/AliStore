using System;

namespace AliStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;
            Market AliStore = new Market();
            
           
            do

            {
                option = 0;
                Console.WriteLine(" 1. Product elave et");
                Console.WriteLine(" 2. Product sat");
                Console.WriteLine(" 3. Productlara bax");
                Console.WriteLine(" 4. Umumi satisi goster");
                Console.WriteLine(" 5. Menyudan cix");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.Write("duzgun secim edin:");
                }

                switch (option)

                {
                    case 1:


                        Product product1 = new Product();
                        Console.Write("Product elave etmek ucun mehsulun adini yaz: ");
                        string Name = Console.ReadLine();

                        Console.Write("Mehsulun qiymetini yaz: ");
                        double Price = double.Parse(Console.ReadLine());

                        Console.Write("Mehsulun nomresini yaz: ");

                        string No = Console.ReadLine();
                        Console.Write("Mehsuldan nece eded daxil etmek istediyini yaz: ");
                        int Count = int.Parse(Console.ReadLine());

                        product1.Name = Name;
                        product1.Price = Price;
                        product1.No = No;
                        product1.Count += Count;
                        AliStore.AddProduct(product1);

                        break;
                    case 2:
                        Console.Write("Mehsulun nomresini daxil edin: ");
                        AliStore.SellProduct(Console.ReadLine()); 
                        break;
                    case 3:
                        AliStore.ShowPr();
                        break;

                    case 4: AliStore.ShowIncome(); break;
                    case 5: Console.WriteLine("Sagolun"); break;

                    default:

                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("Duzgun secim edin");
                        
                        break;
                }
            } while (option!= 5);


          
            

        }
    }
}
