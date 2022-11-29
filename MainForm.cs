using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Edusoft2
{	
	public partial class MainForm : Form	
	{		
		int playground_size = 550;		
		static int[,] playground;
		Player player;		
		int aktual_uloha =1; 
		int pocet_uloh = 1;		
		string sada_uloh = "sada1"; 
		HashSet<int> completedLevels = new HashSet<int>();
		Boolean hraci = true;
		public MainForm()
		{			
			
			InitializeComponent();	
			KeyPreview = true;
			this.FormBorderStyle = FormBorderStyle.None;
    			this.WindowState = FormWindowState.Maximized;      		
			loadPlayground(); 
		}
		
		void Button1Click(object sender, EventArgs e)//hraci rezim
		{
			if(hraci) return;
			Reverse();
		}
		void Button2Click(object sender, EventArgs e)//testovaci rezim
		{
			if(!hraci) return;
			Reverse();
		}		
		
		void Button3Click(object sender, EventArgs e) {
			
		}
		
		void Button4Click(object sender, EventArgs e) {			
					
		}
		
		void Button5Click(object sender, EventArgs e) {
			var fileContent = string.Empty;
			var filePath = string.Empty;
			
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
			    openFileDialog.InitialDirectory = "c:\\";
			    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			    openFileDialog.FilterIndex = 2;
			    openFileDialog.RestoreDirectory = true;
			
			    if (openFileDialog.ShowDialog() == DialogResult.OK)
			    {
			        //Get the path of specified file
			        filePath = openFileDialog.FileName;
			        loadPlayground(filePath); 
			    }
			}
		}
		
		void Reverse(){
			hraci = !hraci;
			if (hraci) {
				loadPlayground(); 
			}
			else {
				playground = new int[8, 8];
				panel1.Invalidate(); 
			}
			
			button2.Enabled = !button2.Enabled;
			button1.Enabled = !button1.Enabled;
			
			button3.Visible = !button3.Visible;
			button4.Visible = !button4.Visible;
			button5.Visible = !button5.Visible;
			
			panel3.Visible = !panel3.Visible;
			panel5.Visible = !panel5.Visible;
			panel6.Visible = !panel6.Visible;
			cmd.Visible = !cmd.Visible;
			predchadzajuca_btn.Visible = !predchadzajuca_btn.Visible;
			nasledujuca_btn.Visible = !nasledujuca_btn.Visible; 
			label1.Visible = !label1.Visible;
			label2.Visible = !label2.Visible;
			label3.Visible = !label3.Visible;
		}
		
		void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			int value = trackBar1.Value;
			label4.Text = "Veľkosť poľa:\n" + value + "X" + value;
		}
		
		protected override void OnPaint(PaintEventArgs e) {
			panel1.Invalidate();
		}
		
		
		void loadPlayground(string file_path = "") {
			string path; 
			if (file_path == "") 
				path = "mapy/" + sada_uloh + "/" + aktual_uloha.ToString() + ".txt";
			else {
				path = file_path;
				completedLevels = new HashSet<int>();								
			}				
			StreamReader r = new StreamReader(path);			
			sada_uloh = r.ReadLine().Trim();
			label1.Text = sada_uloh;
			aktual_uloha = Int32.Parse(Path.GetFileNameWithoutExtension(path));
			pocet_uloh = Directory.GetFiles(System.Environment.CurrentDirectory + "\\mapy\\" + sada_uloh, "*", SearchOption.AllDirectories).Length;
			label2.Text = "úloha " + aktual_uloha.ToString() + " z " + pocet_uloh.ToString();
			label3.Text = "vyriešené úlohy: " + completedLevels.Count;
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
			panel1.Invalidate(); 
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
			cmd.AppendText("Opakuj 2 krat");
			cmd.AppendText(Environment.NewLine);				 
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
				String command = commandList[i].Trim().ToLower();
				if (command.Equals("vpred")) {								
					if (repeat_num == 1)
						commands.Add(command);
					else 
						repeat_commands.Add(command);
				}
				if (command.Equals("vlavo")) {								
					if (repeat_num == 1)				
						commands.Add(command);
					else 
						repeat_commands.Add(command);
				}
				if (command.Equals("vpravo")) {
					if (repeat_num == 1)				
						commands.Add(command);
					else 
						repeat_commands.Add(command);
				}
				if (command.Equals("koniec opakovania")) {
					for (int x = 0; x<repeat_num; x++) {
						foreach (string comm in repeat_commands)
							commands.Add(comm); 
					}
					repeat_num = 1; 
					repeat_commands = new List<String>(); 
				}
				if (command.Length > 8 && command.Substring(0, 6).Equals("opakuj") && command.IndexOf("krat") > 0) {
					string number_string = command.Substring(command.IndexOf(' ')).Trim();
					repeat_num = Int32.Parse(number_string = number_string.Substring(0, number_string.IndexOf(' ')));					
				}					
					
			}
			foreach (string command in commands) {				 
				if (command.Equals("vpred")) {
					try
					{
						player.move();
					}
					catch
					{
						break;
						MessageBox.Show("Počas vykonávania príkazov hráč vyšiel z hracej plochy!");
					}
				}					
				if (command.Equals("vlavo")) 
					player.turn_left(); 
				if (command.Equals("vpravo")) 
					player.turn_right();
			}
					
			panel1.Invalidate();
			if (isLevelCompleted()) {
				completedLevels.Add(aktual_uloha); 
				MessageBox.Show("Správne riešenie!");
				if (aktual_uloha < pocet_uloh) 
					aktual_uloha++; 
				loadPlayground();
				cmd.Text = ""; 
			}
			else {
				vykonaj_btn.Enabled = false;
				znova_btn.Enabled = true; 
			}
		}
		
		void Znova_btnClick(object sender, EventArgs e)
		{
			vykonaj_btn.Enabled = true;
			znova_btn.Enabled = false; 
			loadPlayground(); 
		}
		
		void Predchadzajuca_btnClick(object sender, EventArgs e)
		{
			if (aktual_uloha > 1) {
				aktual_uloha--;
				loadPlayground();
			}			 			
		}
		void Nasledujuca_btnClick(object sender, EventArgs e)
		{	
			if (aktual_uloha < pocet_uloh) {
				aktual_uloha++; 
				loadPlayground();
			}			 
		}
		
		public bool isLevelCompleted() {
			for (int i = 0; i<Math.Sqrt(playground.Length); i++) {
				for (int j = 0; j<Math.Sqrt(playground.Length); j++) {
				    	if (playground[i, j] == 1)
						return false; 					
				}
			}
			return true; 
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape){
				//MessageBox.Show("Enter Key Pressed ");
				Application.Exit( );
			}
		}		
		
		void Panel1MouseClick(Object sender, MouseEventArgs e) {
			//label1.Text = e.X + " " + e.Y; 
		}

		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			playground_size = Math.Min(panel1.Width, panel1.Height);
			int cell_size = playground_size / Convert.ToInt32(Math.Sqrt(playground.Length));
			
			for (int i = 0; i<Math.Sqrt(playground.Length); i++) {
				for (int j = 0; j<Math.Sqrt(playground.Length); j++) {
						g.FillRectangle(Brushes.White, j*cell_size, i*cell_size, cell_size, cell_size); 			    		
				    	g.DrawRectangle(Pens.Black, j*cell_size, i*cell_size, cell_size, cell_size);
			    	if (playground[i, j] == 0) {
			    		//pass		    		
			    	}
			    	else if (playground[i, j] == 1) {		    		
			    		g.FillEllipse(Brushes.Yellow, j*cell_size+cell_size/4, i*cell_size+cell_size/4, cell_size/2, cell_size/2); 	    						    				
			    	}
			    	else if (playground[i, j] == 2) {
			    		g.FillRectangle(Brushes.Blue, j*cell_size, i*cell_size, cell_size, cell_size); 			    		
				    	g.DrawRectangle(Pens.Black, j*cell_size, i*cell_size, cell_size, cell_size);			    					    			
			    	}
			    }	    				
			}
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
	    			
