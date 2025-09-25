
using System;

class Complex
{
    double real;
    double imag;

    public Complex(double r, double i)
    {
        real = r;
        imag = i;
    }

    public Complex Add(Complex other)
    {
        return new Complex(real + other.real, imag + other.imag);
    }

    public void show()
    {
        Console.WriteLine(real + " + " + imag + " i ");
    }

    public static Complex ReadComplex()
    {
        Console.WriteLine("Enter the real part: ");
        double r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the imaginary part: ");
        double i = Convert.ToInt32(Console.ReadLine());
        return new Complex(r, i);
    }
}

class program
{
    static void Main()
    {
        Console.WriteLine("Enter the first complex number: ");
        Complex c1 = Complex.ReadComplex();

        Console.WriteLine("Enter the second complex number: ");
        Complex c2 = Complex.ReadComplex();

        Complex sum = c1.Add(c2);

        Console.WriteLine("sum= ");
        sum.show();
    }
}