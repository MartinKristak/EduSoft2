/*
 * Created by SharpDevelop.
 * User: matia
 * Date: 16. 11. 2022
 * Time: 14:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Edusoft2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button vlavo_btn;
		private System.Windows.Forms.Button vpravo_btn;
		private System.Windows.Forms.Button vpred_btn;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox cmd;
		
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
			this.vlavo_btn = new System.Windows.Forms.Button();
			this.vpravo_btn = new System.Windows.Forms.Button();
			this.vpred_btn = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.cmd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// vlavo_btn
			// 
			this.vlavo_btn.Location = new System.Drawing.Point(784, 392);
			this.vlavo_btn.Name = "vlavo_btn";
			this.vlavo_btn.Size = new System.Drawing.Size(120, 104);
			this.vlavo_btn.TabIndex = 0;
			this.vlavo_btn.Text = "Otoč vľavo";
			this.vlavo_btn.UseVisualStyleBackColor = true;
			this.vlavo_btn.Click += new System.EventHandler(this.Vlavo_btnClick);
			// 
			// vpravo_btn
			// 
			this.vpravo_btn.Location = new System.Drawing.Point(1128, 392);
			this.vpravo_btn.Name = "vpravo_btn";
			this.vpravo_btn.Size = new System.Drawing.Size(136, 120);
			this.vpravo_btn.TabIndex = 1;
			this.vpravo_btn.Text = "Otoč vpravo";
			this.vpravo_btn.UseVisualStyleBackColor = true;
			this.vpravo_btn.Click += new System.EventHandler(this.Vpravo_btnClick);
			// 
			// vpred_btn
			// 
			this.vpred_btn.Location = new System.Drawing.Point(928, 392);
			this.vpred_btn.Name = "vpred_btn";
			this.vpred_btn.Size = new System.Drawing.Size(112, 72);
			this.vpred_btn.TabIndex = 2;
			this.vpred_btn.Text = "Vpred";
			this.vpred_btn.UseVisualStyleBackColor = true;
			this.vpred_btn.Click += new System.EventHandler(this.Vpred_btnClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(904, 512);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 72);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(1088, 520);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 72);
			this.button5.TabIndex = 4;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// cmd
			// 
			this.cmd.Location = new System.Drawing.Point(784, 632);
			this.cmd.Multiline = true;
			this.cmd.Name = "cmd";
			this.cmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.cmd.Size = new System.Drawing.Size(464, 400);
			this.cmd.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1304, 1157);
			this.Controls.Add(this.cmd);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.vpred_btn);
			this.Controls.Add(this.vpravo_btn);
			this.Controls.Add(this.vlavo_btn);
			this.Name = "MainForm";
			this.Text = "Edusoft2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
