namespace Ping_Pong
{
	partial class Us
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.Aceptar = new System.Windows.Forms.Button();
			this.Contrasena = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(185, 244);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Aceptar
			// 
			this.Aceptar.Location = new System.Drawing.Point(423, 244);
			this.Aceptar.Name = "Aceptar";
			this.Aceptar.Size = new System.Drawing.Size(109, 31);
			this.Aceptar.TabIndex = 3;
			this.Aceptar.Text = "Aceptar";
			this.Aceptar.UseVisualStyleBackColor = true;
			this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
			// 
			// Contrasena
			// 
			this.Contrasena.Location = new System.Drawing.Point(68, 129);
			this.Contrasena.Name = "Contrasena";
			this.Contrasena.Size = new System.Drawing.Size(117, 32);
			this.Contrasena.TabIndex = 5;
			this.Contrasena.Text = "Contrasena";
			this.Contrasena.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(200, 135);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(286, 20);
			this.textBox2.TabIndex = 7;
			// 
			// Us
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Contrasena);
			this.Controls.Add(this.Aceptar);
			this.Controls.Add(this.button1);
			this.Name = "Us";
			this.Text = "Acceso";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Aceptar;
		private System.Windows.Forms.Button Contrasena;
		private System.Windows.Forms.TextBox textBox2;
	}
}