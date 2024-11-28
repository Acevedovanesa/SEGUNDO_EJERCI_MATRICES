
using System;

internal class Program
{
    //VARIABLES GLOBALES
    static char[,] board = new char[5, 5];
    static int PosX=0, PosY=0;
    static bool escKeyPressed = false;

    private static void Main(string[] args)
    {
        //Ejercicio Tablero

      


        InitializeBoard();
        ShowBoard();
        PrintMenu();
        


    }

    private static void InitializeBoard()
    {
        for (int f = 0; f < 5; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                board[f, c] = 'X';

            }
        }

        board[PosX, PosY] = 'O';

    }

    private static void MoveO(String Direction)
    {
        board[PosX, PosY] = 'X'; //Estoy sobreescribiendo la O por la X en la posición inicial [0,0]
        switch (Direction)
        {
            case "Derecha":
                if (PosY < 4) PosY++;
                break;

                case "Izquierda":
                if (PosY > 0 ) PosY--;
                break;

                case "Arriba":
                if (PosX > 0) PosX--;
                break;

                case "Abajo":
                if (PosX < 4) PosX++;
                break;
        }

        board[PosX, PosY] = 'O';

    }

    private static void ShowBoard()
    {
        Console.Clear();
        Console.WriteLine("¡Mueva la bolita!\n");

        for (int f = 0; f < 5; f++)
        {
            for (int c = 0;c < 5; c++)
            {
                Console.Write(board[f,c] + " ");
            }

            Console.WriteLine();
        }
        
    }

    private static void PrintMenu()
    {
        while (!escKeyPressed)
        {
            ConsoleKeyInfo keyPressed; //Así declaro una variable para almacenar la tecla que pulsé

            Console.WriteLine("Use las teclas de dirección para mover la 'O', o presione 'ESC' para salir");
            Console.WriteLine("Pulse Flecha Derecha");
            Console.WriteLine("Pulse Flecha Izquierda");
            Console.WriteLine("Pulse Flecha Arriba");
            Console.WriteLine("Pulse Flecha Abajo");
            Console.WriteLine("Pulse ESC para Salir");
            keyPressed = Console.ReadKey(); //Para leer la tecla pulsada

            switch (keyPressed.Key)
            {
                case ConsoleKey.RightArrow:
                    MoveO("Derecha");
                    break;

                case ConsoleKey.LeftArrow:
                    MoveO("Izquierda");
                    break;

                case ConsoleKey.UpArrow:
                    MoveO("Arriba");
                    break;

                case ConsoleKey.DownArrow:
                    MoveO("Abajo");
                    break;

                case ConsoleKey.Escape:
                    escKeyPressed = true;
                    break;
            }
            
            ShowBoard();
        }

        
    }
}

    