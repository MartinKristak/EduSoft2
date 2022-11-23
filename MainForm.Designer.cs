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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button nasledujuca_btn;
		private System.Windows.Forms.Button predchadzajuca_btn;
		private System.Windows.Forms.Button znova_btn;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nasledujuca_btn = new System.Windows.Forms.Button();
			this.predchadzajuca_btn = new System.Windows.Forms.Button();
			this.znova_btn = new System.Windows.Forms.Button();
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
			this.opakuj_btn.Text = "Opakuj 2 krat";
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
			this.vykonaj_btn.Location = new System.Drawing.Point(944, 1048);
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
			this.label1.Size = new System.Drawing.Size(744, 64);
			this.label1.TabIndex = 8;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 1032);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 64);
			this.label2.TabIndex = 9;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(248, 1128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 64);
			this.label3.TabIndex = 10;
			this.label3.Text = "label3";
			// 
			// nasledujuca_btn
			// 
			this.nasledujuca_btn.Location = new System.Drawing.Point(472, 1016);
			this.nasledujuca_btn.Name = "nasledujuca_btn";
			this.nasledujuca_btn.Size = new System.Drawing.Size(184, 184);
			this.nasledujuca_btn.TabIndex = 11;
			this.nasledujuca_btn.Text = "Nasledujúca úloha";
			this.nasledujuca_btn.UseVisualStyleBackColor = true;
			this.nasledujuca_btn.Click += new System.EventHandler(this.Nasledujuca_btnClick);
			// 
			// predchadzajuca_btn
			// 
			this.predchadzajuca_btn.Location = new System.Drawing.Point(24, 1032);
			this.predchadzajuca_btn.Name = "predchadzajuca_btn";
			this.predchadzajuca_btn.Size = new System.Drawing.Size(184, 160);
			this.predchadzajuca_btn.TabIndex = 12;
			this.predchadzajuca_btn.Text = "Predchádzajúca úloha";
			this.predchadzajuca_btn.UseVisualStyleBackColor = true;
			this.predchadzajuca_btn.Click += new System.EventHandler(this.Predchadzajuca_btnClick);
			// 
			// znova_btn
			// 
			this.znova_btn.Enabled = false;
			this.znova_btn.Location = new System.Drawing.Point(1280, 1056);
			this.znova_btn.Name = "znova_btn";
			this.znova_btn.Size = new System.Drawing.Size(112, 72);
			this.znova_btn.TabIndex = 13;
			this.znova_btn.Text = "Znova";
			this.znova_btn.UseVisualStyleBackColor = true;
			this.znova_btn.Click += new System.EventHandler(this.Znova_btnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1526, 1209);
			this.Controls.Add(this.znova_btn);
			this.Controls.Add(this.predchadzajuca_btn);
			this.Controls.Add(this.nasledujuca_btn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.vykonaj_btn);
			this.Controls.Add(this.cmd);
			this.Controls.Add(this.koniecOpak_btn);
			this.Controls.Add(this.opakuj_btn);
			this.Controls.Add(this.vpred_btn);
			this.Controls.Add(this.vpravo_btn);
			this.Controls.Add(this.vlavo_btn);
			this.Name = "MainForm";
			this.Text = "EduSoft2 - zbieranie mincí";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
