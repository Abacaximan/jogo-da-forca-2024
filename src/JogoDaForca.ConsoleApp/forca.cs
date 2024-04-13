using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    internal class forca
    {

     public  int quantiaerros ;

       public bool jogadorenforcou  ;
       public bool acertou  ;
        public string palavrainicial;
        public char[] letras;

        public bool eleacertou(char chute,string palavrainicial, char[] letras)
        {
            bool letrasencontradas = false;


            
            for (int i = 0; i < palavrainicial.Length; i++)
            {
                char letradeagora = palavrainicial[i];
                if (chute == letradeagora)
                {

                    letras[i] = letradeagora;
                    letrasencontradas = true;
                }


            }

            


        }
       public void EscolherPalavraAleatoria()
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

            palavrainicial = palavras[indiceEscolhido];
        }
        public char[]extrair (string palavrainicial)
        {
            letras = new char[palavrainicial.Length];

            for (int caracteres = 0; caracteres < letras.Length; caracteres++)
            {


                letras[caracteres] = '*';


            }

            return letras;
        }

    }
}
