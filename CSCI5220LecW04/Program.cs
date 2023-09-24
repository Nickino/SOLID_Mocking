
using CSCI5220LecW04;

class ISPMain
{
    static void Main(string[] args)
    {
        ISPMain app = new ISPMain();
        IShape[] shapes = { new Circle(), new Rectangle() };
        app.DrawTheShapes(shapes);
    }

    public void DrawTheShapes(IShape[] shapes)
    {
        //loop through and draw the shapes
        // Note taht this method has access to GetArea() method
        // even though it is not used
        foreach (var shape in shapes)
        {
            shape.Draw();
            shape.GetArea(); //will complie
        }
    }


}