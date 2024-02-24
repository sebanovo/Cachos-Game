using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cachos_Game
{
    public partial class Dados : Form
    {
        public Dados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dado1, dado2, dado3, dado4, dado5;
            Random aleatorio = new Random();
            dado1 = aleatorio.Next(1,7);
            dado2 = aleatorio.Next(1,7);
            dado3 = aleatorio.Next(1,7);
            dado4 = aleatorio.Next(1,7);
            dado5 = aleatorio.Next(1,7);
            ponerDadoEnPicture(dado1, pictureBox1);
            ponerDadoEnPicture(dado2, pictureBox2);
            ponerDadoEnPicture(dado3, pictureBox3);
            ponerDadoEnPicture(dado4, pictureBox4);
            ponerDadoEnPicture(dado5, pictureBox5);


            int[] dados = { dado1, dado2, dado3, dado4, dado5 };

            if (EsLaGrande(dados))
            {
                textBox1.Text = "ES LA GRANDE!!!";
            }
            else if (EsPoker(dados))
            {
                textBox1.Text = "ES POKER!!!";
            }
            else if (EsFull(dados))
            {
                textBox1.Text = "ES FULL!!!";
            }
            else if (EsEscalera(dados))
            {
                textBox1.Text = "ES ESCALERA!!!";
            }
            else if (EsTrica(dados))
            {
                textBox1.Text = "ES TRICA!!!";
            }
            else if (EsPar(dados))
            {
                textBox1.Text = "ES PAR!!!";
            }
            else if (EsChanfle(dados))
            {
                textBox1.Text = "ES CHANFLE";
            }




        }

        public void ponerDadoEnPicture(int dado, PictureBox picture)
        {
            if (dado == 1)
            {
                picture.Image = Properties.Resources.cara1;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (dado == 2)
            {
                picture.Image = Properties.Resources.cara2;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (dado == 3)
            {
                picture.Image = Properties.Resources.cara3;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (dado == 4)
            {
                picture.Image = Properties.Resources.cara4;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (dado == 5)
            {
                picture.Image = Properties.Resources.cara5;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (dado == 6)
            {
                picture.Image = Properties.Resources.cara6;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private bool EsLaGrande(int[] dados)
        {
            // Verificar si los 5 dados son iguales
            return dados.All(dado => dado == dados[0]);
        }

        private bool EsPoker(int[] dados)
        {
            // Verificar si hay 4 dados iguales y 1 diferente
            Array.Sort(dados);
            return (dados[0] == dados[1] && dados[1] == dados[2] && dados[2] == dados[3]) ||
                   (dados[1] == dados[2] && dados[2] == dados[3] && dados[3] == dados[4]);
        }

        private bool EsFull(int[] dados)
        {
            // Verificar si hay 2 dados iguales y 3 dados iguales
            Array.Sort(dados);
            return (dados[0] == dados[1] && dados[2] == dados[3] && dados[3] == dados[4]) ||
                   (dados[0] == dados[1] && dados[1] == dados[2] && dados[3] == dados[4]);
        }

        private bool EsEscalera(int[] dados)
        {
            // Verificar si los dados son correlativos (12345 o 23456)
            Array.Sort(dados);
            return (dados[0] == 1 && dados[1] == 2 && dados[2] == 3 && dados[3] == 4 && dados[4] == 5) ||
                   (dados[0] == 2 && dados[1] == 3 && dados[2] == 4 && dados[3] == 5 && dados[4] == 6);
        }

        private bool EsTrica(int[] dados)
        {
            // Verificar si hay 3 dados iguales y 2 diferentes
            Array.Sort(dados);
            return (dados[0] == dados[1] && dados[1] == dados[2] && dados[3] != dados[4]) ||
                   (dados[0] != dados[1] && dados[2] == dados[3] && dados[3] == dados[4]);
        }

        private bool EsPar(int[] dados)
        {
            // Verificar si hay 2 dados iguales y 3 diferentes
            Array.Sort(dados);
            return (dados[0] == dados[1] && dados[2] != dados[3] && dados[3] != dados[4]) ||
                   (dados[0] != dados[1] && dados[1] == dados[2] && dados[3] != dados[4]);
        }

        private bool EsChanfle(int[] dados)
        {
            // Ninguna de las anteriores
            return !EsLaGrande(dados) && !EsPoker(dados) && !EsFull(dados) &&
                   !EsEscalera(dados) && !EsTrica(dados) && !EsPar(dados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
