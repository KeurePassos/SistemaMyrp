namespace SistemaMyrp
{
	partial class Menu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button3 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.btn_cad_prod = new System.Windows.Forms.Button();
			this.btn_cad_clientes = new System.Windows.Forms.Button();
			this.btn_sair_menu = new System.Windows.Forms.Button();
			this.btn_vendas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Rockwell", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = global::SistemaMyrp.Properties.Resources.CadastroDeProduto_1_;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.Location = new System.Drawing.Point(31, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(481, 362);
			this.button3.TabIndex = 0;
			this.button3.Text = "Myrp";
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// btn_cad_prod
			// 
			this.btn_cad_prod.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_cad_prod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_cad_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_cad_prod.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_cad_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cad_prod.Location = new System.Drawing.Point(580, 40);
			this.btn_cad_prod.Name = "btn_cad_prod";
			this.btn_cad_prod.Size = new System.Drawing.Size(189, 72);
			this.btn_cad_prod.TabIndex = 1;
			this.btn_cad_prod.Text = "Cadastro de Produtos";
			this.btn_cad_prod.UseVisualStyleBackColor = true;
			this.btn_cad_prod.Click += new System.EventHandler(this.btn_cad_prod_Click);
			// 
			// btn_cad_clientes
			// 
			this.btn_cad_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cad_clientes.Location = new System.Drawing.Point(580, 133);
			this.btn_cad_clientes.Name = "btn_cad_clientes";
			this.btn_cad_clientes.Size = new System.Drawing.Size(189, 72);
			this.btn_cad_clientes.TabIndex = 2;
			this.btn_cad_clientes.Text = "Cadastros de Clientes";
			this.btn_cad_clientes.UseVisualStyleBackColor = true;
			// 
			// btn_sair_menu
			// 
			this.btn_sair_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sair_menu.Location = new System.Drawing.Point(580, 313);
			this.btn_sair_menu.Name = "btn_sair_menu";
			this.btn_sair_menu.Size = new System.Drawing.Size(189, 72);
			this.btn_sair_menu.TabIndex = 5;
			this.btn_sair_menu.Text = "Sair";
			this.btn_sair_menu.UseVisualStyleBackColor = true;
			// 
			// btn_vendas
			// 
			this.btn_vendas.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_vendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_vendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_vendas.Location = new System.Drawing.Point(580, 223);
			this.btn_vendas.Name = "btn_vendas";
			this.btn_vendas.Size = new System.Drawing.Size(189, 72);
			this.btn_vendas.TabIndex = 6;
			this.btn_vendas.Text = "Vendas";
			this.btn_vendas.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(833, 415);
			this.Controls.Add(this.btn_vendas);
			this.Controls.Add(this.btn_sair_menu);
			this.Controls.Add(this.btn_cad_clientes);
			this.Controls.Add(this.btn_cad_prod);
			this.Controls.Add(this.button3);
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.btn_cad_prod_Click);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_cad_cliente;
		private System.Windows.Forms.Button btn_relatorio;
		private System.Windows.Forms.Button btn_venda;
		private System.Windows.Forms.Button btn_cad_produto;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button btn_cad_prod;
		private System.Windows.Forms.Button btn_cad_clientes;
		private System.Windows.Forms.Button btn_sair_menu;
		private System.Windows.Forms.Button btn_vendas;
	}
}

