namespace InterfaceHierarchy
{
    internal interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();

        void print()
        {
            Console.WriteLine("defult");
        }
    }
}
