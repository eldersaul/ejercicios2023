using System;

class Program {
    static void Main(string[] args) {
        double anchura, altura, perimetro, area, diagonal;

        Console.Write("Introduce la anchura del rectángulo: ");
        anchura = double.Parse(Console.ReadLine());

        Console.Write("Introduce la altura del rectángulo: ");
        altura = double.Parse(Console.ReadLine());

        perimetro = 2 * (anchura + altura);
        area = anchura * altura;
        diagonal = Math.Sqrt(Math.Pow(anchura, 2) + Math.Pow(altura, 2));

        Console.WriteLine("Perímetro: {0}", perimetro);
        Console.WriteLine("Área: {0}", area);
        Console.WriteLine("Diagonal: {0}", diagonal);
    }
}
