
/*namespace Ejercicio_Scripting3
{
    internal class Program1
    {

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de segundos: ");
            int seg = int.Parse(Console.ReadLine());

            string jsfjsi = ConvertirSegundos(seg);
            Console.WriteLine(jsfjsi);
        }


        static string ConvertirSegundos(int tsegundos)
        {
            int h = tsegundos / 3600;
            int m = (tsegundos % 3600) / 60;
            int s = tsegundos % 60;

            return $"{h}h {m}m {s}s";
        }
    }
}*/