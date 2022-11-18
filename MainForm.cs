using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Edusoft2
{	
	public partial class MainForm : Form	
	{		
		static int[,] playground = {
			{1, 0, 0, 0, 0, 0, 0, 1},
			{0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 0, 1, 1, 0, 0, 0},
			{0, 0, 1, 1, 1, 1, 0, 0},
			{0, 0, 1, 1, 1, 1, 0, 0},
			{0, 0, 0, 1, 1, 0, 0, 0},
			{0, 0, 0, 0, 0, 0, 0, 0},
			{2, 0, 0, 0, 0, 0, 0, 1}};
		Player player; 
		public MainForm()
		{			
			InitializeComponent();									
			player = new Player();
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
			    		else if (playground[i, j] == 2) {
			    			g.FillRectangle(Brushes.Blue, j*40, i*40, 40, 40); 			    		
					    	g.DrawRectangle(Pens.Black, j*40, i*40, 40, 40);			    					    			
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
		void Opakuj_btnClick(object sender, EventArgs e)
		{
			cmd.AppendText("Opakuj 1  krát");
			cmd.AppendText(Environment.NewLine);	
		}
		void KoniecOpak_btnClick(object sender, EventArgs e)
		{
			cmd.AppendText("Koniec opakovania");
			cmd.AppendText(Environment.NewLine);
			
		}
		void Vykonaj_btnClick(object sender, EventArgs e)
		{
			string commands = cmd.Text; 
			string[] commandList = commands.Split('\n');
			for (int i = 0; i<commandList.Length; i++) {								
				if (commandList[i].Trim().Equals("Vpred")) 
					player.move();									
				if (commandList[i].Trim().Equals("Vlavo")) 
					player.turn_left();
				if (commandList[i].Trim().Equals("Vpravo")) 
					player.turn_right();														
			}
			Invalidate();			
		}
		
		
		
		
		class Player {
			int pos_x; 
			int pos_y;
			int turned_to;  //0 - sever, 1 - vychod. 2 - juh, 3 - západ
			public Player() {
				this.find_position();
				this.turned_to = 0; 
			}
			
			public int get_pos_x() {
				return pos_x; 
			}
	
			public int get_pos_y() {
				return pos_y; 
			}
	
			void find_position() {
				for (int i = 0; i<8; i++) {
					for (int j = 0; j<8; j++) {
				    		if (playground[i, j] == 2) {
							this.pos_x = j; 
							this.pos_y = i; 
						}
					}
				}				 
			}
			
			public void turn_left() {
				this.turned_to--; 
				if (this.turned_to < 0)
					this.turned_to = 3; 
			}
			
			public void turn_right() {
				this.turned_to++; 
				if (this.turned_to > 3)
					this.turned_to = 0; 
			}
			
			public void move() {
				if (turned_to == 0) {
					playground[pos_y, pos_x] = 0;
					pos_y--; 
					playground[pos_y, pos_x] = 2;					
				}
				if (turned_to == 1) {
					playground[pos_y, pos_x] = 0;
					pos_x++; 
					playground[pos_y, pos_x] = 2;					
				}
				if (turned_to == 2) {
					playground[pos_y, pos_x] = 0;
					pos_y++; 
					playground[pos_y, pos_x] = 2;					
				}
				if (turned_to == 3) {
					playground[pos_y, pos_x] = 0;
					pos_x--; 
					playground[pos_y, pos_x] = 2;					
				}
			}
		}
			
	}
}
	    			
