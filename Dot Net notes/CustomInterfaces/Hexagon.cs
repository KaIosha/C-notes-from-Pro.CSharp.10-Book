namespace CustomInterfaces
{
    internal class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }

        public byte Points => 6;

        public string PropName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw3D()
            => Console.WriteLine("Drawing Hexagon in 3D!");
    }
}
