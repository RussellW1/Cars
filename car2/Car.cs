using System;
using System.Collections.Generic;

namespace cars
{
    public class Car: Vechicle
   {
       public uint Door { get; set; }
        public override string ToString()
        {
            return $"Марка: {this.Mark},Модель: {Model},Цвет: {Color},Цена: {Price}, Door: {Door}";
        }
    }

    
}






