namespace SistemaMyrp
{
	partial class frm_vendas
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_venda_cancelar = new System.Windows.Forms.Button();
			this.btn_venda_excluir = new System.Windows.Forms.Button();
			this.btn_venda_emitir = new System.Windows.Forms.Button();
			this.btn_venda_novo = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.text_quantidade = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_prod = new System.Windows.Forms.ComboBox();
			this.btn_venda_mais = new System.Windows.Forms.Button();
			this.comboBox_destinatario = new System.Windows.Forms.ComboBox();
			this.btn_rem_prod = new System.Windows.Forms.Button();
			this.text_valor_unitario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.text_valor_total = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.venda_pagamento = new System.Windows.Forms.CheckedListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.text_desconto = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.text_acrescimo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.text_valor_total_venda = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 326);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(845, 149);
			this.dataGridView1.TabIndex = 42;
			// 
			// btn_venda_cancelar
			// 
			this.btn_venda_cancelar.Location = new System.Drawing.Point(779, 297);
			this.btn_venda_cancelar.Name = "btn_venda_cancelar";
			this.btn_venda_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btn_venda_cancelar.TabIndex = 41;
			this.btn_venda_cancelar.Text = "Cancelar";
			this.btn_venda_cancelar.UseVisualStyleBackColor = true;
			// 
			// btn_venda_excluir
			// 
			this.btn_venda_excluir.Location = new System.Drawing.Point(698, 297);
			this.btn_venda_excluir.Name = "btn_venda_excluir";
			this.btn_venda_excluir.Size = new System.Drawing.Size(75, 23);
			this.btn_venda_excluir.TabIndex = 40;
			this.btn_venda_excluir.Text = "Excluir";
			this.btn_venda_excluir.UseVisualStyleBackColor = true;
			// 
			// btn_venda_emitir
			// 
			this.btn_venda_emitir.Location = new System.Drawing.Point(617, 297);
			this.btn_venda_emitir.Name = "btn_venda_emitir";
			this.btn_venda_emitir.Size = new System.Drawing.Size(75, 23);
			this.btn_venda_emitir.TabIndex = 39;
			this.btn_venda_emitir.Text = "Emitir";
			this.btn_venda_emitir.UseVisualStyleBackColor = true;
			// 
			// btn_venda_novo
			// 
			this.btn_venda_novo.Location = new System.Drawing.Point(536, 297);
			this.btn_venda_novo.Name = "btn_venda_novo";
			this.btn_venda_novo.Size = new System.Drawing.Size(75, 23);
			this.btn_venda_novo.TabIndex = 38;
			this.btn_venda_novo.Text = "Novo";
			this.btn_venda_novo.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(74, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 16);
			this.label3.TabIndex = 32;
			this.label3.Text = "Destinatário";
			// 
			// text_quantidade
			// 
			this.text_quantidade.Location = new System.Drawing.Point(350, 179);
			this.text_quantidade.Name = "text_quantidade";
			this.text_quantidade.Size = new System.Drawing.Size(89, 20);
			this.text_quantidade.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 16);
			this.label1.TabIndex = 30;
			this.label1.Text = "Produto";
			// 
			// comboBox_prod
			// 
			this.comboBox_prod.FormattingEnabled = true;
			this.comboBox_prod.Location = new System.Drawing.Point(71, 178);
			this.comboBox_prod.Name = "comboBox_prod";
			this.comboBox_prod.Size = new System.Drawing.Size(263, 21);
			this.comboBox_prod.TabIndex = 48;
			// 
			// btn_venda_mais
			// 
			this.btn_venda_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_venda_mais.Location = new System.Drawing.Point(673, 179);
			this.btn_venda_mais.Name = "btn_venda_mais";
			this.btn_venda_mais.Size = new System.Drawing.Size(25, 21);
			this.btn_venda_mais.TabIndex = 49;
			this.btn_venda_mais.Text = "+";
			this.btn_venda_mais.UseVisualStyleBackColor = true;
			// 
			// comboBox_destinatario
			// 
			this.comboBox_destinatario.FormattingEnabled = true;
			this.comboBox_destinatario.Location = new System.Drawing.Point(74, 71);
			this.comboBox_destinatario.Name = "comboBox_destinatario";
			this.comboBox_destinatario.Size = new System.Drawing.Size(300, 21);
			this.comboBox_destinatario.TabIndex = 50;
			// 
			// btn_rem_prod
			// 
			this.btn_rem_prod.Image = global::SistemaMyrp.Properties.Resources.lixo;
			this.btn_rem_prod.Location = new System.Drawing.Point(704, 179);
			this.btn_rem_prod.Name = "btn_rem_prod";
			this.btn_rem_prod.Size = new System.Drawing.Size(25, 21);
			this.btn_rem_prod.TabIndex = 51;
			this.btn_rem_prod.UseVisualStyleBackColor = true;
			// 
			// text_valor_unitario
			// 
			this.text_valor_unitario.Location = new System.Drawing.Point(461, 179);
			this.text_valor_unitario.Name = "text_valor_unitario";
			this.text_valor_unitario.Size = new System.Drawing.Size(96, 20);
			this.text_valor_unitario.TabIndex = 52;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(347, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 15);
			this.label2.TabIndex = 53;
			this.label2.Text = "Quantidade";
			this.label2.UseMnemonic = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(458, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 54;
			this.label4.Text = "Valor unitário";
			// 
			// text_valor_total
			// 
			this.text_valor_total.Location = new System.Drawing.Point(578, 178);
			this.text_valor_total.Name = "text_valor_total";
			this.text_valor_total.Size = new System.Drawing.Size(89, 20);
			this.text_valor_total.TabIndex = 55;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(575, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 15);
			this.label5.TabIndex = 56;
			this.label5.Text = "Valor Total";
			this.label5.UseMnemonic = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(437, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 16);
			this.label6.TabIndex = 58;
			this.label6.Text = "Pagamento";
			this.label6.UseMnemonic = false;
			// 
			// venda_pagamento
			// 
			this.venda_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.venda_pagamento.FormattingEnabled = true;
			this.venda_pagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.venda_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Pix"});
			this.venda_pagamento.Location = new System.Drawing.Point(437, 52);
			this.venda_pagamento.Name = "venda_pagamento";
			this.venda_pagamento.Size = new System.Drawing.Size(106, 72);
			this.venda_pagamento.TabIndex = 59;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(711, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 15);
			this.label7.TabIndex = 63;
			this.label7.Text = "Desconto";
			this.label7.UseMnemonic = false;
			// 
			// text_desconto
			// 
			this.text_desconto.Location = new System.Drawing.Point(714, 69);
			this.text_desconto.Name = "text_desconto";
			this.text_desconto.Size = new System.Drawing.Size(89, 20);
			this.text_desconto.TabIndex = 62;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(574, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 61;
			this.label8.Text = "Acréscimo";
			// 
			// text_acrescimo
			// 
			this.text_acrescimo.Location = new System.Drawing.Point(577, 69);
			this.text_acrescimo.Name = "text_acrescimo";
			this.text_acrescimo.Size = new System.Drawing.Size(96, 20);
			this.text_acrescimo.TabIndex = 60;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(19, 288);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 15);
			this.label9.TabIndex = 65;
			this.label9.Text = "Valor Total:";
			this.label9.UseMnemonic = false;
			// 
			// text_valor_total_venda
			// 
			this.text_valor_total_venda.Location = new System.Drawing.Point(105, 288);
			this.text_valor_total_venda.Name = "text_valor_total_venda";
			this.text_valor_total_venda.Size = new System.Drawing.Size(89, 20);
			this.text_valor_total_venda.TabIndex = 64;
			// 
			// frm_vendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(891, 481);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.text_valor_total_venda);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.text_desconto);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.text_acrescimo);
			this.Controls.Add(this.venda_pagamento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.text_valor_total);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.text_valor_unitario);
			this.Controls.Add(this.btn_rem_prod);
			this.Controls.Add(this.comboBox_destinatario);
			this.Controls.Add(this.btn_venda_mais);
			this.Controls.Add(this.comboBox_prod);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_venda_cancelar);
			this.Controls.Add(this.btn_venda_excluir);
			this.Controls.Add(this.btn_venda_emitir);
			this.Controls.Add(this.btn_venda_novo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.text_quantidade);
			this.Controls.Add(this.label1);
			this.Name = "frm_vendas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Emissão de Vendas";
			this.Load += new System.EventHandler(this.frm_vendas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_venda_cancelar;
		private System.Windows.Forms.Button btn_venda_excluir;
		private System.Windows.Forms.Button btn_venda_emitir;
		private System.Windows.Forms.Button btn_venda_novo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox text_quantidade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox_prod;
		private System.Windows.Forms.Button btn_venda_mais;
		private System.Windows.Forms.ComboBox comboBox_destinatario;
		private System.Windows.Forms.Button btn_rem_prod;
		private System.Windows.Forms.TextBox text_valor_unitario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox text_valor_total;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckedListBox venda_pagamento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox text_desconto;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox text_acrescimo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox text_valor_total_venda;
	}
}