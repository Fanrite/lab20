using System;

namespace lab20
{
    class Omaeva
    {
        public string fname;
        public string sname;
        public string fathername;

        public Omaeva (string fn, string sn, string fan)
        {
            fname = fn;
            sname = sn;
            fathername = fan;
        }

        public Omaeva ()
        {
            Console.Write("Введіть імя студента:");
            fname = Console.ReadLine();

            Console.Write("Введіть прізвище студента:");
            sname = Console.ReadLine();

            Console.Write("Введіть побатькові студента:");
            fathername = Console.ReadLine();
        }

        public void Info ()
        {
            Console.WriteLine($"{fname} {sname} {fathername}");
        }
        
    }
}
