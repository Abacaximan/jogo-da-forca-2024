namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        public class desenharforcaclass
        {
            public static void desenharforca(int quantiaerros, char[] letras)
            {
                string cabeca = quantiaerros >= 1 ? " o " : " ";
                string tronco = quantiaerros >= 2 ? "x" : " ";
                string troncobaixo = quantiaerros >= 2 ? " x" : " ";
                string bracoesquerdo = quantiaerros >= 3 ? "/" : " ";
                string bracodireito = quantiaerros >= 3 ? @"\" : " ";
                string pernas = quantiaerros >= 4 ? "/ \\" : " ";


                Console.Clear();
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", cabeca);
                Console.WriteLine(" |        {0}{1}{2} ", bracoesquerdo, tronco, bracodireito);
                Console.WriteLine(" |        {0}       ", troncobaixo);
                Console.WriteLine(" |        {0}       ", pernas);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");



                Console.WriteLine("\n" + string.Join("", letras));
            }
        }


    }
}
