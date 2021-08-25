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
	public partial class MensajeBox : Form
	{
		public MensajeBox()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Password.Text == "123456")
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
			Hide();
		}
	
	}
}

// Diagrama de Flujo en https://www.draw.io/#G14WLchlOdrCsu1A1WewIbrJ-TU3g2ZE8U