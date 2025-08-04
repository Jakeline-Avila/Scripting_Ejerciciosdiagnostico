/*class Program
{
    static void Main()
    {
        Console.Write("Ingrese el numero de terminos: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Lista de primos: ");
        ImprimirFibonacciPrimos(n);
    }

    
    static void ImprimirFibonacciPrimos(int n)
    {
        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            int fib = i <= 1 ? i : a + b;

            if (EsPrimo(fib))
                Console.WriteLine(fib);

            a = b;
            b = fib;
        }
    }

     static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;
        if (num == 2)
            return true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}*/