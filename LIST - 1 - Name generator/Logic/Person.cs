using FileHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___1___Name_generator.Logic
{
    [DelimitedRecord("\n")]
    class Person
    {

        public static List<string> snList = new List<string>();
        public static List<string> fnList = new List<string>();

        static bool isLoaded = false;

        [FieldOptional]
        private string _surname;
        [FieldOptional]
        private string _forename;
        [FieldHidden]
        private long _pesel;
        [FieldHidden]
        private int _phonenum;

        public string Surname { get => _surname; set => _surname = value; }
        public string Forename { get => _forename; set => _forename = value; }
        public long Pesel { get => _pesel; set => _pesel = value; }
        public int PhoneNum { get => _phonenum; set => _phonenum = value; }

        public Person()
        {

            if (isLoaded == false)
            {
                FileHelperEngine<Name> snEngine = new FileHelperEngine<Name>();
                string path = Path.Combine(Environment.CurrentDirectory, "firstnamescsv.csv");
                var read = snEngine.ReadFile(path);
                foreach (Name item in read)
                {
                    snList.Add(item.Names);
                }

                FileHelperEngine<Name> fnEngine = new FileHelperEngine<Name>();
                string path1 = Path.Combine(Environment.CurrentDirectory, "lastnamescsv.csv");
                var read1 = fnEngine.ReadFile(path1);
                foreach (Name item in read1)
                {
                    fnList.Add(item.Names);
                }
                isLoaded = true;
            }
            
            PickSurname();
            PickForename();
            PickPesel();
            PickPhonenum();
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public void PickSurname()
        {
            Surname = snList[RandomNumber(1,5493)];
        }

        public void PickForename()
        {
            Forename = fnList[RandomNumber(1, 88777)];
        }

        public void PickPhonenum()
        {
            PhoneNum = RandomNumber(500000000,799999999);
        }

        public void PickPesel()
        {
            Pesel = RandomNumber(100000000, 999999999);
        }

        public override string ToString()
        {
            return $"Name: {Surname} {Forename}\n" +
                $"Phone number: {PhoneNum}\n" +
                $"Pesel: {Pesel}";
        }
    }
}
