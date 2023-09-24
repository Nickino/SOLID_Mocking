
namespace CSCI5220LecW04;

internal interface IShape
{
    double GetArea();
    void Draw();
}

public interface IArea
{
    double GetArea();

}
public interface IDrawable
{
    void Draw();
}


public class Circle : IShape
{
   
    public double GetArea()
    {
        // Get area
        return 0;
    }
    public void Draw()
    {
        //Draw circle
    }

    public class Rectangle : IShape
    {
        
        public double GetArea()
        {
            // Get area of rectangle
            return 0;
        }
        public void Draw()
        {
            //Draw rectangle
        }
    }

}