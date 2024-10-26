using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pista
{
    public partial class Form1 : Form
    {
        enum Posicion { izquierda, derecha, arriba, abajo };
        private int x, y;
        private Posicion objPosicion;
        public Form1()
        {
            InitializeComponent();
            x = 250;
            y = 350;
            objPosicion = Posicion.derecha;
        }

        // --> activar paint desde el diseño del porn
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("C:\\Users\\paulo\\OneDrive\\Documentos\\C#\\pista\\mcqueen.png"), x, y, 120, 100);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            { objPosicion = Posicion.izquierda; }
            else if (e.KeyCode == Keys.Right)
            { objPosicion = Posicion.derecha; }
            else if (e.KeyCode == Keys.Up)
            { objPosicion = Posicion.arriba; }
            else if (e.KeyCode == Keys.Down)
            { objPosicion = Posicion.abajo; }
            timer1_Tick(sender, e);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (objPosicion == Posicion.derecha)
                {
                    x += 10;
                }
                else if (objPosicion == Posicion.izquierda)
                {
                    x -= 10;
                }
                else if (objPosicion == Posicion.arriba)
                {
                    y -= 10;
                }
                else if (objPosicion == Posicion.abajo)
                {
                    y += 10;
                }
                Invalidate();
            }
        }
    }
}
