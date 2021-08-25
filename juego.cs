using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
	public partial class juego : Form
	{
		public juego()
		{
			InitializeComponent();
		}

		private const int V = 10;
		int velocidad = V;
		int Cont = 0;
		int Puntaje = 0;

		bool arriba;
		bool izquierda;








		private void Juego_Load(object sender, EventArgs e)
		{

		}

		private void Juego_MouseMove(object sender, MouseEventArgs e)
		{
			pictureBox1.Top = e.Y;
			this.Text = "Puntaje: 0";
			Random aleatorio = new Random();
			pictureBox1.Location = new Point(0, aleatorio.Next(this.Height));
			arriba = true;
			izquierda = true;
			timer1.Enabled = true;
			Puntaje = 0;



		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (pictureBox2.Left > pictureBox2.Left)
			{
				timer1.Enabled = false;
				MessageBox.Show("Puntaje:" + Puntaje.ToString() + "veces!");
				Puntaje = 0;
				velocidad = 5;
				Cont = 0;

			}




			#region Movimento de la pelota
			if (izquierda)
			{
				pictureBox2.Left += velocidad;

			}
			else
			{
				pictureBox2.Left -= velocidad;
			}
			if (arriba)
			{
				pictureBox2.Top += velocidad;
			}
			else
			{
				pictureBox2.Top -= velocidad;
			}

			if (pictureBox2.Top >= this.Height - 50)
			{
				arriba = false;
			}
			if (pictureBox2.Top <= 0)
			{
				arriba = true;
			}
			if (pictureBox2.Left <= 0)
			{
				izquierda = true;
			}
			if (pictureBox2.Left >= this.Width - 10)
			{
				izquierda = false;//
			}
			#endregion
		}

		private void Juego_FormClosed(object sender, FormClosedEventArgs e)
		{


		}
	}
}
// Diagrama de Flujo en: https://www.draw.io/#G14WLchlOdrCsu1A1WewIbrJ-TU3g2ZE8U











