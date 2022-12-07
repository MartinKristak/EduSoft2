using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Edusoft2
{	
	public partial class MainForm : Form	
	{		
		//int playground_size = 550;		
		int cell_size = 70; 
		static int[,] playground;
		Player player;		
		int aktual_uloha =1; 
		int pocet_uloh = 1;		
		string sada_uloh = "sada1"; 
		HashSet<int> completedLevels = new HashSet<int>();
		Boolean hraci = true;
		List<Bitmap> bmp = new List<Bitmap>();
		TextureBrush brush;
		int last = -1;
		public MainForm()
		{			
			
			InitializeComponent();
			this.bmp.Add(new Bitmap("spirites\\00.png"));
			this.bmp.Add(new Bitmap("spirites\\33.png"));
			this.bmp.Add(new Bitmap("spirites\\22.png"));
			this.bmp.Add(new Bitmap("spirites\\44.png"));
			
			brush = new TextureBrush(bmp[0], WrapMode.Tile);
			KeyPreview = true;
			this.FormBorderStyle = FormBorderStyle.None;
    		this.WindowState = FormWindowState.Maximized;      		
			loadPlayground(); 
		}
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams handleparam = base.CreateParams;
				handleparam.ExStyle |= 0x02000000;
				return base.CreateParams;
			}
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
			        loadPlayground(filePath, true); 
			    }
			}
		}
		
		void Button4Click(object sender, EventArgs e) {			
			saveMap(); 
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
				playground = new int[6, 6];
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
			if(value > 9){
				value = 9;
			}
			label4.Text = "Veľkosť poľa:\n" + value + "X" + value;
			playground = new int[value, value];
			panel1.Invalidate();
		}
		
		protected override void OnPaint(PaintEventArgs e) {
			panel1.Invalidate();
		}
		
		
		void loadPlayground(string file_path = "", bool loadMap=false) {
			string path; 
			if (file_path == "") 
				path = "mapy/" + sada_uloh + "/" + aktual_uloha.ToString() + ".txt";
			else {
				path = file_path;
				completedLevels = new HashSet<int>();								
			}				
			StreamReader r = new StreamReader(path);			
			sada_uloh = r.ReadLine().Trim();
			if (loadMap == false) {
				label1.Text = sada_uloh;
				aktual_uloha = Int32.Parse(Path.GetFileNameWithoutExtension(path));
				pocet_uloh = Directory.GetFiles(System.Environment.CurrentDirectory + "\\mapy\\" + sada_uloh, "*", SearchOption.AllDirectories).Length;
				label2.Text = "úloha " + aktual_uloha.ToString() + " z " + pocet_uloh.ToString();
				label3.Text = "vyriešené úlohy: " + completedLevels.Count;
			}			
			int size = Int32.Parse(r.ReadLine().Trim().Split(' ')[0]);
			playground = new int[size, size];						
			for (int i = 0; i<size; i++) {
				string[] line = r.ReadLine().Trim().Split(' ');
				for (int j = 0; j<line.Length; j++)
					playground[i, j] = Int32.Parse(line[j]);				
					
			}			
			r.Close();
			player = new Player();			
			panel1.Invalidate(); 
		}
		
		void saveMap() {
			if (numberPlayerOnPlayground() == 0) {
				MessageBox.Show("Na hracej ploche sa nenachádza postava hráča. Mapu nemá zmysel ukladať!");
				return; 
			}
			player = new Player(); 
			string filename = DateTime.Now.ToString("O");			
			filename = filename.Substring(0, filename.IndexOf("."));
			filename = "map_" + filename.Replace(":", "_");			
			StreamWriter w = new StreamWriter("saved_maps/" + filename + ".txt");     
			w.WriteLine("sada1");                          
			w.WriteLine(Math.Sqrt(playground.Length).ToString());			
			for (int i = 0; i<Math.Sqrt(playground.Length); i++) {
				for (int j = 0; j<Math.Sqrt(playground.Length); j++) {				    	 
					w.Write(playground[i, j].ToString() + " ");
				}
				w.WriteLine(); 
			}
			w.Close();
			MessageBox.Show("Uložená mapa: " + filename); 
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
					if (player.move() == false) {
						panel1.Invalidate();
						MessageBox.Show("Týmito príkazmi hráč vyšiel z hracej plochy alebo si narazil na prekážku! Skúste znova.");						 
						vykonaj_btn.Enabled = false;
						znova_btn.Enabled = true;
						return; 
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
		
		public int numberPlayerOnPlayground() {
			int pocet = 0; 
			for (int i = 0; i<Math.Sqrt(playground.Length); i++) {
				for (int j = 0; j<Math.Sqrt(playground.Length); j++) {
				    	if (playground[i, j] == 2) 
				    		pocet++; 
				}
			}							
			return pocet; 
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape){
				//MessageBox.Show("Enter Key Pressed ");
				Application.Exit( );
			}
		}		
		
		void Panel1MouseClick(Object sender, MouseEventArgs e) {
			if (!hraci) {				 
				int x = e.X / cell_size; 
				int y = e.Y / cell_size; 				
				if (x < Math.Sqrt(playground.Length) && y < Math.Sqrt(playground.Length)) {
					playground[y, x] += 1;
					if (playground[y, x] == 2 && numberPlayerOnPlayground() == 2) 
						playground[y, x] = 3; 
					if (playground[y, x] == 4) 
						playground[y, x] = 0;
					panel1.Invalidate(); 
				}
 			}
			 
		}

		void Panel1Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			int size = (int)Math.Sqrt(playground.Length);
			g.FillRectangle(brush, 0, 0, cell_size*size, cell_size*size);
			for (int i = 0; i<size; i++) {
				for (int j = 0; j<size; j++) {
					if (playground[i, j] == 1) {		    		
						g.DrawImage(bmp[1], j*cell_size, i*cell_size);			    		
			    		}
				    	else if (playground[i, j] == 2) {
					    	g.DrawImage(RotateImage(bmp[2], (player.get_turned_to()+2)*90), j*cell_size, i*cell_size);			    					    			
				    	}
				    	else if (playground[i, j] == 3) {
					    	g.DrawImage(bmp[3], j*cell_size, i*cell_size);			    					    			
				    	}					
				}	    				
			}
		}
		
		public static Bitmap RotateImage(Bitmap b, float angle)
		{
		  //create a new empty bitmap to hold rotated image
		  Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
		  //make a graphics object from the empty bitmap
		  using(Graphics g = Graphics.FromImage(returnBitmap)) 
		  {
		      //move rotation point to center of image
		      g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
		      //rotate
		      g.RotateTransform(angle);
		      //move image back
		      g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
		      //draw passed in image onto graphics object
		      g.DrawImage(b, new Point(0, 0)); 
		  }
		  return returnBitmap;
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
			
			public int get_turned_to() {
				return turned_to; 
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
			
			public bool move() {
				playground[pos_y, pos_x] = 0;
				if (turned_to == 0) 			
					pos_y--; 									
				if (turned_to == 1) 					
					pos_x++; 									
				if (turned_to == 2) 					
					pos_y++; 									
				if (turned_to == 3) 
					pos_x--; 				
				if (pos_x < 0 || pos_y < 0 || pos_x == Math.Sqrt(playground.Length) || pos_x == Math.Sqrt(playground.Length))
					return false;
				if (playground[pos_y, pos_x] == 3)
					return false; 
				playground[pos_y, pos_x] = 2;					
				return true; 
			}
		}
			
	}
}
	    			
