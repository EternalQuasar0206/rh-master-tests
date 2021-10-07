/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 14/02/2021
 * Hora: 11:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace RA_MASTER
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button10 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button13 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(128, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "BANCO DE DADOS LOCAL";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(440, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(79, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "ATUALIZAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.DarkGreen;
			this.button3.Location = new System.Drawing.Point(0, 22);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(164, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "[+] INSERIR FUNCIONÁRIO";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(518, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(106, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "BACKUP LOCAL";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(623, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(153, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "ENVIAR PARA SERVIDOR";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Crimson;
			this.button7.Location = new System.Drawing.Point(163, 22);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(168, 23);
			this.button7.TabIndex = 7;
			this.button7.Text = "[-] REMOVER FUNCIONÁRIO";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 439);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(784, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
			this.toolStripStatusLabel1.Text = "a";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(776, 44);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nenhum banco de dados aberto";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(0, 86);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(772, 20);
			this.SearchBox.TabIndex = 14;
			this.SearchBox.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// listView1
			// 
			this.listView1.AutoArrange = false;
			this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
			this.listView1.Location = new System.Drawing.Point(0, 107);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(772, 299);
			this.listView1.TabIndex = 15;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(284, 0);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(157, 23);
			this.button10.TabIndex = 16;
			this.button10.Text = "BANCO DE DADOS ONLINE";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(784, 435);
			this.tabControl1.TabIndex = 17;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button13);
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Controls.Add(this.button10);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.SearchBox);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.button5);
			this.tabPage1.Controls.Add(this.button7);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(776, 409);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Lista de Funcionários";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.Location = new System.Drawing.Point(0, 0);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(129, 23);
			this.button13.TabIndex = 18;
			this.button13.Text = "NOVO BANCO ";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(786, 131);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 50);
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.webBrowser1);
			this.tabPage2.Controls.Add(this.button12);
			this.tabPage2.Controls.Add(this.button11);
			this.tabPage2.Controls.Add(this.button9);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(776, 409);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Perfil do Funcionário";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(115, 41);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(653, 362);
			this.webBrowser1.TabIndex = 7;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(8, 70);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(100, 23);
			this.button12.TabIndex = 6;
			this.button12.Text = "Editar Histórico";
			this.button12.UseVisualStyleBackColor = true;
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(8, 41);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(100, 23);
			this.button11.TabIndex = 5;
			this.button11.Text = "Alterar Imagem";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(582, 6);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(186, 20);
			this.button9.TabIndex = 2;
			this.button9.Text = "ACESSAR";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID DO FUNCIONÁRIO:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(154, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(422, 20);
			this.textBox1.TabIndex = 0;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1FileOk);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RH-MASTER";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
