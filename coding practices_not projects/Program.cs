using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager can=new CustomerManager();
            can.add();
            can.update();

            ProductManager canan=new ProductManager();
            canan.add();
            canan.update();
            Customer hakan=new Customer();
            hakan.City = "Bursa";
            hakan.Id = 2;
            hakan.Firstname = "Hakan";
            hakan.Lastname = "Tasdelen";

            Customer mazlum = new Customer
            {
                Id = 1,City = "Elazig",Firstname = "Mazlum",Lastname = "Gün"
            };
            Console.WriteLine(mazlum.Firstname);

            Console.ReadLine();
        }
    }

    
    
}
