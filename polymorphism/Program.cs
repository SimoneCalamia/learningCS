/*class Program{
    public static void Main() {

        var shapes = new List<Shape> {

            new Rectangle(),
            new Triangle(),
            new Circle()
        };

        foreach (var shape in shapes) {
            shape.Draw();
        }
    }
}*/

public class Shape {
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void Draw() {
        Console.WriteLine("Performing base class drawing task");
    }
}

public class Rectangle : Shape {
    public override void Draw() {
        // code to draw a circle
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}

public class Circle : Shape {
    public override void Draw() {
        // code to draw a circle
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}

public class Triangle : Shape {
    public override void Draw() {
        // code to draw a circle
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}
