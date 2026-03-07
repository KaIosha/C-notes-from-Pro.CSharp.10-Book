namespace FunWithRecords
{
    internal class Car
    {
        //may make set to init to prevent Edit
        public string Make { get; set; }// init }
        public string Model { get; set; }
        public string Color { get; set; }
        public Car() { }
        public Car(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }
    }
}
