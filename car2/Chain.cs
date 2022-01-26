using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace cars
{
    public class Chain
    {

        public List<Autosalon> Salons { get; set; }
        public Chain()
        {
            Salons = new List<Autosalon>();

        }
        public void Show1()
        {
            if (Salons.Count > 0)
            {


                foreach (var sal in Salons)
                {

                    Console.WriteLine($"Название: {sal.Name},Город: {sal.Gorod}");

                }

            }
            else
            {
                Console.WriteLine("Нету салонов");
            }
        }
        public void AddSalon()
        {

            Console.WriteLine("Сколько салонов:");

            int j = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < j; i++)

            {
                Autosalon newSalons = new Autosalon();
                Console.WriteLine("Введите Название:");
                newSalons.Name = Console.ReadLine();
                Console.WriteLine("Введите город:");
                newSalons.Gorod = Console.ReadLine();
                Salons.Add(newSalons);

            }
        }

        public void DeleteSalon()
        {


            if (Salons.Count > 0)
            {

                Console.WriteLine("Сколько салонов удалить:");

                int j = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < j; i++)
                {
                    Autosalon userRem = Salons.FirstOrDefault(us => us.Name != null);
                    if (userRem != null)
                        Salons.Remove(userRem);
                }
                Show1();
            }
            else
            {
                Console.WriteLine("Нету салонов");
            }

        }

        public void Spisok()
        {

            if (Salons.Count == 0)
            {
                Console.WriteLine("Салонов нету");
            }
            else
            {

                foreach (var sal in Salons)
                {
                    Console.WriteLine($"Название: {sal.Name},Город: {sal.Gorod}");

                    if (sal.Vechile.Count == 0)
                    {
                        Console.WriteLine("Машин нету");
                    }
                    else
                    {
                        sal.Show();

                    }
                }
            }
        }

        public void JobSpisok()
        {
            Console.WriteLine("Введите номер салона");
            int number = Convert.ToInt32(Console.ReadLine());

        }
        
    }
}







