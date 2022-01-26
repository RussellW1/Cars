namespace cars
{
    public abstract class Vechicle
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Марка: {this.Mark},Модель: {Model},Цвет: {Color},Цена: {Price},";
        }


    }

    

    
}






