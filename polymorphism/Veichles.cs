
public class Program {

    public static void Main() {
        var vehicles = new List<Veichles> { new Car(), new Bus(), new Plane() };
        var shapes = new List<Shape> { new Circle(), new Triangle(), new Rectangle() };
        foreach (var vehicle in vehicles) {
            vehicle.Build(100);
            Console.WriteLine($"The {vehicle.Name} has a speed of {vehicle.Speed} m/s");
        }
    }
}

public class Veichles {

    // members
    private int _speed;
    private int _wheels;
    private string? _name;

    // properties
    public int Speed {
        set { _speed = value; }
        get { return _speed; }
    }
    public string? Name {
        set { _name = value; }
        get { return _name; }
    }

    public int Wheels {
        set { _wheels = value; }
        get { return _wheels; }
    }

    // methods
    public virtual void Build(int speed) {
        Speed = speed;
    }
}

public class Car : Veichles {

    // methods
    public override void Build(int speed) {
        this.Speed = speed / 2;
        Name = "Car";
    }
}

public class Bus : Veichles {

    // methods
    public override void Build(int speed) {
        this.Speed = speed / 5;
        Name = "Bus";
    }
}

public class Plane : Veichles {

    // methods
    public override void Build(int speed) {
        this.Speed = speed * 2;
        Name = "Plane";
    }
}
