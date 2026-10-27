/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 27/10/2026
 * Time: 07:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double lblNumero1 = Convert.ToDouble(txtNumero1.Text);
			double lblNumero2 = Convert.ToDouble(txtNumero2.Text);
			lblRespueta.Text = "Resultado: " + (lblNumero1 + lblNumero2);
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double lblNumero1 = Convert.ToDouble(txtNumero1.Text);
			double lblNumero2 = Convert.ToDouble(txtNumero2.Text);
			lblRespueta.Text = "Resultado: " + (lblNumero1 - lblNumero2);
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double lblNumero1 = Convert.ToDouble(txtNumero1.Text);
			double lblNumero2 = Convert.ToDouble(txtNumero2.Text);
			lblRespueta.Text = "Resultado: " + (lblNumero1 * lblNumero2);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double lblNumero1 = Convert.ToDouble(txtNumero1.Text);
			double lblNumero2 = Convert.ToDouble(txtNumero2.Text);
			lblRespueta.Text = "Resultado: " + (lblNumero1 / lblNumero2);
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double lblNumero1 = Convert.ToDouble(txtNumero1.Text);
			double lblNumero2 = Convert.ToDouble(txtNumero2.Text);
			lblRespueta.Text = "Resultado: " + (lblNumero1 % lblNumero2);
		}
		
		void BtnFormClick(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			this.Hide();
			f.Show();
		}
	}
}
