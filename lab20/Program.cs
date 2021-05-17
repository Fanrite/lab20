using System;
using System.Linq;
using System.IO;


namespace lab20
{
    class Program
    {

        static void Main(string[] args)
        {
            Omaeva[] arr = new Omaeva[]
            {
               new Omaeva("Богдан","Стицун","Андрійович"),
               new Omaeva("Вадим","Лебедюк","Федорович")
            };

            
            var path = @"D:\\lab20.dat";
            int i = 0;
            bool flag = true;
            while (flag)
            {
                if (!File.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine("File 404");
                    Console.ReadKey();
                }
                else
                {
                    string stroka = "";
                    int counterLines = System.IO.File.ReadAllLines(path).Length;

                    arr = new Omaeva[counterLines / 3];

                    using (StreamReader MyFile = new StreamReader(path))
                    {
                        int count = 0;

                        while ((stroka = MyFile.ReadLine()) != null)
                        {
                            arr[count] = new Omaeva(stroka, MyFile.ReadLine(), MyFile.ReadLine());
                            count++;
                        }
                    }
                }
                int v;
                Console.Clear();
                Console.WriteLine("Виберіть режим: \n1 - Ввід даних  \n2 - Пошук по фамілії  \n3 - Показ всієї бази \n4 - Вихід з програми");
                v = Convert.ToInt32(Console.ReadLine());

                if (v == 1)
                {
                    bool b = true;
                    while (b)
                    {
                        int e;
                        Console.Clear();
                        Console.WriteLine("1 - Ввести  2- Вихід");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (e == 1)
                        {
                            Array.Resize(ref arr, arr.Length + 1);
                            arr[arr.Length - 1] = new Omaeva();
                        }
                        if (e == 2) b = false;
                    }

                }

                if (v == 2)
                {
                    string temp;
                    Console.Clear();
                    Console.WriteLine("Введіть прізвище:");
                    temp = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine($"Ось що знайдено по {temp}:\n");
                    for (i = 0; i < arr.Length ; i++)
                    {
                        if (arr[i].sname == temp)
                        {
                            Console.Write($"{i} ");
                            arr[i].Info();
                        }

                    }

                    Console.ReadKey();

                }

                if (v == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Вся база:");
                    foreach (Omaeva n in arr)
                        n.Info();
                    Console.ReadKey();

                }

                if (v == 4)
                    flag = false;

                StreamWriter f = new StreamWriter(path);
                for (i = 0; i < arr.Count(); i++)
                {
                    f.WriteLine(arr[i].fname);
                    f.WriteLine(arr[i].sname);
                    f.WriteLine(arr[i].fathername);
                }
                f.Close();

            }


        }
    }
}
