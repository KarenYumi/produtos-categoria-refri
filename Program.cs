using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continua;
            char refri, categoria;
            float p_unitario, final_ = 0, impost = 0, esto = 0;
            
            do
            {
              
                Console.WriteLine("Digite o valor do produto:");
                p_unitario = float.Parse(Console.ReadLine());

                if (p_unitario <= 20)
                {
                    Console.WriteLine("Digite a categoria do produto (A - ALimento, L - limpeza ou V - Vestimenta)");
                    categoria = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine("\nNão possue refrigeração!");

                    if (categoria == 'A')
                    {
                        impost = p_unitario * 0.02f;
                        esto = 5;
                    }
                    else if (categoria == 'L')
                    {
                        impost = p_unitario * 0.02f;
                        esto = 10;
                    }
                    else
                    {
                        impost = p_unitario * 0.02f;
                        esto = 15;
                    }

                }
                if (p_unitario > 20 && p_unitario <= 50)
                {
                    Console.WriteLine("Digite se o produto tem refrigeração (S se necessita, caso contrário N)");
                    refri = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine("\nNão possue categoria!");

                    if (refri == 's')
                    {
                        impost = p_unitario * 0.02f;
                        esto = 21;
                    }
                    else
                    {
                        impost = p_unitario * 0.02f;
                        esto = 0;
                    }
                }
                if (p_unitario > 50)
                {
                    Console.WriteLine("Digite se o profuto tem refrigeração refrigeração (S se necessita, caso contrário N):");
                    refri = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine("Digite a categoria (A-alimento, L-limpeza ou V vestuário):");
                    categoria = char.Parse(Console.ReadLine().ToUpper());

                    if (refri == 'S')
                    {
                        if (categoria == 'A')
                        {
                            impost = p_unitario * 0.04f;
                            esto = 6;
                        }
                        else if (categoria == 'L')
                        {
                            impost = p_unitario * 0.02f;
                            esto = 2;
                        }
                        else
                        {
                            impost = p_unitario * 0.02f;
                            esto = 4;
                        }
                    }
                
                    else if (refri == 'N')
                    {
                        if (categoria == 'A' || categoria == 'V')
                        {
                            impost = p_unitario * 0.02f;
                            esto = 0;
                        }
                        else
                        {
                             impost = p_unitario * 0.02f;
                             esto = 1;
                        }
                    }
                }

                final_ = esto + p_unitario + impost;
                Console.WriteLine($"\nPreço do unitario: R$ {p_unitario}");
                Console.WriteLine($"Preço de estocagem: R${esto}");
                Console.WriteLine($"Preço do imposto: R${impost:F2}");
                Console.WriteLine($"Total: R${final_}");


                Console.WriteLine("---------------------------------");

                Console.WriteLine("Deseja continuar? (S/N)");
                continua = char.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine("---------------------------------");

            }
            while (continua == 'S');

        }
    }
}