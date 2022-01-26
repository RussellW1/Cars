using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace cars
{
       public class Autosalon
    {

        public List<Vechicle> Vechile { get; set; }

        public string Name { get; set; }
        public string Gorod { get; set; }
        public Autosalon()
        {
            Vechile = new List<Vechicle>();

        }
        public void Show ()
        {
            if (Vechile.Count>0)
            {
               
                var result = from car in Vechile
                             orderby car.Price
                             select car;
                foreach (Car car in result)
                {
                    Console.WriteLine(car.ToString()); 
                   //Console.WriteLine($"Марка: {car.Mark},Модель: {car.Model},Цвет: {car.Color},Цена: {car.Price},");
                }
                
            }
            else
            {
                Console.WriteLine("Нету автомобилей");
            }         
        }
        public void AddCars()
        {

            Console.WriteLine("Сколько автомобилей:");

            int j = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < j; i++)

            {
                Car newCars = new Car();
                Console.WriteLine("Введите марку:");
                newCars.Mark = Console.ReadLine();
                Console.WriteLine("Введите модель:");
                newCars.Model = Console.ReadLine();
                Console.WriteLine("Введите цвет:");
                newCars.Color = Console.ReadLine();
                Console.WriteLine("Введите цену:");
                newCars.Price = Convert.ToInt32(Console.ReadLine());
                Vechile.Add(newCars);

            }
        }

        public void DeleteCars()
        {
            
           
            if(Vechile.Count > 0)
            {
                
                Console.WriteLine("Сколько автомобилей удалить:");

                int j = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < j; i++)
                {
                    var userRem = Vechile.FirstOrDefault(us => us.Price >0);
                    if (userRem != null)
                        Vechile.Remove(userRem);
                }
                Show();
            }  
            else
            {
                Console.WriteLine("Нету автомобилей");
            }
           
        }

        

    }


}






