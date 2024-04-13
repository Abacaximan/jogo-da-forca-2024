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
        public bool eleacertou()
        {
            bool letrasencontradas = false;


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




        }
       public   string EscolherPalavraAleatoria()
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
        public  char[] extrair(string palavrainicial)
        {
            char[] letras = new char[palavrainicial.Length];

            for (int caracteres = 0; caracteres < letras.Length; caracteres++)
            {


                letras[caracteres] = '*';


            }

            return letras;
        }

    }
}
