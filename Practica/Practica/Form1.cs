/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 27/10/2026
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(txtA.Text);
			double b = Convert.ToDouble(txtB.Text);
			double c = Convert.ToDouble(txtC.Text);

			double discriminante = Math.Pow(b, 2) - (4 * a * c);

			if (discriminante < 0) {
    			lblRespuesta.Text = "Las raíces son imaginarias.";
			}
			else {
    			double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
    			double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
    			lblRespuesta.Text = string.Format("x1 = {0:F2}\nx2 = {1:F2}", x1, x2);
			}
		}
	}
}
