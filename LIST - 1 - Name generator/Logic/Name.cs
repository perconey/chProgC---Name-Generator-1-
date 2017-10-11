using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___1___Name_generator.Logic
{
    [FileHelpers.DelimitedRecord("\n")]
    class Name
    {
        private string _names;
        public string Names
        {
            get => _names;
            set => _names = value;
        }
    }
}
