﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_logica_n8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3º PERIODO - DESENVOLVIMENTO DE SISTEMAS - WESNEY BRAZ");
            Console.WriteLine("QUESTÃO NÚMERO 8º");

            int numero = 0;
            int contador = 0;
            int valor = 0;
            int resultado = 0;
            int valorfinal = 0;
            string TESTE = "sim";

            while (TESTE == "sim")
            {
                Console.WriteLine("DIGITE UM NÚMERO PARA SABER O VALOR DE SUA FATORIAL");
                numero = int.Parse(Console.ReadLine());
                valorfinal = 0;
                contador = numero;
                contador--;
                valor = numero * contador;
                if (numero > 0)
                {
                    while (contador > 0)
                    {
                        contador--;
                        valor = valor * contador;
                        resultado = valor;

                        if(resultado>valorfinal)
                        {
                            valorfinal = resultado;
                        }
                        if(numero<=2)
                        {
                            valorfinal = numero;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("NÚMERO INVALIDO");
                }
                Console.WriteLine("O FATORIAL DE {0} EH: {1} ", numero, valorfinal);

                Console.WriteLine("DESEJA CONTINUAR ? DIGITE SIM OU NÃO");
                TESTE = Console.ReadLine();
                TESTE = TESTE.ToLower();
            }
            Console.WriteLine("FIM");
            Console.ReadKey();
        }
    }
}
