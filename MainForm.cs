﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Edusoft2
{	
	public partial class MainForm : Form	
	{		
		int playground_size = 240;		
		static int[,] playground;
		Player player; 
		public MainForm()
		{			
			InitializeComponent();												
			loadPlayground(); 
		}
		
		protected override void OnPaint(PaintEventArgs e) {
			int cell_size = playground_size / Convert.ToInt32(Math.Sqrt(playground.Length));
			Graphics g = CreateGraphics();
			for (int i = 0; i<Math.Sqrt(playground.Length); i++) {
				for (int j = 0; j<Math.Sqrt(playground.Length); j++) {
			    		if (playground[i, j] == 0) {
			    			g.FillRectangle(Brushes.White, j*cell_size, i*cell_size, cell_size, cell_size); 			    		
					    	g.DrawRectangle(Pens.Black, j*cell_size, i*cell_size, cell_size, cell_size);			    		
			    		}
			    		else if (playground[i, j] == 1) {
			    			g.FillRectangle(Brushes.White, j*cell_size, i*cell_size, cell_size, cell_size); 			    		
					    	g.DrawRectangle(Pens.Black, j*cell_size, i*cell_size, cell_size, cell_size);			    		
			    			g.FillEllipse(Brushes.Yellow, j*cell_size+cell_size/4, i*cell_size+cell_size/4, cell_size/2, cell_size/2); 	    						    				
			    		}
			    		else if (playground[i, j] == 2) {
			    			g.FillRectangle(Brushes.Blue, j*cell_size, i*cell_size, cell_size, cell_size); 			    		
					    	g.DrawRectangle(Pens.Black, j*cell_size, i*cell_size, cell_size, cell_size);			    					    			
			    		}
			    	}	    				
			}
		}
		
		void loadPlayground() {
			StreamReader r = new StreamReader("mapy/sada1/1.txt");			
			string name = r.ReadLine();
			int size = Int32.Parse(r.ReadLine().Trim().Split(' ')[0]);
			playground = new int[size, size];
			string[] player_pos = r.ReadLine().Trim().Split(' ');
			int player_x = Int32.Parse(player_pos[0]);
			int player_y = Int32.Parse(player_pos[1]);				
			playground[player_x, player_y] = 2;			
			while (!r.EndOfStream) 
			{
				string[] coin_pos = r.ReadLine().Trim().Split(' ');
				int pos_x = Int32.Parse(coin_pos[0]);
				int pos_y = Int32.Parse(coin_pos[1]);				
				playground[pos_x, pos_y] = 1; 
			}
			r.Close();
			player = new Player();			
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
			cmd.AppendText("Opakuj 1 krat");
			cmd.AppendText(Environment.NewLine);	
			label1.Text = playground.Length.ToString(); 
		}
		void KoniecOpak_btnClick(object sender, EventArgs e)
		{
			cmd.AppendText("Koniec opakovania");
			cmd.AppendText(Environment.NewLine);
			
		}
		void Vykonaj_btnClick(object sender, EventArgs e)
		{			
			string[] commandList = cmd.Text.Split('\n');
			List<string> commands = new List<string>();
			List<string> repeat_commands = new List<string>();			
			int repeat_num = 1; 
			for (int i = 0; i<commandList.Length; i++) {								
				String command = commandList[i].Trim();								
				if (command.Equals("Vpred")) {								
					if (repeat_num == 1)
						commands.Add(command);
					else 
						repeat_commands.Add(command);
				}
				if (command.Equals("Vlavo")) {								
					if (repeat_num == 1)				
						commands.Add(command);
					else 
						repeat_commands.Add(command);
				}
				if (command.Equals("Vpravo")) {
					if (repeat_num == 1)				
						commands.Add(command);
					else 
						repeat_commands.Add(command);
				}
				if (command.Equals("Koniec opakovania")) {
					for (int x = 0; x<repeat_num; x++) {
						foreach (string comm in repeat_commands)
							commands.Add(comm); 
					}
					repeat_num = 1; 
					repeat_commands = new List<String>(); 
				}
				if (command.Length > 8 && command.Substring(0, 6).Equals("Opakuj") && command.IndexOf("krat") > 0) {
					string number_string = command.Substring(command.IndexOf(' ')).Trim();
					repeat_num = Int32.Parse(number_string = number_string.Substring(0, number_string.IndexOf(' ')));					
				}					
					
			}
			foreach (string command in commands) {
				label1.Text += command; 
				if (command.Equals("Vpred")) 							
					player.move();
				if (command.Equals("Vlavo")) 
					player.turn_left(); 
				if (command.Equals("Vpravo")) 
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
				for (int i = 0; i<Math.Sqrt(playground.Length); i++) {
					for (int j = 0; j<Math.Sqrt(playground.Length); j++) {
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
	    			