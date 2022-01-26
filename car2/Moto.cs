namespace cars
{
    public class Moto : Vechicle
    {
        public uint Rykoyat {get; set;}
        public override string ToString()
        {
            return $"Марка: {this.Mark},Модель: {Model},Цвет: {Color},Цена: {Price}, Ruki {Rykoyat}";
        }
    } 

    
}






