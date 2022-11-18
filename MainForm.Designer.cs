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
		private System.Windows.Forms.Button opakuj_btn;
		private System.Windows.Forms.Button koniecOpak_btn;
		private System.Windows.Forms.TextBox cmd;
		private System.Windows.Forms.Button vykonaj_btn;
		private System.Windows.Forms.Label label1;
		
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
			this.opakuj_btn = new System.Windows.Forms.Button();
			this.koniecOpak_btn = new System.Windows.Forms.Button();
			this.cmd = new System.Windows.Forms.TextBox();
			this.vykonaj_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
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
			// opakuj_btn
			// 
			this.opakuj_btn.Location = new System.Drawing.Point(872, 512);
			this.opakuj_btn.Name = "opakuj_btn";
			this.opakuj_btn.Size = new System.Drawing.Size(144, 104);
			this.opakuj_btn.TabIndex = 3;
			this.opakuj_btn.Text = "Opakuj 1 krát";
			this.opakuj_btn.UseVisualStyleBackColor = true;
			this.opakuj_btn.Click += new System.EventHandler(this.Opakuj_btnClick);
			// 
			// koniecOpak_btn
			// 
			this.koniecOpak_btn.Location = new System.Drawing.Point(1088, 520);
			this.koniecOpak_btn.Name = "koniecOpak_btn";
			this.koniecOpak_btn.Size = new System.Drawing.Size(144, 96);
			this.koniecOpak_btn.TabIndex = 4;
			this.koniecOpak_btn.Text = "Koniec opakovania";
			this.koniecOpak_btn.UseVisualStyleBackColor = true;
			this.koniecOpak_btn.Click += new System.EventHandler(this.KoniecOpak_btnClick);
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
			// vykonaj_btn
			// 
			this.vykonaj_btn.Location = new System.Drawing.Point(784, 1056);
			this.vykonaj_btn.Name = "vykonaj_btn";
			this.vykonaj_btn.Size = new System.Drawing.Size(312, 88);
			this.vykonaj_btn.TabIndex = 7;
			this.vykonaj_btn.Text = "Vykonaj príkazy";
			this.vykonaj_btn.UseVisualStyleBackColor = true;
			this.vykonaj_btn.Click += new System.EventHandler(this.Vykonaj_btnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 976);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 208);
			this.label1.TabIndex = 8;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1532, 1209);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.vykonaj_btn);
			this.Controls.Add(this.cmd);
			this.Controls.Add(this.koniecOpak_btn);
			this.Controls.Add(this.opakuj_btn);
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
