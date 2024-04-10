using System.Numerics;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region palavra inicial
            int quantiaerros = 0;
          
            bool jogadorenforcou = false;
            bool acertou = false;

            string palavrainicial = EscolherPalavraAleatoria();

            char[] letras = new char[palavrainicial.Length];

            for (int caracteres = 0; caracteres < letras.Length; caracteres++)
            {


                letras[caracteres] = '-';


            }

            Console.WriteLine(string.Join("", letras));
            #endregion
            #region desenho da forca
            do
            {

                //forca desenhada

                string cabeca = quantiaerros >= 1 ? " o " : " ";
                string tronco = quantiaerros >= 2 ? "x" : " ";
                string troncobaixo = quantiaerros >= 2 ? " x" : " ";
                string bracoesquerdo = quantiaerros >= 3 ? "/" : " ";
                string bracodireito = quantiaerros >= 3 ? @"\" : " ";
                string pernas = quantiaerros >= 4 ? "/ \\" : " ";


                Console.Clear();
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ",  cabeca);
                Console.WriteLine(" |        {0}{1}{2} ", bracoesquerdo, tronco, bracodireito);
                Console.WriteLine(" |        {0}       ", troncobaixo);
                Console.WriteLine(" |        {0}       ", pernas);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");



                Console.WriteLine("\n" + string.Join("", letras));

                Console.Write("digite a letra ");
                char chute = Console.ReadLine()[0];


                bool letrasencontradas = false;

                #endregion
                #region processamento das informaçoes
                for (int i = 0; i < palavrainicial.Length; i++)
                {
                    char letradeagora = palavrainicial[i];
                    if (chute == letradeagora)
                    {

                        letras[i] = letradeagora;
                        letrasencontradas = true;
                    }


                }

                if (letrasencontradas == false)
                    quantiaerros++;

                string palavra = string.Join("", letras);



                acertou = palavra == palavrainicial;

                jogadorenforcou = quantiaerros >= 5;

                if (acertou)
                    Console.WriteLine("\nvoce acertou a palavra secreta");
                else if (jogadorenforcou)
                    Console.WriteLine("\nVoce enforcou, que pena");

                
                
            } while (jogadorenforcou == false && acertou == false);

            Console.ReadLine();
        }
        #endregion
        private static string EscolherPalavraAleatoria()
        {
            string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);

            return palavras[indiceEscolhido];
        }
    }
}
