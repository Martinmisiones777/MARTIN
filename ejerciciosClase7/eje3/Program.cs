﻿using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero ;
            Console.WriteLine("ingrese un numero del 1 al 7");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                {
                    Console.WriteLine("LUNES");
                }break;

                case 2:
                {
                    Console.WriteLine("MARTES");
                }break;

                case 3:
                {
                    Console.WriteLine("MIERCOLES");
                }break;

                case 4:
                {
                    Console.WriteLine("JUEVES");
                }break;

                case 5:
                {
                    Console.WriteLine("VIERNES");
                }break;

                case 6:
                {
                    Console.WriteLine("SABADO");
                }break;
                case 7:
                {
                    Console.WriteLine("DOMINGO")
                }break;
                default:
                    Console.WriteLine("numero incorrecto");
                    break;
                
                
               
            } 
        }
    }
}
