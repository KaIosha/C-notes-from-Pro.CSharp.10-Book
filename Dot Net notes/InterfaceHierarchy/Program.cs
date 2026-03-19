namespace InterfaceHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAdvancedDraw bitmapImage = new BitmapImage();
            bitmapImage.print();
        }
    }
}
