
namespace Ejercicio_Scripting3
{
    using System;

    abstract class AbstractSample
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }

        }
        public abstract string PrintMessage(string temp);

        public virtual void InvertMessage(string temp){}
    }

    class Merequetengue : AbstractSample
    {
        public override string PrintMessage(string temp)
        {
            Message = temp;                       
            Console.WriteLine(Message);
            return Message;
        }
    }
    class Tamarindo : AbstractSample
    {
        public override void InvertMessage(string temp)
        {
            Message = temp;
            char[] letras = Message.ToCharArray();
            for (int i = 0; i < letras.Length; i++)
            {
                if (char.IsUpper(letras[i]))
                {
                    letras[i] = char.ToLower(letras[i]);
                }
                else if (char.IsLower(letras[i]))
                {
                    letras[i] = char.ToUpper(letras[i]);
                }
                
            }

            Message = new string(letras);
           

        }
        public override string PrintMessage(string temp)
        {
            InvertMessage(temp);
            Console.WriteLine(Message);
            return Message;
        }
        
    }
    public class MessageManager
    {
     
       Merequetengue ImpresionNormal = new Merequetengue();
       Tamarindo ImpresionInvertida = new Tamarindo();
        public void ProcesarMensaje(string temp)
        {
            Console.WriteLine("Mensaje normal:");
            ImpresionNormal.PrintMessage(temp);
            Console.WriteLine("Mensaje invertido:");
            ImpresionInvertida.PrintMessage(temp);
        }
    }
    internal class Program
    {
        // Ejercicio 2

        static string ConvertirSegundos(int tsegundos)
        {
            int h = tsegundos / 3600;
            int m = (tsegundos % 3600) / 60;
            int s = tsegundos % 60;

            return $"{h}h {m}m {s}s";
        }

        // Ejercicio 3

        static string numeroSorteo = "1162";
        static int apuesta = 1000;

        static string GanoOPerdio(string numeroJugador)
        {
            if (numeroJugador.Length != 4 || !int.TryParse(numeroJugador, out _))
                return "Numero no invalido, debe tener 4 dígitos si o si";

            if (GanoExacto(numeroJugador))
                return $"Ganaste! Premio: ${apuesta * 4500}";
            else if (GanoDesorden(numeroJugador))
                return $"Ganaste! Premio: ${apuesta * 200}";
            else if (GanoUltimos3(numeroJugador))
                return $"Ganaste! Premio: ${apuesta * 400}";
            else if (GanoUltimos2(numeroJugador))
                return $"Ganaste! Premio: ${apuesta * 50}";
            else if (GanoUltimo1(numeroJugador))
                return $"Ganaste! Premio: ${apuesta * 5}";
            else
                return "No ganaste!";
        }


        static bool GanoExacto(string numeroJugador)
        {
            return numeroJugador == numeroSorteo;
        }


        static bool GanoDesorden(string numeroJugador)
        {
            char[] sorteo = numeroSorteo.ToCharArray();
            char[] jugador = numeroJugador.ToCharArray();
            Array.Sort(sorteo);
            Array.Sort(jugador);
            return new string(sorteo) == new string(jugador) && numeroJugador != numeroSorteo;
        }


        static bool GanoUltimos3(string numeroJugador)
        {
            return numeroJugador.Substring(1) == numeroSorteo.Substring(1);
        }


        static bool GanoUltimos2(string numeroJugador)
        {
            return numeroJugador.Substring(2) == numeroSorteo.Substring(2);
        }


        static bool GanoUltimo1(string numeroJugador)
        {
            return numeroJugador[3] == numeroSorteo[3];
        }

        // Ejercicio 4

        static void ImprimirFibonacciPrimos(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("El número de términos debe ser mayor que cero.");
                return;
            }
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

        // Main

        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una actividad:");
            Console.WriteLine("1. Ejercicio de Conversión de mensaje");
            Console.WriteLine("2. Ejercicio de conversión de segundos");
            Console.WriteLine("3. Ejercicio de lotería");
            Console.WriteLine("4. Ejercicio de primos de Fibonacci");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    MessageManager gestor = new MessageManager();
                    Console.WriteLine("Escribe un texto");
                    string temp = Console.ReadLine();
                    gestor.ProcesarMensaje(temp);
                    break;
                case 2:
                    Console.Write("Ingrese la cantidad de segundos: ");
                    int seg = int.Parse(Console.ReadLine());
                    string jsfjsi = ConvertirSegundos(seg);
                    Console.WriteLine(jsfjsi);
                    break;
                case 3:
                    Console.WriteLine("Escribe tu numero de 4 dígitos: ");
                    string numeroJugador = Console.ReadLine();
                    string mensaje = GanoOPerdio(numeroJugador);
                    Console.WriteLine(mensaje);
                    break;
                case 4:
                    Console.Write("Ingrese el numero de terminos: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lista de primos: ");
                    ImprimirFibonacciPrimos(n);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }            
        }
    }
}
