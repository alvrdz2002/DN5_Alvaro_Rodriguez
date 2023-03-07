using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Customer
    {
        public string Name;
        public string Date;
        
        public Customer(string n, string d) {
            this.Name = n;
            this.Date = d;
        }
       
    }
    class GenericCollection
    {
        static void main(string[] args)
        {
            List<Customer> Client = new List<Customer>();
            Client[0] = new Customer("Luis Garcia", "12/12/1996");
            Client[1] = new Customer("Jose perez", "12/19/2006");
            Client[2] = new Customer("Yefferson", "02/23/2010");
            Client[3] = new Customer("Gutierritos", "05/16/2012");
            Client[4] = new Customer("Alvin", "08/06/2012");
            Client[5] = new Customer("Yakitori", "09/09/2012");
            Client[6] = new Customer("Elver Chairo", "31/10/2014");
            Client[7] = new Customer("Maria Chayotera", "30/11/2015");
            Client[8] = new Customer("Jose", "06/11/2018");
            Client[9] = new Customer("Luis Perales", "05/12/2020");

            //Recorrer con ciclo foreach
            foreach(Customer c in Client)
            {
                Console.WriteLine(c.Name + " " +c.Date);
       
            }
            Console.WriteLine("--------------------");
            //recorrer ciclo for
            for(int k = 0; k < 10; k++)
            {
                Console.WriteLine(Client[k]);
            }
            Console.WriteLine("--------------------");
            //recorrer ciclo while
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(Client[i]);
                i++;
            }
            Console.WriteLine("--------------------");
            //recorrer ciclo Do while
            int j = 0;
            do
            {
                Console.WriteLine(Client[j]);
                j++;
            } while (j < 10);
            Console.ReadKey();
        }
    }
}
