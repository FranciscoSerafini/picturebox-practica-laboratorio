using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox_cuadrados
{
    public partial class Form1 : Form
    {
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //int x =0;
            //int y =0;
            //int contador = 0;
            



            //for (int x = 0; x < 8; x++)
            //{
            //    for (int y = 0; y < 8; y++)
            //    {
            //        grafico.FillRectangle(Brushes.Red, x, 0, 100, 100);
            //        x = x + 100;
            //        grafico.FillRectangle(Brushes.Black, x, 0, 100, 100);
            //        x = x + 100;
            //    }
            //}



            //while (x < 800)
            //{
            //    grafico.FillRectangle(Brushes.Red, x, 0, 100, 100);
            //    x = x + 100;
            //    grafico.FillRectangle(Brushes.Black, x, 0, 100, 100);
            //    x = x + 100;
            //    y = 0;
            //    while (y < 800)
            //    {
            //        grafico.FillRectangle(Brushes.Red, 0, y, 100, 100);
            //        y = y + 100;
            //        grafico.FillRectangle(Brushes.Black, 0, y, 100, 100);
            //        y = y + 100;
            //    }


            //}
             


            int tamaño = 100; // Tamaño de los cuadrados
            int numFila = 800 / tamaño; // Número de filas 
            int numColumnas = 800 / tamaño; // Número de columnas 

            for (int row = 0; row < numFila; row++)
            {
                for (int col = 0; col < numColumnas; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        // Dibujar un cuadrado rojo
                        grafico.FillRectangle(Brushes.Red, col * tamaño, row * tamaño, tamaño, tamaño);
                    }
                    else
                    {
                        // Dibujar un cuadrado negro
                        grafico.FillRectangle(Brushes.Black, col * tamaño, row * tamaño, tamaño, tamaño);
                    }
                }
            }















        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grafico = pictureBox1.CreateGraphics();
        }
    }
}
