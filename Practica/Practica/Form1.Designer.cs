/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 27/10/2026
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.Location = new System.Drawing.Point(21, 26);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(100, 23);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Valor de A:";
			this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblB
			// 
			this.lblB.Location = new System.Drawing.Point(127, 26);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(100, 23);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "Valor de B:";
			this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblC
			// 
			this.lblC.Location = new System.Drawing.Point(233, 26);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(100, 23);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "Valor de C:";
			this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(19, 71);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(102, 20);
			this.txtA.TabIndex = 3;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(127, 71);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 20);
			this.txtB.TabIndex = 4;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(233, 71);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 20);
			this.txtC.TabIndex = 5;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(53, 179);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(248, 67);
			this.lblRespuesta.TabIndex = 6;
			this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(141, 123);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 7;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(358, 288);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblA;
	}
}
