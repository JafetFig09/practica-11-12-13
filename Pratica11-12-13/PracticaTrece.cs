using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pratica11_12_13
{
    public class PracticaTrece
    {
        double[,] calificaciones;

        public PracticaTrece()
        {
            calificaciones = new double[,]
            {
                {5.5,8.6,10},
                {8.0,5.5,10},
                {9.4,4.1,7.8},
                {10,2.2,8.1},
                {7.0,9.2,7.1},
                {9.0,4.0,6.0},
                {6.5,5.0,5.0},
                {4.0,7.0,4.0},
                {8.0,8.0,9.0},
                {10,9.0,9.2},
                {5.0,10,8.4},
                {9.0,4.6,7.5}
            
            
            };
        }

        public void PromedioAlumno( ListBox listbox)
        {
            int filas = calificaciones.GetLength(0);
            int columnas = calificaciones.GetLength(1);
            int count = 0;
            double[] promedios = new double[filas];
            double promedioMax = 0;
            double promedioMin = 0;

            for (int i = 0; i < filas; i++) 
            {
                double promedio = 0;
                for (int j = 0; j < columnas; j++)
                {
                    promedio += calificaciones[i, j] / columnas;

                    promedios[i] = promedio;
                    if(calificaciones[i, j] < 7.0)
                        count++;


                }
                if (promedio < promedioMin || promedioMin <= 0)
                    promedioMin = promedio;
                if (promedio > promedioMax)
                    promedioMax = promedio;

                listbox.Items.Add($"Promedio del Alumno {i+1}: {Math.Round(promedio, 2)}");
            }

            listbox.Items.Add($"Promedio más bajo: {Math.Round(promedioMin, 2)}");
            listbox.Items.Add($"Promedio más alto: {Math.Round(promedioMax, 2)}");
            listbox.Items.Add($"Se reprobaron: {count} parciales");

            DistribucionCalificacion(promedios, listbox);
        }


        public void DistribucionCalificacion(double[] promedios, ListBox list)
        {
            double[] limitesRangos = { 0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
            string[] etiquetasRangos = { "0 - 4.9", "5.0 - 5.9", "6.0 - 6.9", "7.0 - 7.9",
                "8.0 - 8.9", "9.0 - 10.0" };

                // Inicializa un array para contar cuántos alumnos están en cada rango
                int[] conteoRangos = new int[limitesRangos.Length - 1];

                // Recorre los promedios de los alumnos
                foreach (var promedio in promedios)
                {
                    // Encuentra el rango en el que cae el promedio
                    for (int i = 0; i < limitesRangos.Length - 1; i++)
                    {
                        if (promedio >= limitesRangos[i] && promedio < limitesRangos[i + 1])
                        {
                            // Incrementa el contador del rango correspondiente
                            conteoRangos[i]++;
                            break; 
                        }
                    }
                }

             
                for (int i = 0; i < etiquetasRangos.Length; i++)
                {
                    list.Items.Add($"{etiquetasRangos[i]}: {conteoRangos[i]} Alumnos");
                }
        }

        public void PintarArreglo(ListBox listbox1)
        {
            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < calificaciones.GetLength(1); j++)
                {
                    row += calificaciones[i, j].ToString() + "\t";
                }
                listbox1.Items.Add(row.TrimEnd());
            }
        }


    }
}
