using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIST___1___Name_generator.Logic;
using FileHelpers;
using System.IO;

namespace LIST___1___Name_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> lol = new List<Person>(20);
            int i;
            var list = new List<Person>();
            for (i = 0; i < 5 ; i++)
            {
                list.Add(new Person());
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            
        }
    }
}
