namespace PracticeComposition;

public class Rectangle
{
    public double Height {  get; set; }
    public double Width { get; set; }

    public Rectangle()
    {
        
    }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double GetArea()
    {
        return Height*Width;

    }
}
