using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Edusoft2
{	
	public partial class MainForm : Form	
	{		
		int[,] playground = {
			{1, 0, 0, 0, 0, 0, 0, 1},
			{0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 1, 1, 0, 0, 0},
			{0, 0, 1, 1, 1, 1, 0, 0},
			{0, 0, 1, 1, 1, 1, 0, 0},
			{0, 0, 0, 1, 1, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0},
			{1, 0, 0, 0, 0, 0, 0, 1}};
		public MainForm()
		{			
			InitializeComponent();			
			 
		}
		
		protected override void OnPaint(PaintEventArgs e) {
			Graphics g = CreateGraphics();
			for (int i = 0; i<8; i++) {
				for (int j = 0; j<8; j++) {
			    		if (playground[i, j] == 0) {
			    			g.FillRectangle(Brushes.White, j*40, i*40, 40, 40); 			    		
					    	g.DrawRectangle(Pens.Black, j*40, i*40, 40, 40);			    		
			    		}
			    		else if (playground[i, j] == 1) {
			    			g.FillRectangle(Brushes.White, j*40, i*40, 40, 40); 			    		
					    	g.DrawRectangle(Pens.Black, j*40, i*40, 40, 40);			    		
			    			g.FillEllipse(Brushes.Yellow, j*40+10, i*40+10, 20, 20); 	    						    				
			    		}
			    	}	    				
			}
		}
		void Vlavo_btnClick(object sender, EventArgs e)
		{
			cmd.AppendText("Vlavo");
			cmd.AppendText(Environment.NewLine); 
		}
		void Vpravo_btnClick(object sender, EventArgs e)
		{
			cmd.AppendText("Vpravo");
			cmd.AppendText(Environment.NewLine);
		}
		void Vpred_btnClick(object sender, EventArgs e)
		{
			cmd.AppendText("Vpred");
			cmd.AppendText(Environment.NewLine);         
		}
		
		
		
		class Trieda {
			public Trieda() {
				return; 
			}
		}
			
	}
}
	    			
