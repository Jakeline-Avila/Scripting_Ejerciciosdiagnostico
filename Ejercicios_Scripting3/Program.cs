/*
namespace Ejercicio_Scripting3
{
    


    abstract class AbstractSample
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }

        }
        public abstract string PrintMessage(string temp);

        public virtual void InvertMessage(string temp)
        {

        }

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
        

        static void Main(string[] args)
        {
            MessageManager gestor = new MessageManager();
            Console.WriteLine("Escribe un texto");
            string temp = Console.ReadLine();
            gestor.ProcesarMensaje(temp);
        }
    }
}
*/