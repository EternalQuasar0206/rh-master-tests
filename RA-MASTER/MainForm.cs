using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Security;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace RA_MASTER {
	

	public partial class MainForm: Form {
		List <string> FuncList = new List <string> ();
		List <string> SearchList = new List <string> ();
		public string SelectedID;
		public int TriggerDataBaseAberto = 0;
		public string Database_File = "";
		public string Database_Dir = "";
		public MainForm() {

			InitializeComponent();
			if (TriggerDataBaseAberto == 0) {
				button3.Enabled = false;
				button7.Enabled = false;
                tabPage2.Enabled = false;

			} else {
				button3.Enabled = true;
				button7.Enabled = true;
                tabPage2.Enabled = true;

			}
		}
		//webBrowser1.Navigate("about:blank");
		//webBrowser1.Document.Write("<body onselectstart='return false' oncontextmenu='return false' bgcolor='#101010'>");

		void Button1Click(object sender, EventArgs e) {
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog1.FileName = "openFileDialog1";
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			 openFileDialog1.InitialDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\databases\");
		     openFileDialog1.RestoreDirectory = true;
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName != "" && openFileDialog1.FileName.Contains("rhdb")) {
				TriggerDataBaseAberto = 1;
				Database_File = openFileDialog1.FileName;
				FuncList = File.ReadLines(Database_File).ToList();
				Atualizar();
			}
			//var sr = new StreamReader(openFileDialog1.FileName);
		}

		void Button3Click(object sender, EventArgs e) {
			try {
			string FuncNome = Microsoft.VisualBasic.Interaction.InputBox("Insira o nome do funcionário", "Nome do funcionário", "", 150, 150);
			string FuncCargo = Microsoft.VisualBasic.Interaction.InputBox("Insira o cargo do funcionário", "Cargo do funcionário", "", 150, 150);
			string FuncID = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do funcionário (Deixe em branco para um ID aleatório)", "ID do funcionário", "", 150, 150);

			if (FuncID == "") {
				FuncID = "RHID" + new Random().Next(0, 9999999).ToString();
			} else {
				FuncID = "RHID" + FuncID;
			}
			FuncList.Add(FuncNome + " | " + FuncCargo + " | " + FuncID);
			if (FuncCargo != "" && FuncNome != "" && FuncID != "") {
				if (!Directory.Exists(Path.GetDirectoryName(Database_File) + "/" + FuncID)) {
					            int index = FuncList.FindIndex(c => c.Contains(FuncID));
					            string TextToList = FuncList[index].ToString();
			                    //TextToList = TextToList.Replace("|", "|");
					Directory.CreateDirectory(Path.GetDirectoryName(Database_File) + "/" + FuncID);
					File.WriteAllText(Path.GetDirectoryName(Database_File) + "/" + FuncID + "/pfinfo.html", "<meta charset='UTF-8'><font face = 'Verdana'><img src='profilepic.png' width='75' height='75' align='left'>" + TextToList + "</font>");

					
				}
				
				// webBrowser1.DocumentText = "<body onselectstart='return false' oncontextmenu='return false' bgcolor='#101010'><p style='border:3px; border-style:solid; border-color:white; padding: 1em;'><font color='white' face='Verdana, Geneva, sans-serif'>" + string.Join("", FuncList) + "</font></p>";
				Atualizar();

			}
			} catch {
				
			}
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e) {

}

		void Label1Click(object sender, EventArgs e) {

}

		void Timer1Tick(object sender, EventArgs e) {
			try {
			if (Database_File != "") {
				label1.Text = Database_File;

				System.IO.File.WriteAllLines(Database_File, FuncList);

			}
			if (TriggerDataBaseAberto == 0) {
				button13.Text = "NOVO BANCO";	
				SearchBox.Enabled = false;
				button3.Enabled = false;
				button7.Enabled = false;
                tabPage2.Enabled = false;
 
			} else {
				button13.Text = "FECHAR BANCO";	
				SearchBox.Enabled = true;
				button3.Enabled = true;
				button7.Enabled = true;
				tabPage2.Enabled = true;
				//button8.Enabled = true;
				//button6.Enabled = true;

			}
			} catch {
				
			}

		}

		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

}

		void TextBox1TextChanged(object sender, EventArgs e) {
			
			Atualizar();
			
}

		void ListView1SelectedIndexChanged(object sender, EventArgs e) {}

		void Button7Click(object sender, EventArgs e) {
			try {
			string ID_TO_REMOVE = "RHID" + Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do funcionário a ser removido", "ID do funcionário", "", 150, 150);
			if (ID_TO_REMOVE != "") {
				Directory.Delete(Path.GetDirectoryName(Database_File) + "/" + ID_TO_REMOVE, true);
				FuncList.RemoveAll(item => item.Contains(ID_TO_REMOVE));
				Atualizar();

			}
			} catch {
				
			}
		}

		void Button6Click(object sender, EventArgs e) {
			try {
			string ID_TO_REMOVE = Microsoft.VisualBasic.Interaction.InputBox("Insira o ID do funcionário a ser comentado", "ID do funcionário", "", 150, 150);
			string COMMENT = Microsoft.VisualBasic.Interaction.InputBox("Insira o comentário", "Comentário", "", 150, 150);

			if (ID_TO_REMOVE != "" && COMMENT != "") {
				int index = FuncList.FindIndex(c => c.Contains(ID_TO_REMOVE));
				if (index != -1) {
					FuncList[index] += " | " + COMMENT;
				}
			}
			} catch {
				
			}
		}

		void Button2Click(object sender, EventArgs e) {
			Atualizar();
		}

		void Atualizar() {
			listView1.Items.Clear();
            label1.Text = Database_File;
			try {
				
			foreach(var item in FuncList) {
     if (item.Contains(SearchBox.Text)) {
				listView1.Items.Add(item);
            		}
            		
			}
			} catch {
				
			}

		}
bool IsDigitsOnly(string str)
               {
    foreach (char c in str)
    {
    	if (c < '0' || c > '9') {
            return false;
    	}
    }

    return true;
               }
		void Button9Click(object sender, EventArgs e) {
			
	if (textBox1.Text != "" && IsDigitsOnly(textBox1.Text)) {
				try {
			SelectedID = textBox1.Text;
			webBrowser1.Url = new System.Uri(Path.GetDirectoryName( Database_File ) + "/RHID" + SelectedID + "/pfinfo.html");
				} catch {
					
				}
			}
		}

		void Panel1Paint(object sender, PaintEventArgs e) {

}

		void PictureBox1Click(object sender, EventArgs e) {

}
		
		void Button13Click(object sender, EventArgs e)
		{
			if (TriggerDataBaseAberto == 1) {
			TriggerDataBaseAberto = 0;
			Database_File = "";
			FuncList = null;
			Atualizar();
			} else {

		  saveFileDialog1.InitialDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\databases\");
		  saveFileDialog1.RestoreDirectory = true;
		  saveFileDialog1.Filter = "Banco de dados de gestão de RH|.rhdb";
          saveFileDialog1.ShowDialog();	   
          
	}
		}
		
		
		
		void SaveFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Database_File = "";
			try {
				
				
				if (saveFileDialog1.FileName != "") {
					TriggerDataBaseAberto = 1;
		Database_File = saveFileDialog1.FileName;	
FuncList = File.ReadLines(Database_File).ToList();		
        string name = saveFileDialog1.FileName;
        File.WriteAllText(name, "");
        Atualizar();
				}
			} catch {
				
			}
		}
		
		void Button11Click(object sender, EventArgs e)
		{
	        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog1.FileName = "openFileDialog1";
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName != "" && openFileDialog1.FileName.Contains("png") ) {
               
				
				File.Copy(openFileDialog1.FileName, Path.GetDirectoryName( Database_File ) + "/RHID" + SelectedID + "/profilepic.png", true);
				webBrowser1.Refresh();
			}
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			
			}
	}
}