namespace SistemaMyrp
{
	partial class frm_produtos
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
			this.text_codigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.text_descricao = new System.Windows.Forms.TextBox();
			this.text_unidade_medida = new System.Windows.Forms.TextBox();
			this.text_codigo_gtin = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_cad_prod_novo = new System.Windows.Forms.Button();
			this.btn_cad_prod_salvar = new System.Windows.Forms.Button();
			this.btn_cad_prod_excluir = new System.Windows.Forms.Button();
			this.btn_cad_prod_cancelar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.text_valor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.text_quant_estoque = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// text_codigo
			// 
			this.text_codigo.Location = new System.Drawing.Point(17, 71);
			this.text_codigo.Name = "text_codigo";
			this.text_codigo.Size = new System.Drawing.Size(384, 20);
			this.text_codigo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Código";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(461, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Descrição";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(461, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(226, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Unidade de medida de estoque";
			// 
			// text_descricao
			// 
			this.text_descricao.Location = new System.Drawing.Point(464, 71);
			this.text_descricao.Name = "text_descricao";
			this.text_descricao.Size = new System.Drawing.Size(384, 20);
			this.text_descricao.TabIndex = 9;
			// 
			// text_unidade_medida
			// 
			this.text_unidade_medida.Location = new System.Drawing.Point(464, 151);
			this.text_unidade_medida.Name = "text_unidade_medida";
			this.text_unidade_medida.Size = new System.Drawing.Size(384, 20);
			this.text_unidade_medida.TabIndex = 11;
			// 
			// text_codigo_gtin
			// 
			this.text_codigo_gtin.Location = new System.Drawing.Point(17, 150);
			this.text_codigo_gtin.Name = "text_codigo_gtin";
			this.text_codigo_gtin.Size = new System.Drawing.Size(384, 20);
			this.text_codigo_gtin.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Código GTIN/EAN";
			// 
			// btn_cad_prod_novo
			// 
			this.btn_cad_prod_novo.Location = new System.Drawing.Point(539, 290);
			this.btn_cad_prod_novo.Name = "btn_cad_prod_novo";
			this.btn_cad_prod_novo.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_prod_novo.TabIndex = 21;
			this.btn_cad_prod_novo.Text = "Novo";
			this.btn_cad_prod_novo.UseVisualStyleBackColor = true;
			// 
			// btn_cad_prod_salvar
			// 
			this.btn_cad_prod_salvar.Location = new System.Drawing.Point(620, 290);
			this.btn_cad_prod_salvar.Name = "btn_cad_prod_salvar";
			this.btn_cad_prod_salvar.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_prod_salvar.TabIndex = 22;
			this.btn_cad_prod_salvar.Text = "Salvar";
			this.btn_cad_prod_salvar.UseVisualStyleBackColor = true;
			// 
			// btn_cad_prod_excluir
			// 
			this.btn_cad_prod_excluir.Location = new System.Drawing.Point(701, 290);
			this.btn_cad_prod_excluir.Name = "btn_cad_prod_excluir";
			this.btn_cad_prod_excluir.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_prod_excluir.TabIndex = 23;
			this.btn_cad_prod_excluir.Text = "Excluir";
			this.btn_cad_prod_excluir.UseVisualStyleBackColor = true;
			// 
			// btn_cad_prod_cancelar
			// 
			this.btn_cad_prod_cancelar.Location = new System.Drawing.Point(782, 290);
			this.btn_cad_prod_cancelar.Name = "btn_cad_prod_cancelar";
			this.btn_cad_prod_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_prod_cancelar.TabIndex = 24;
			this.btn_cad_prod_cancelar.Text = "Cancelar";
			this.btn_cad_prod_cancelar.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 336);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(845, 149);
			this.dataGridView1.TabIndex = 25;
			// 
			// text_valor
			// 
			this.text_valor.Location = new System.Drawing.Point(17, 231);
			this.text_valor.Name = "text_valor";
			this.text_valor.Size = new System.Drawing.Size(384, 20);
			this.text_valor.TabIndex = 29;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(14, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 16);
			this.label7.TabIndex = 28;
			this.label7.Text = "Valor de Venda";
			// 
			// text_quant_estoque
			// 
			this.text_quant_estoque.Location = new System.Drawing.Point(464, 231);
			this.text_quant_estoque.Name = "text_quant_estoque";
			this.text_quant_estoque.Size = new System.Drawing.Size(384, 20);
			this.text_quant_estoque.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(461, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(172, 16);
			this.label6.TabIndex = 26;
			this.label6.Text = "Quantidade em estoque";
			// 
			// frm_produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(869, 497);
			this.Controls.Add(this.text_valor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.text_quant_estoque);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_cad_prod_cancelar);
			this.Controls.Add(this.btn_cad_prod_excluir);
			this.Controls.Add(this.btn_cad_prod_salvar);
			this.Controls.Add(this.btn_cad_prod_novo);
			this.Controls.Add(this.text_codigo_gtin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.text_unidade_medida);
			this.Controls.Add(this.text_descricao);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.text_codigo);
			this.Controls.Add(this.label1);
			this.Name = "frm_produtos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Produtos";
			this.Load += new System.EventHandler(this.frm_produtos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox text_codigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox text_descricao;
		private System.Windows.Forms.TextBox text_unidade_medida;
		private System.Windows.Forms.TextBox text_codigo_gtin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_cad_prod_novo;
		private System.Windows.Forms.Button btn_cad_prod_salvar;
		private System.Windows.Forms.Button btn_cad_prod_excluir;
		private System.Windows.Forms.Button btn_cad_prod_cancelar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox text_valor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox text_quant_estoque;
		private System.Windows.Forms.Label label6;
	}
}