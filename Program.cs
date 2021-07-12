using System;

namespace try_catchy
{
    class Area
    {
        public static float Quad (float bas, float alt)
        {
            if(bas == 0 || alt == 0)
            {
                throw new Exception ("Base ou altura não pode ser igual a 0");
            }
            return bas*alt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float area = 0;

            /*Console.Write("Digite um valor: ");
            a = int.Parse(Console.ReadLine());

            System.Console.Write("Digite outro valor: ");
            b = int.Parse(Console.ReadLine());*/

            try
            {
                area=Area.Quad(0F, 5F);
                System.Console.WriteLine("Área do Quad.: " + area);  
            }
            catch (Exception e) 
            {
                System.Console.WriteLine("ERRO: " + e.Message);
                System.Console.WriteLine("Ex: " + e.GetType()); 
            }finally
            {
                System.Console.WriteLine("Fim do Programa");
            }
            
        }
    }
}
