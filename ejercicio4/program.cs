using System;

class House {
    private double area;
    private Door door;

    public House(double area) {
        this.area = area;
        door = new Door();
    }

    public double Area {
        get { return area; }
        set { area = value; }
    }

    public Door GetDoor() {
        return door;
    }

    public void ShowData() {
        Console.WriteLine("Soy una casa, mi área es de {0} m2", area);
    }
}

class Door {
    private string color;

    public string Color {
        get { return color; }
        set { color = value; }
    }

    public void ShowData() {
        Console.WriteLine("Soy una puerta, mi color es {0}", color);
    }
}

class SmallApartment : House {
    public SmallApartment() : base(50) {
    }
}

class Person {
    private string name;
    private House house;

    public Person(string name, House house) {
        this.name = name;
        this.house = house;
    }

    public void ShowData() {
        Console.Write("Mi nombre es {0}. ", name);
        house.ShowData();
        house.GetDoor().ShowData();
    }
}

class Program {
    static void Main(string[] args) {
        SmallApartment smallApartment = new SmallApartment();
        Person person = new Person("Juan", smallApartment);

        person.ShowData();
    }
}
