using System;

namespace Ejemplo {
    class Program {
        static void Main() {
            int TotalFilas = 5;
            int TotalColumnas = 10;

            //Declara un arreglo bidimensional
            int[,] Tablero = new int[TotalFilas, TotalColumnas];

            /* Llena ese arreglo bidimensional
               Tablero.GetLength(0) Retorna el número de filas (la primera dimensión)
               Tablero.GetLength(1) Retorna el número de columnas (la segunda dimensión)
               Un arreglo bidimensional inicia en [0,0]
               Un arreglo bidimensional termina en [TotalFilas-1, TotalColumnas-1]
            */
            Random azar = new Random();
            for (int fila = 0; fila < Tablero.GetLength(0); fila++)
                for (int columna = 0; columna < Tablero.GetLength(1); columna++)
                    Tablero[fila, columna] = azar.Next(0, 9);

            //Imprime ese arreglo bidimensional
            for (int fila = 0; fila < Tablero.GetLength(0); fila++) {
                Console.WriteLine(" ");
                for (int columna = 0; columna < Tablero.GetLength(1); columna++)
                    Console.Write(Tablero[fila, columna].ToString() + " ; ");
            }

            Console.ReadKey();
        }
    }
}
