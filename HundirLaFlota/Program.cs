using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace HundirLaFlota
{
    class Program
    {
        static Random generaAleatorio = new Random();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); 
        }
        static int CambiaANumero(string columna)
        {
            int columnanum=0;
            switch (columna)
            {
                case "a":
                    columnanum = 0;
                 break;
                case "b":
                    columnanum = 1;
                    break;
                case "c":
                    columnanum = 2;
                    break;
                case "d":
                    columnanum = 3;
                    break;
                case "e":
                    columnanum = 4;
                    break;
                case "f":
                    columnanum = 5;
                    break;
                case "g":
                    columnanum = 6;
                    break;
                case "h":
                    columnanum = 7;
                    break;
                case "i":
                    columnanum = 8;
                    break;
                case "j":
                    columnanum = 9;
                    break;
                default:
                    columnanum = -1;
                    break;

            }
            return columnanum;
        }
        static void EscribeMapa (int [,] tablero,int [,] mapa,int fila,int columna,int [,] barco5, int[,] barco4, int[,] barco3, int[,] barco32, int[,] barco2, int [] cont)
        {
            int[] conthun = new int[5];
            if (fila >= 0 && columna >= 0)
            {
                //Implementar control del hundido
                //Añadir Funcion de control de Fin de Juego y la impresion por pantalla
                if (tablero[fila, columna] == 1)
                {
                    //if (Hundido(mapa, fila, columna, barco5, barco4, barco3, barco32, barco2, cont))
                    //{
                    //    StreamReader h1 = new StreamReader("hundido1.txt", Encoding.Default);
                    //    StreamReader h2 = new StreamReader("hundido2.txt", Encoding.Default);
                    //    StreamReader h3 = new StreamReader("hundido3.txt", Encoding.Default);
                    //    StreamReader h4 = new StreamReader("hundido4.txt", Encoding.Default);
                    //    StreamReader h5 = new StreamReader("hundido5.txt", Encoding.Default);

                    //    while (!h1.EndOfStream)
                    //    {

                    //        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (h1.ReadLine().Length / 2)) + "}", h1.ReadLine()));

                    //    }
                    //    Thread.Sleep(750);
                    //    Console.Clear();
                    //    while (!h2.EndOfStream)
                    //    {

                    //        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (h2.ReadLine().Length / 2)) + "}", h2.ReadLine()));

                    //    }
                    //    Thread.Sleep(750);
                    //    Console.Clear();
                    //    while (!h3.EndOfStream)
                    //    {

                    //        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (h3.ReadLine().Length / 2)) + "}", h3.ReadLine()));

                    //    }
                    //    Thread.Sleep(750);
                    //    Console.Clear();
                    //    while (!h4.EndOfStream)
                    //    {

                    //        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (h4.ReadLine().Length / 2)) + "}", h4.ReadLine()));

                    //    }
                    //    Thread.Sleep(750);
                    //    Console.Clear();
                    //    while (!h5.EndOfStream)
                    //    {

                    //        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (h5.ReadLine().Length / 2)) + "}", h5.ReadLine()));

                    //    }
                    //    Thread.Sleep(1000);
                    //    Console.Clear();
                    //}
                    //else
                    //{
                        Console.WriteLine("");
                        mapa[fila, columna] = 1;
                        StreamReader bar1 = new StreamReader("barco1.txt", Encoding.Default);
                        StreamReader bar2 = new StreamReader("barco2.txt", Encoding.Default);
                        StreamReader bar3 = new StreamReader("barco3.txt", Encoding.Default);
                        StreamReader bar4 = new StreamReader("barco4.txt", Encoding.Default);
                        Console.ForegroundColor = ConsoleColor.White;
                        while (!bar1.EndOfStream)
                        {

                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (bar1.ReadLine().Length / 2)) + "}", bar1.ReadLine()));

                        }
                        Thread.Sleep(500); ///500
                        Console.Clear();
                        while (!bar2.EndOfStream)
                        {

                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (bar2.ReadLine().Length / 2)) + "}", bar2.ReadLine()));

                        }
                        Thread.Sleep(500); ///500
                        Console.Clear();
                        while (!bar3.EndOfStream)
                        {

                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (bar3.ReadLine().Length / 2)) + "}", bar3.ReadLine()));

                        }
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        while (!bar4.EndOfStream)
                        {

                            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (bar4.ReadLine().Length / 2)) + "}", bar4.ReadLine()));

                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                   // }
                }
                else
                {
                    mapa[fila, columna] = 2;
                    StreamReader sr1 = new StreamReader("gota1.txt", Encoding.Default);
                    StreamReader sr2 = new StreamReader("gota2.txt", Encoding.Default);
                    StreamReader sr3 = new StreamReader("gota3.txt", Encoding.Default);
                    StreamReader sr4 = new StreamReader("gota4.txt", Encoding.Default);
                    StreamReader sr5 = new StreamReader("agua.txt", Encoding.Default);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    while (!sr1.EndOfStream)
                    {

                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sr1.ReadLine().Length / 2)) + "}", sr1.ReadLine()));

                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    while (!sr2.EndOfStream)
                    {

                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sr2.ReadLine().Length / 2)) + "}", sr2.ReadLine()));

                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    while (!sr3.EndOfStream)
                    {

                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sr3.ReadLine().Length / 2)) + "}", sr3.ReadLine()));

                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    while (!sr4.EndOfStream)
                    {

                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sr4.ReadLine().Length / 2)) + "}", sr4.ReadLine()));

                    }
                    Thread.Sleep(500);
                    Console.Clear();

                    while (!sr5.EndOfStream)
                    {
                        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sr5.ReadLine().Length / 2)) + "}", sr5.ReadLine()));

                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;


                }

                GeneraMapa(mapa, tablero, barco5, barco4, barco3, barco32, barco2);
            }
            else
            {
                GeneraMapa(mapa, tablero, barco5, barco4, barco3, barco32, barco2);
            }
        }
        static void GeneraMapa(int [,] mapa, int [,] tablero,int[,] barco5, int [,] barco4, int[,] barco3, int[,] barco32, int[,] barco2)
        {
        
            
           
            int i, j, cont;
            /*
            #region imprimir cordenadas barco 5
            for (i = 0; i < barco5.GetLength(0); i++)
            {

                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == barco5.GetLength(0) - 1)
                {
                    Console.Write("└");
                }
                else
                {
                    Console.Write("│");
                }

                for (j = 0; j < barco5.GetLength(1); j++)
                {
                    if (barco5[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(barco5[i, j] + " ");

                }
                if (j >= barco5.GetLength(1) && i == 0)
                {
                    Console.Write("┐");
                }
                else if (i == barco5.GetLength(0) - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("│");
                }
                Console.WriteLine();

            }

            #endregion


            #region imprimir cordenadas barco 4
            for (i = 0; i < barco4.GetLength(0); i++)
            {

                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == barco4.GetLength(0) - 1)
                {
                    Console.Write("└");
                }
                else
                {
                    Console.Write("│");
                }

                for (j = 0; j < barco4.GetLength(1); j++)
                {
                    if (barco5[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(barco4[i, j] + " ");

                }
                if (j >= barco5.GetLength(1) && i == 0)
                {
                    Console.Write("┐");
                }
                else if (i == barco4.GetLength(0) - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("│");
                }
                Console.WriteLine();

            }

            #endregion

            #region imprimir cordenadas barco 3
            for (i = 0; i < barco3.GetLength(0); i++)
            {

                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == barco3.GetLength(0) - 1)
                {
                    Console.Write("└");
                }
                else
                {
                    Console.Write("│");
                }

                for (j = 0; j < barco3.GetLength(1); j++)
                {
                    if (barco5[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(barco3[i, j] + " ");

                }
                if (j >= barco5.GetLength(1) && i == 0)
                {
                    Console.Write("┐");
                }
                else if (i == barco3.GetLength(0) - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("│");
                }
                Console.WriteLine();

            }

            #endregion

            #region imprimir cordenadas barco 32
            for (i = 0; i < barco32.GetLength(0); i++)
            {

                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == barco32.GetLength(0) - 1)
                {
                    Console.Write("└");
                }
                else
                {
                    Console.Write("│");
                }

                for (j = 0; j < barco32.GetLength(1); j++)
                {
                    if (barco5[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(barco32[i, j] + " ");

                }
                if (j >= barco5.GetLength(1) && i == 0)
                {
                    Console.Write("┐");
                }
                else if (i == barco32.GetLength(0) - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("│");
                }
                Console.WriteLine();

            }

            #endregion

            #region imprimir cordenadas barco 2
            for (i = 0; i < barco2.GetLength(0); i++)
            {

                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == barco2.GetLength(0) - 1)
                {
                    Console.Write("└");
                }
                else
                {
                    Console.Write("│");
                }

                for (j = 0; j < barco2.GetLength(1); j++)
                {
                    if (barco5[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(barco2[i, j] + " ");

                }
                if (j >= barco5.GetLength(1) && i == 0)
                {
                    Console.Write("┐");
                }
                else if (i == barco2.GetLength(0) - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("│");
                }
                Console.WriteLine();

            }

            #endregion

            */
            List<string> l = new List<string>() { "  ","A","B","C","D","E","F","G" ,"H","I","J" };
            for (i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("  ╔════════════════════╗");
            for (i = 0,cont=0; i < mapa.GetLength(0); i++,cont++)
            {
               Console.Write(cont+" ");
                
                    Console.Write("║");


                for (j = 0; j < mapa.GetLength(1); j++)
                {


                    switch (mapa[i, j])
                    {
                        case 0:

                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("~");
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Write(" ");
                            break;
                    }

                    if (mapa[i, j] < 10) {
                        Console.Write(" ");
                    }
                    
                }
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write("║");
                
                Console.WriteLine();


            }
            Console.WriteLine("  ╚════════════════════╝");

        }
        static void GeneraBarcos(int [,] tablero, int[,] barco5, int[,] barco4, int[,] barco3, int[,] barco32, int[,] barco2)
        {
            int[] barco = { 5, 4, 3, 3, 2 };
            int direccion, longitud, i,x,y;
            
            for (i = 0; i < barco.Length; i++)
            {
                longitud = barco[i];
                
                x = generaAleatorio.Next(10);
                y = generaAleatorio.Next(10);
                direccion = generaAleatorio.Next(2);
                if (CompruebaBarco(tablero,x,y,direccion,longitud,barco5,barco4,barco3,barco32,barco2)==false)
                {
                    i--;
                }
            }
            

        }
        static bool CompruebaBarco(int [,] tablero, int posx,int posy,int direccion,int longitud, int[,] barco5, int[,] barco4, int[,] barco3, int[,] barco32, int[,] barco2)
        {
            int i, fila, columna, j;
            if (direccion == 0)
            {
                for (i = 0; i < longitud; i++) {
                    fila = posx + i;
                    columna = posy;
                    if (CompruebaPosicion(tablero, fila, columna)==false)
                        {
                            return false;
                        }
                    }
                for (i = 0; i < longitud; i++)
                {
                    fila = posx + i;
                    columna = posy;
                    tablero[fila, columna] = 1;
                    if (longitud == 5)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            if (j % 2 != 0)
                                barco5[i, j] = fila;
                            else
                                barco5[i, j] = columna;
                        }
                    }
                    else if (longitud == 4)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            if (j % 2 != 0)
                                barco4[i, j] = fila;
                            else
                                barco4[i, j] = columna;
                        }
                    }
                    else if (longitud == 3)
                    {
                        if (barco3[2,1]==0)

                        {
                            for (j = 0; j < 2; j++)
                            {
                                if (j % 2 != 0)
                                    barco3[i, j] = fila;
                                else
                                    barco3[i, j] = columna;
                            }
                            
                        }
                        else
                        {
                            for (j = 0; j < 2; j++)
                            {
                                if (j % 2 != 0)
                                    barco32[i, j] = fila;
                                else
                                    barco32[i, j] = columna;
                            }

                        }
                    }
                    else if (longitud == 2)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            if (j % 2 != 0)
                                barco2[i, j] = fila;
                            else
                                barco2[i, j] = columna;
                        }
                    }
                }
                return true;
            }
             
           else
            {
                for (i = 0; i < longitud; i++)
                {
                    fila = posx;
                    columna = posy+i;
                    if (CompruebaPosicion(tablero, fila, columna) == false)
                    {
                        return false;
                    }
                }
                for (i = 0; i < longitud; i++)
                {
                    fila = posx;
                    columna = posy+i;
                    tablero[fila, columna] = 1;
                    if (longitud == 5)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            if (j % 2 != 0)
                                barco5[i, j] = fila;
                            else
                                barco5[i, j] = columna;
                        }
                    }
                    else if (longitud == 4)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            if (j % 2 != 0)
                                barco4[i, j] = fila;
                            else
                                barco4[i, j] = columna;
                        }
                    }
                    else if (longitud == 3)
                    {
                        if (barco3[2,1]==0)

                        {
                            for (j = 0; j < 2; j++)
                            {
                                if (j % 2 != 0)
                                    barco3[i, j] = fila;
                                else
                                    barco3[i, j] = columna;
                            }
                            
                        }
                        else
                        {
                            for (j = 0; j < 2; j++)
                            {
                                if (j % 2 != 0)
                                    barco32[i, j] = fila;
                                else
                                    barco32[i, j] = columna;
                            }

                        }
                    }
                    else if (longitud == 2)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            if (j % 2 != 0)
                                barco2[i, j] = fila;
                            else
                                barco2[i, j] = columna;
                        }
                    }
                }
                return true;

            }                  
            
            
        }
        static bool CompruebaPosicion(int[,] tablero,int fila,int columna) 
        {
            int i, j;
            if (fila < 0 || columna < 0 || fila > 9 || columna > 9)
            {
                return false;
            }
            for (i = fila - 1; i <= fila + 1; i++)

                {
                    for (j = columna - 1; j <= columna + 1; j++)
                    {
                        if (CompruebaSubposicion(i, j, tablero) == false)
                        {
                            return false;
                        }
                    }
                }
            
            return true;
        }
        static bool CompruebaSubposicion(int i, int j, int[,] tablero)
        {
            if (i < 0 || j < 0 || i > 9 || j > 9)
            {

                return true;
            }
            else
            {
                if (tablero[i, j] == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static int NumBarcos(int [,] mapa)
        {




            int i, j, cont=0;
            for (i = 0; i < mapa.GetLength(0); i++)
            {
                for (j = 0; j < mapa.GetLength(1); j++)
                {
                    if (mapa[i, j] == 1)
                    {
                        cont++;
                    }
                }
            }

                return cont;
        }
        static void PintaMenu(int k)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Continuar"));
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)-1) + "}", "Guardar"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)+11) + "}", "(Opcion no Disponible)"));
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)-2) + "}", "Salir"));
        }
        static int Menu(int[,] tablero, int[,] mapa, int fila, int numcolumna, int[,] barco5, int[,] barco4, int[,] barco3, int[,] barco32, int[,] barco2, int[] cont)
        {
            Console.Clear();
            bool ejecutar = false;
            string columna;
            for (int k = 0; ;)
            {
                PintaMenu(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);
                
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: k--; break;
                    case ConsoleKey.DownArrow: k++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 2; else if (k > 2) k = 0;
                string [] args= new string [0];
                
                int columnanum;
                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0:
                            Console.Clear();
                            
                            EscribeMapa(tablero, mapa, -1, -1, barco5, barco4, barco3, barco32, barco2, cont);
                            Console.WriteLine("Introduce la columna");
                            columna = Console.ReadLine();
                            columnanum = CambiaANumero(columna);
                            return columnanum;
                        case 1: break;
                        case 2: Environment.Exit(0); break;
                    }
                    
                }
            }
        }
        static bool Hundido(int [,] mapa,int fila, int columna,int [,] barco5, int[,] barco4, int[,] barco3, int[,] barco32, int[,] barco2, int [] cont)
        {
            int i, j;
            
            for (i = 0; i < barco5.GetLength(0); i++)
            {
                    if (columna == barco5[i, 0] && fila == barco5[i,1])
                {
                    cont[0]++;
                }
            }
            for (i = 0; i < barco4.GetLength(0); i++)
            {
                if (columna == barco4[i, 0] && fila == barco4[i, 1])
                {
                    cont[1]++;
                }
            }
            if (cont[1] >= barco5.GetLength(0))
            {
                return true;
            }
            if (cont[0]>= barco5.GetLength(0))
                {

                    return true;
                
            }
            return false;
        }


        static void Main(string[] args)
        {
            Maximize();

            StreamReader sr = new StreamReader("opening.txt", Encoding.Default);

                while (!sr.EndOfStream)
                {
                Console.WriteLine(sr.ReadLine());
   
                    
                }

            
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                                                          Pulsa cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            int[,] tablero = new int[10, 10];
            int[,] mapa = new int[10, 10];
            int[,] barco5 = new int[5, 2];
            int[,] barco4 = new int[4, 2];
            int[,] barco3 = new int[3, 2];
            int[,] barco32 = new int[3, 2];
            int[,] barco2 = new int[2, 2];
            int[] cont = new int[5];
            int columnanum, fila;
            string columna;
           
                GeneraBarcos(tablero,barco5,barco4,barco3,barco32,barco2);
                
                GeneraMapa(mapa, tablero,barco5, barco4, barco3, barco32, barco2);
                do
                {
                while (NumBarcos(mapa) < 17)
                {
                
                    Console.WriteLine("Introduce la columna: ");
                    ConsoleKeyInfo cki =  Console.ReadKey();
                    if(cki.Key == ConsoleKey.Escape)
                    {
                           columnanum=Menu(tablero, mapa, 11, 11, barco5, barco4, barco3, barco32, barco2, cont);

                    }
                    else {
                        Console.WriteLine();
                        columnanum = CambiaANumero(cki.KeyChar.ToString());
                    }
                    Console.WriteLine("Introduce la fila: ");
                    fila = int.Parse(Console.ReadLine());
                    while ((fila < 0 || fila >= 10) || (columnanum < 0 || columnanum >= 10))
                    {
                        Console.WriteLine("Las coordenadas introducidas no son validas, vuelva a introducirlas:");
                        Console.WriteLine("Introduce la columna: ");
                        columna = Console.ReadLine();
                        columnanum = CambiaANumero(columna);
                        Console.WriteLine("Introduce la fila: ");
                        fila = int.Parse(Console.ReadLine());

                    }
                    Console.Clear();
                    EscribeMapa(tablero, mapa, fila, columnanum,barco5,barco4,barco3,barco32,barco2,cont);
                 } 
            
                
                } while (Console.ReadKey().Key != ConsoleKey.Escape);



            Console.ReadKey();

        }
    }
}
