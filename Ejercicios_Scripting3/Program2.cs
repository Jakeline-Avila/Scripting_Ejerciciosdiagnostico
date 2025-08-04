/*namespace Ejercicio_Scripting3
{
    internal class Program
    {
        static string numeroSorteo = "1162";
        static int apuesta = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu numero de 4 dígitos: ");
            string numeroJugador = Console.ReadLine();

            string mensaje = GanoOPerdio(numeroJugador);
            Console.WriteLine(mensaje);
        }

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
    }
}*/
