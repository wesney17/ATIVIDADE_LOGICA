﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n9
{
    class Program
    {
        static void Main(string[] args)
        {
            int MENU = 0;
            float NUM1 = 0;
            float NUM2 = 0;
            float VALOR = 0;
            int loop1 = 1;

            //------------------------------------------------------------------------------------//
            while (loop1 == 1)
            {
                Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
                Console.WriteLine("QUESTÃO NÚMERO 9º");

                Console.WriteLine("DIGITE 2 NUMETOS ");
                Console.WriteLine("DIGITE O 1º NÚMERO ");
                NUM1 = float.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE O 2º NÚMERO ");
                NUM2 = float.Parse(Console.ReadLine());

                Console.WriteLine("QUAL OPERAÇÃO MATEMATICA DESEJA REALIZAR?");
                Console.WriteLine("DIGITE 1 PARA SOMA");
                Console.WriteLine("DIGITE 2 PARA SUBTRAÇÃO");
                Console.WriteLine("DIGITE 3 PARA MULTIPLICAÇÃO");
                Console.WriteLine("DIGITE 4 PARA DIVISÃO");
                MENU = int.Parse(Console.ReadLine());


                switch (MENU)
                {
                    case 1:
                        VALOR = NUM1 + NUM2;

                        Console.WriteLine("O VALOR DA SOMA DOS NUMEROS {0} + {1} EH: {2}", NUM1 , NUM2, VALOR);
                        break;

                    case 2:
                        VALOR = NUM1 - NUM2;
                        Console.WriteLine("O VALOR DA SUBTRAÇÃO DOS NUMEROS {0} - {1} EH: {2}", NUM1, NUM2, VALOR);
                        break;

                    case 3:
                        VALOR = NUM1 * NUM2;
                        Console.WriteLine("O VALOR DA MULTIPLICAÇÃO DOS NUMEROS {0} * {1} EH: {2}", NUM1, NUM2, VALOR);
                        break;

                    case 4:
                        VALOR = NUM1 / NUM2;
                        Console.WriteLine("O VALOR DA DIVISÃO DOS NUMEROS {0} / {1} EH: {2}", NUM1, NUM2, VALOR);
                        break;


                    default:
                        Console.WriteLine("VALOR ERRADO!");
                        break;
                }


                Console.WriteLine("DIGITE NÚMERO 1 PARA REPETIR O CÁLCULO");
                Console.WriteLine("DIGITE OUTRO NÚMERO PARA SAIR");
                loop1 = int.Parse(Console.ReadLine());


            }
        }
    }
}
