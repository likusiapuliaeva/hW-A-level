using System;
using Cars.BusinessLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car Car1 = new Car();
            Car Car2 = new Car();
            Car Car3 = new Car();

            
            Console.WriteLine($"Ведите название 1 машины");
            string name1 = Console.ReadLine();
            Car1.name = name1;
            Console.WriteLine($"Введите цвет 1 машины");
            string color1 = Console.ReadLine();
            Car1.color = color1;
            Console.WriteLine($"Введите цену 1 машины");
            string s = Console.ReadLine();
            int pricel;
            bool b = int.TryParse(s, out pricel);
            if (b)
            {
                Car1.Price = pricel;
            }

            Console.WriteLine($"Ведите название 2 машины");
            string name2 = Console.ReadLine();
            Car2.name = name2;
            Console.WriteLine($"Введите цвет 22 машины");
            string color2 = Console.ReadLine();
            Car2.color = color2;
            Console.WriteLine($"Введите цену 2 машины");
            string s2 = Console.ReadLine();
            int priced;
            bool b2 = int.TryParse(s2, out priced);
            if (b2)
            {
                Car2.Price = priced;
            }
            Console.WriteLine($"Ведите название 3 машины");
            string name3 = Console.ReadLine();
            Car3.name = name3;
            Console.WriteLine($"Введите цвет 3 машины");
            string color3 = Console.ReadLine();
            Car3.color = color3;
            Console.WriteLine($"Введите цену 3 машины");
            string s3 = Console.ReadLine();
            int pricea;
            bool b3 = int.TryParse(s3, out pricea);
            if (b3)
            {
                Car3.Price = pricea;
            }
            */
            var mersedes = new Minivan();
            mersedes.name = "Минивен";
            mersedes.price = 30000;

            var volvo = new Gruzovik();
            volvo.name = "volca";
            volvo.price = 50000;

            var avto = new Car();
            avto.name = "авто";
            avto.price = 50000;


            Car[] cararr = new Car[5];


            cararr[0] = mersedes;
            cararr[1] = volvo;
            cararr[2] = avto;
            /*
            foreach(var car in cararr)
            {
                if(car !=null)
                {
                    if (car is IStoring)
                    {
                        var stored1 = car as IStoring;
                    }



                Console.WriteLine($"{car.name} {car.price} {car.Price}");
                }
            }
            */
            foreach (var car in cararr)
            {
                if (car != null)
                {
                    if (car is IDiscont)
                    {
                        var stored1 = car as IDiscont;
                    }
                    
                    Console.WriteLine($"{car.name} {car.price} {car.Price}");
                }
            }

            Console.ReadLine();



        }
    }
}
