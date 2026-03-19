namespace MiInterfaceHierarchy
{
    internal interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
