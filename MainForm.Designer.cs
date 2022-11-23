﻿/*
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// vlavo_btn
			// 
			this.vlavo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vlavo_btn.Location = new System.Drawing.Point(104, 8);
			this.vlavo_btn.Margin = new System.Windows.Forms.Padding(2);
			this.vlavo_btn.Name = "vlavo_btn";
			this.vlavo_btn.Size = new System.Drawing.Size(104, 80);
			this.vlavo_btn.TabIndex = 0;
			this.vlavo_btn.Text = "Otoč vľavo";
			this.vlavo_btn.UseVisualStyleBackColor = true;
			this.vlavo_btn.Click += new System.EventHandler(this.Vlavo_btnClick);
			// 
			// vpravo_btn
			// 
			this.vpravo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vpravo_btn.Location = new System.Drawing.Point(312, 8);
			this.vpravo_btn.Margin = new System.Windows.Forms.Padding(2);
			this.vpravo_btn.Name = "vpravo_btn";
			this.vpravo_btn.Size = new System.Drawing.Size(104, 80);
			this.vpravo_btn.TabIndex = 1;
			this.vpravo_btn.Text = "Otoč vpravo";
			this.vpravo_btn.UseVisualStyleBackColor = true;
			this.vpravo_btn.Click += new System.EventHandler(this.Vpravo_btnClick);
			// 
			// vpred_btn
			// 
			this.vpred_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vpred_btn.Location = new System.Drawing.Point(208, 8);
			this.vpred_btn.Margin = new System.Windows.Forms.Padding(2);
			this.vpred_btn.Name = "vpred_btn";
			this.vpred_btn.Size = new System.Drawing.Size(104, 80);
			this.vpred_btn.TabIndex = 2;
			this.vpred_btn.Text = "Vpred";
			this.vpred_btn.UseVisualStyleBackColor = true;
			this.vpred_btn.Click += new System.EventHandler(this.Vpred_btnClick);
			// 
			// opakuj_btn
			// 
			this.opakuj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.opakuj_btn.Location = new System.Drawing.Point(312, 128);
			this.opakuj_btn.Margin = new System.Windows.Forms.Padding(2);
			this.opakuj_btn.Name = "opakuj_btn";
			this.opakuj_btn.Size = new System.Drawing.Size(104, 80);
			this.opakuj_btn.TabIndex = 3;
			this.opakuj_btn.Text = "Opakuj 2 krat";
			this.opakuj_btn.UseVisualStyleBackColor = true;
			this.opakuj_btn.Click += new System.EventHandler(this.Opakuj_btnClick);
			// 
			// koniecOpak_btn
			// 
			this.koniecOpak_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.koniecOpak_btn.Location = new System.Drawing.Point(208, 128);
			this.koniecOpak_btn.Margin = new System.Windows.Forms.Padding(2);
			this.koniecOpak_btn.Name = "koniecOpak_btn";
			this.koniecOpak_btn.Size = new System.Drawing.Size(104, 80);
			this.koniecOpak_btn.TabIndex = 4;
			this.koniecOpak_btn.Text = "Koniec opakovania";
			this.koniecOpak_btn.UseVisualStyleBackColor = true;
			this.koniecOpak_btn.Click += new System.EventHandler(this.KoniecOpak_btnClick);
			// 
			// cmd
			// 
			this.cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(205)))));
			this.cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cmd.Location = new System.Drawing.Point(0, 232);
			this.cmd.Margin = new System.Windows.Forms.Padding(2);
			this.cmd.Multiline = true;
			this.cmd.Name = "cmd";
			this.cmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.cmd.Size = new System.Drawing.Size(552, 504);
			this.cmd.TabIndex = 6;
			// 
			// vykonaj_btn
			// 
			this.vykonaj_btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.vykonaj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.vykonaj_btn.Location = new System.Drawing.Point(0, 0);
			this.vykonaj_btn.Margin = new System.Windows.Forms.Padding(2);
			this.vykonaj_btn.Name = "vykonaj_btn";
			this.vykonaj_btn.Size = new System.Drawing.Size(344, 100);
			this.vykonaj_btn.TabIndex = 7;
			this.vykonaj_btn.Text = "Vykonaj príkazy";
			this.vykonaj_btn.UseVisualStyleBackColor = true;
			this.vykonaj_btn.Click += new System.EventHandler(this.Vykonaj_btnClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(-44, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(824, 88);
			this.label1.TabIndex = 8;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(100, 88);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(536, 56);
			this.label2.TabIndex = 9;
			this.label2.Text = "label2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(100, 144);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(536, 59);
			this.label3.TabIndex = 10;
			this.label3.Text = "label3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// nasledujuca_btn
			// 
			this.nasledujuca_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nasledujuca_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.nasledujuca_btn.Location = new System.Drawing.Point(528, 80);
			this.nasledujuca_btn.Margin = new System.Windows.Forms.Padding(2);
			this.nasledujuca_btn.Name = "nasledujuca_btn";
			this.nasledujuca_btn.Size = new System.Drawing.Size(208, 128);
			this.nasledujuca_btn.TabIndex = 11;
			this.nasledujuca_btn.Text = "Nasledujúca úloha";
			this.nasledujuca_btn.UseVisualStyleBackColor = true;
			this.nasledujuca_btn.Click += new System.EventHandler(this.Nasledujuca_btnClick);
			// 
			// predchadzajuca_btn
			// 
			this.predchadzajuca_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.predchadzajuca_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.predchadzajuca_btn.Location = new System.Drawing.Point(0, 80);
			this.predchadzajuca_btn.Margin = new System.Windows.Forms.Padding(2);
			this.predchadzajuca_btn.Name = "predchadzajuca_btn";
			this.predchadzajuca_btn.Size = new System.Drawing.Size(208, 128);
			this.predchadzajuca_btn.TabIndex = 12;
			this.predchadzajuca_btn.Text = "Predchádzajúca úloha";
			this.predchadzajuca_btn.UseVisualStyleBackColor = true;
			this.predchadzajuca_btn.Click += new System.EventHandler(this.Predchadzajuca_btnClick);
			// 
			// znova_btn
			// 
			this.znova_btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.znova_btn.Enabled = false;
			this.znova_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.znova_btn.Location = new System.Drawing.Point(383, 0);
			this.znova_btn.Margin = new System.Windows.Forms.Padding(2);
			this.znova_btn.Name = "znova_btn";
			this.znova_btn.Size = new System.Drawing.Size(168, 100);
			this.znova_btn.TabIndex = 13;
			this.znova_btn.Text = "Znova";
			this.znova_btn.UseVisualStyleBackColor = true;
			this.znova_btn.Click += new System.EventHandler(this.Znova_btnClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.cmd);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(736, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(551, 853);
			this.panel2.TabIndex = 15;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.vlavo_btn);
			this.panel4.Controls.Add(this.vpravo_btn);
			this.panel4.Controls.Add(this.opakuj_btn);
			this.panel4.Controls.Add(this.koniecOpak_btn);
			this.panel4.Controls.Add(this.vpred_btn);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(551, 232);
			this.panel4.TabIndex = 16;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.vykonaj_btn);
			this.panel3.Controls.Add(this.znova_btn);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 753);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(551, 100);
			this.panel3.TabIndex = 16;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.nasledujuca_btn);
			this.splitContainer1.Panel2.Controls.Add(this.predchadzajuca_btn);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Size = new System.Drawing.Size(736, 856);
			this.splitContainer1.SplitterDistance = 648;
			this.splitContainer1.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(944, 816);
			this.panel1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
			this.ClientSize = new System.Drawing.Size(1287, 853);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainForm";
			this.Text = "EduSoft2 - zbieranie mincí";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
