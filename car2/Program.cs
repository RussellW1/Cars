using System.Collections;
using System.Text;
using System;
using System.Linq;

namespace cars
{
    public class Program
    {

       
       static bool mainmenu = true;
       static bool menu = true;
        static void Main(string[] args)
        { 
            var sal = new Chain();

            
            while (mainmenu)
            {
               
                mainmenu = MainMenu(sal);
            }
        }
        
        private static bool MainMenu(Chain sal)
        {
            Console.WriteLine("Выберете действие");
            Console.WriteLine("1) Добавление салона.");
            Console.WriteLine("2) Удаление салона.");
            Console.WriteLine("3) Показать список салонов.");
            Console.WriteLine("4) Выбрать автосалон.");
            Console.WriteLine("5) Выход");
            Console.Write("\r\nВнести свой выбор: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        sal.AddSalon();
                        sal.Show1();
                        break;
                    }
                case "2":
                    {
                        sal.DeleteSalon();
                        break;
                    }

                case "3":
                    {
                        sal.Spisok();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Введите номер салона");
                        var selected = Convert.ToInt32(Console.ReadLine());
                        var auto = sal.Salons.ElementAt(selected-1);
                        Menu(auto);
                       break;
                    }
                case "5":
                    {
                        mainmenu = false;
                        break;
                    }

            }

            return mainmenu;
        }
        
        private static bool Menu(Autosalon auto)
        {
            var sal = new Chain();
            Console.WriteLine("Выберете действие");
            Console.WriteLine("1) Добавление автомобиля.");
            Console.WriteLine("2) Удаление автомобиля.");
            Console.WriteLine("3) Показать список автомобилей.");
            Console.WriteLine("4) Перейти к автосалонам.");
            Console.WriteLine("5) Выход");
            Console.Write("\r\nВнести свой выбор: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        auto.AddCars();
                        auto.Show();
                        break;
                    }
                case "2":
                    {
                        auto.DeleteCars();
                        break;
                    }

                case "3":
                    {
                        auto.Show();
                        break;
                    }

                case "4":
                    {
                        MainMenu(sal);
                        break;
                    }
                case "5":
                    {
                        menu = false;
                        break;
                    }

            }

            return menu;
        }

        

    }

   
}






