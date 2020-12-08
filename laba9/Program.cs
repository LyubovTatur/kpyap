using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  Структура «Автосервис»: регистрационный номер автомобиля, марка(перечисление), пробег, мастер, выполнивший ремонт, сумма ремонта.
//  Вывести общий пробег по всем машинам одной марки
//  Вывести общую сумму ремонта по каждому мастеру


namespace laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool con = true;
            CarService[] cars= new CarService[0];
            while(con)
            { 
            
            Console.WriteLine(
                "1) Ввод массива структур;" + "\n" +
                "2) Изменение заданной структуры;" + "\n" +
                "3) Удаление структуры из массива;" + "\n" +
                "4) Вывод на экран массива структур;" + "\n" +
                "5) Специальный пункт 1 Вывести общий пробег по всем машинам одной марки" + "\n" +
                "6) Специальный пункт 2 Вывести общую сумму ремонта по каждому мастеру" + "\n" +
                "7) Выход.");
            string Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        {
                            cars = SetInfo();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите рег номер");
                            int num = int.Parse(Console.ReadLine());
                            ChangeCar(cars, num);
                            break;
                            
                        }
                    case "3":
                        {
                            Console.WriteLine("Введите рег номер");
                            int num = int.Parse(Console.ReadLine());
                            DeleteCar(cars, num);
                            break;
                        }
                    case "4":
                        {
                            ShowCars(cars);
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Выберите марку:");
                            PrintBrends();
                        //"1.Bugatti" + "\n" +
                        //"2.BMW" + "\n" +
                        //"3.Bentley" + "\n" +
                        //"4.Audy" + "\n" +
                        //"5.AlfaRomeo"
                        //);
                            Marks mark = (Marks)int.Parse(Console.ReadLine());
                            SpecPunkt1(cars, mark);
                            break;
                        }
                    case "6":
                        {
                            SpecPunkt2(cars);
                            break;
                        }
                    case "7":
                        {
                            con = false;
                            break;
                        }
                }
            }
        }
   

        static CarService[] SetInfo()
        {
            Console.WriteLine("Введите количество машин, которые хотите записать в программу.");
            int n = int.Parse(Console.ReadLine());
            CarService[] cars = new CarService[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите рег.номер.");
                cars[i].RegNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите марку:");
                PrintBrends();
                    
                cars[i].Mark = (Marks)int.Parse(Console.ReadLine());
                Console.WriteLine("Введите пробег.");
                cars[i].Run = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите мастера который делал ремонт.");
                cars[i].MasterRemont = Console.ReadLine();
                Console.WriteLine("Введите сумму ремонта.");
                cars[i].SumRemont = int.Parse(Console.ReadLine());


            }
            return cars;
        }
        static void SpecPunkt1(CarService[] cars, Marks mark)
        {
            double sum = 0;
            foreach(var item in cars)
            {
                if (item.Mark == mark)
                {
                    sum += item.Run;
                }
            }
            Console.WriteLine($"Общий пробег по марке {mark} = {sum}");
        }
        static void SpecPunkt2(CarService[] cars)
        {
            HashSet<string> masters= new HashSet<string>();
            for (int i = 0; i < cars.Length; i++)
            {
                masters.Add(cars[i].MasterRemont);
            }
            double sum = 0;
            foreach (var master in masters)
            {
                sum = 0;
                foreach (var car in cars)
                {
                    if (master == car.MasterRemont)
                    {
                        sum += car.SumRemont;
                    }
                }
                Console.WriteLine($"{master} = {sum}руб.");
            }

        }
        static void ShowCars(CarService[] cars)
        {
            foreach (var item in cars)
            {
               
                Console.WriteLine("Рег номер \t " +item.RegNum);
                Console.WriteLine("марка \t\t" + item.Mark);
                Console.WriteLine("пробег \t\t" + item.Run);
                Console.WriteLine("мастер \t\t" + item.MasterRemont);
                Console.WriteLine("сумма ремонта \t" + item.SumRemont);
                Console.WriteLine("________________________");
            }
        }
        static void ChangeCar(CarService[] cars, int RegNum )
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].RegNum == RegNum)
                {
                        Console.WriteLine("Введите рег.номер.");
                        cars[i].RegNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите марку:\n" +
                            "1.Bugatti" + "\n" +
                            "2.BMW" + "\n" +
                            "3.Bentley" + "\n" +
                            "4.Audy" + "\n" +
                            "5.AlfaRomeo"
                            );
                        cars[i].Mark = (Marks)int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите пробег.");
                        cars[i].Run = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите мастера который делал ремонт.");
                        cars[i].MasterRemont = Console.ReadLine();
                        Console.WriteLine("Введите сумму ремонта.");
                        cars[i].SumRemont = int.Parse(Console.ReadLine());
                }
            }
        }
        static void DeleteCar(CarService[] cars, int RegNum)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].RegNum == RegNum)
                {
                    
                    cars[i].RegNum =0;
                    
                    cars[i].Mark = Marks.Null;
                    
                    cars[i].Run = 0;
                  
                    cars[i].MasterRemont = "0";
                    
                    cars[i].SumRemont = 0;
                }
            }
        }
        static void PrintBrends()
        {
            int i = 1;
            foreach (var item in Enum.GetNames(typeof(Marks)))
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }
        }

    }
}
