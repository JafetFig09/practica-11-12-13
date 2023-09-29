using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica11_12_13
{
    public class PracticaOnce

    {
        double[,] array;
        public PracticaOnce()
        {
           
             array = new double[,]
            {
                { 2, 4, 5, 1, 2, 1, 1, 4, 4, 2 },
                { 3, 4, 4, 8, 4, 2, 3, 6, 5, 4 },
                { 5, 2, 4, 9, 6, 7, 7, 8, 4, 8 },
                { 8, 8, 7, 9, 3, 8, 6, 2, 9, 3 },
                { 9, 4, 2, 6, 1, 5, 2, 7, 2, 5 }
            };

        }


        //public double[,] LlenarArreglo()
        //{
        //    double[,] array = new double[5, 10];
        //    Random random = new Random();

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            array[i, j] = Math.Round(random.NextDouble() * 40);
        //        }
        //    }

        //    return array;
        //}


        public double[] SumarArregloFila(/*double[,] array*/)
        {
            double[] arreglo = new double[5];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];

                    
                }
                arreglo[i] = sum;
            }
            return arreglo;
        }

        public double[] PromedioArregloFila(/*double[,] array*/)
        {
            int columna = array.GetLength(1);
            double[] arreglo = new double[5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j] / columna;


                }
                arreglo[i] =Math.Round(sum,2);
            }
            return arreglo;
        }


        public double[] SumarArregloColumna(/*double[,] array*/)
        {
            double[] arreglo = new double[10];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j,i];


                }
                arreglo[i] = sum;
            }
            return arreglo;
        }

        public double[] PromedioArregloColumna(/*double[,] array*/)
        {
            int filas = array.GetLength(0);
            double[] arreglo = new double[10];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                double promedio = 0;
                double sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];


                }
                promedio = sum / filas;
                arreglo[i] = Math.Round(promedio, 2);
            }
            return arreglo;
        }

        public void PintarArreglo(ListBox listbox1)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row += array[i, j].ToString() + "\t"; // Agregar un tabulador para separar las columnas
                }
                listbox1.Items.Add(row.TrimEnd()); // Agregar la fila al ListBox y eliminar el espacio en blanco al final
            }
        }

        public void MostrarArreglo(double[] arreglo1, double[] arreglo2, ListBox listbox1)
        {
            if (arreglo1.Length != arreglo2.Length)
            {
                throw new ArgumentException("Los arreglos deben tener la misma longitud.");
            }
            listbox1.Items.Add("A | B");
            for (int i = 0; i < arreglo1.Length; i++)
            {
                string elemento = arreglo1[i].ToString() + " | " + arreglo2[i].ToString();
                listbox1.Items.Add(elemento);
            }
        }

        public void DibujarArreglo(double[] arreglo1, double[]arreglo2, ListBox listbox1)
        {
            if (arreglo1.Length != arreglo2.Length)
            {
                throw new ArgumentException("Los arreglos deben tener la misma longitud.");
            }

            string elementosConcatenados = "";
            string elementos = "";

            for (int i = 0; i < arreglo1.Length; i++)
            {
                elementosConcatenados += arreglo1[i] + "  "; // Agregar elementos con espacio como separador
                elementos += arreglo2[i] + "  ";
            }

         

            listbox1.Items.Add("C: " + elementosConcatenados);
            listbox1.Items.Add("D: " + elementos);




        }
    }
}
