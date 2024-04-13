using System.Numerics;

namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
       static void Main(string[] args)
        {

            int quantiaerros = 0;

            bool jogadorenforcou = false;
           bool jogadorganhou= false;

            forca forca = new forca();

             forca.EscolherPalavraAleatoria();
            forca.extrair();

            string palavrainicial;
         
          
            do
            {

                desenharforca(quantiaerros);


                char chute = extrairchute(forca.extrair);




                for (int i = 0; i < forca.palavrainicial.Length; i++)
                {
                    char letradeagora = forca.palavrainicial[i];
                    if (chute == letradeagora)
                    {

                        forca.letras[i] = letradeagora;
                        letrasencontradas = true;
                    }


                }

                if (letrasencontradas == false)
                    forca.quantiaerros++;

                string palavra = string.Join("", forca.letras);



                forca.acertou = palavra == forca.palavrainicial;
                Program.quantiaerros(forca);

                if (forca.acertou)
                    Console.WriteLine("\nvoce acertou a palavra secreta");
                else if (forca.jogadorenforcou)
                    Console.WriteLine("\nVoce enforcou, que pena");



            } while (forca.jogadorenforcou == false && forca.acertou == false);

            Console.ReadLine();
        }

        private static void quantiaerros(forca forca)
        {
            forca.jogadorenforcou = forca.quantiaerros >= 5;
        }

        private static char extrairchute()
        {
            Console.Write("digite a letra ");
            char chute = Console.ReadLine()[0];
            return chute;
        }

        public void desenharforca(int quantiaerros, char[] letras)
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



            Console.WriteLine("\n" + string.Join("", 
        }
    }

}
    
}
