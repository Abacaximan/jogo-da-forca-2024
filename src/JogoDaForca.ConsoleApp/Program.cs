using System.Numerics;

namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
       static void Main(string[] args)
        {
            #region palavra inicial
           

            forca forca = new forca();
            string palavrainicial = forca.EscolherPalavraAleatoria();
            char[] letras = forca.extrair(palavrainicial);
            Console.WriteLine(string.Join("", letras));

            #endregion
            #region desenho da forca
            do
            {


                desenharforcaclass.desenharforca(forca.quantiaerros, letras);

                char chute = extrairchute();

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
                    forca.quantiaerros++;

                string palavra = string.Join("", letras);



                forca.acertou = palavra == palavrainicial;

                forca.jogadorenforcou = forca.quantiaerros >= 5;

                if (forca.acertou)
                    Console.WriteLine("\nvoce acertou a palavra secreta");
                else if (forca.jogadorenforcou)
                    Console.WriteLine("\nVoce enforcou, que pena");



            } while (forca.jogadorenforcou == false && forca.acertou == false);

            Console.ReadLine();
        }

        private static char extrairchute()
        {
            Console.Write("digite a letra ");
            char chute = Console.ReadLine()[0];
            return chute;
        }

      

    }
    
}
