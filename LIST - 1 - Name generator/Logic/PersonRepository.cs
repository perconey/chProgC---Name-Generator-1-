using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___1___Name_generator.Logic
{
    class PersonRepository
    {
        private List<Person> list = new List<Person>();

        internal List<Person> List { get => list; set => list = value; }
    }
}
