namespace PracticeComposition;

public class Square
{
    private readonly Rectangle _rectangle;
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
        _rectangle = new Rectangle(side, side);
    }

    public double GetArea()
    {
        return _rectangle.GetArea();
    }
}
