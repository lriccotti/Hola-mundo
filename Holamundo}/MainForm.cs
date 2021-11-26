/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 16/11/2021
 * Time: 11:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Holamundo_
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
		
		void Btn1Click(object sender, EventArgs e)
		{
			string nombre=txt1.Text;
			lbl1.Text="Hola "+nombre;			
		}
	}
}
