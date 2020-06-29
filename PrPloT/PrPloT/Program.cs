using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrPloT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int reslt = 1, select;
            string player, maquina;
            string[] jugadas = {"Piedra", "Papel", "Tijera"};
            
            while(reslt == 1)
            {
                Console.Write("elige una opcion: [1:Piedra; 2:Papel; 3:Tijera]: ");
                select = int.Parse(Console.ReadLine());
                player = jugadas [select - 1];
                maquina = jugadas[rnd.Next(0,2)];

                if ((player == "Piedra") && (maquina == "Tijera"))
                    Console.Write("ganaste!, la maquina eligio: " + maquina + "\n");
                else if ((player == "Papel ") && (maquina == "Piedra"))
                    Console.Write("ganaste!, la maquina eligio: " + maquina + "\n");
                else if ((player == "Tijera") && (maquina == "Papel"))
                    Console.Write("ganaste!, la maquina eligio: " + maquina + "\n");

                if ((maquina == "Piedra") && (player == "Tijera"))
                    Console.Write("Gano la maquina porque eligio: " + maquina + "\n");
                else if ((maquina == "Papel") && (player == "Piedra"))
                    Console.Write("Gano la maquina porque eligio " + maquina + "\n");
                else if ((maquina == "Tijera") && (player == "Papel"))
                    Console.Write("Gano la  maquina porque eligio: " + maquina + "\n");

                if ((maquina == "Piedra") && (player == "Piedra"))
                    Console.Write("Es un empate!, ambos eligieron " + player + "\n");
                else if ((maquina == "Papel") && (player == "Papel"))
                    Console.Write("Es un empate!, ambos eligieron " +player + "\n");
                else if ((maquina == "Tijera") && (player == "Tijera"))
                    Console.Write("Es un empate!, ambos eligieron " + player + "\n");

                Console.Write("\n Desea jugar denuevo? 1: si 0: no: ");
                reslt = int.Parse(Console.ReadLine());
            }
        }
    }
}
