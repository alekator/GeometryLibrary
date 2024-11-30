using GeometryLibrary;

// Пример добавления новой фигуры (легкость добавления других фигур):
// 1. Создать класс, реализующий интерфейс IShape.
// 2. Реализовать метод GetArea(), описывающий, как вычисляется площадь этой фигуры.
public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}
