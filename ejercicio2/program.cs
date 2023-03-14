using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int diff = Math.Abs(num1 - num2);

        if (num1 > num2) {
            diff *= 2;
        }

        Console.WriteLine("El valor absoluto de la diferencia es: " + diff);
    }
}
