/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 16/11/2021
 * Time: 11:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Holamundo_
{
	partial class MainForm
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
			this.btn1 = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(55, 136);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(166, 64);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Saludar";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(95, 65);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(96, 28);
			this.lbl1.TabIndex = 1;
			this.lbl1.Text = "ingrese su nombre";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(38, 96);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(207, 20);
			this.txt1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btn1);
			this.Name = "MainForm";
			this.Text = "Holamundo}";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btn1;
	}
}
