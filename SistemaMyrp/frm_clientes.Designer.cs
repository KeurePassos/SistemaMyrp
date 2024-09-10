namespace SistemaMyrp
{
	partial class frm_clientes
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
			this.btn_cad_cl_cancelar = new System.Windows.Forms.Button();
			this.btn_cad_cl_excluir = new System.Windows.Forms.Button();
			this.btn_cad_cl_salvar = new System.Windows.Forms.Button();
			this.btn_cad_cl_novo = new System.Windows.Forms.Button();
			this.text_cad_cl_nome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.text_cad_cl_email = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mas_cad_cl_cnpj = new System.Windows.Forms.MaskedTextBox();
			this.mas_cad_cl_telefone = new System.Windows.Forms.MaskedTextBox();
			this.date_cad_cl_data = new System.Windows.Forms.DateTimePicker();
			this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.text_cad_cl_obs = new System.Windows.Forms.TextBox();
			this.comboBox_nacionalidade = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 334);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(845, 149);
			this.dataGridView1.TabIndex = 42;
			// 
			// btn_cad_cl_cancelar
			// 
			this.btn_cad_cl_cancelar.Location = new System.Drawing.Point(775, 288);
			this.btn_cad_cl_cancelar.Name = "btn_cad_cl_cancelar";
			this.btn_cad_cl_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_cl_cancelar.TabIndex = 41;
			this.btn_cad_cl_cancelar.Text = "Cancelar";
			this.btn_cad_cl_cancelar.UseVisualStyleBackColor = true;
			// 
			// btn_cad_cl_excluir
			// 
			this.btn_cad_cl_excluir.Location = new System.Drawing.Point(694, 288);
			this.btn_cad_cl_excluir.Name = "btn_cad_cl_excluir";
			this.btn_cad_cl_excluir.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_cl_excluir.TabIndex = 40;
			this.btn_cad_cl_excluir.Text = "Excluir";
			this.btn_cad_cl_excluir.UseVisualStyleBackColor = true;
			// 
			// btn_cad_cl_salvar
			// 
			this.btn_cad_cl_salvar.Location = new System.Drawing.Point(613, 288);
			this.btn_cad_cl_salvar.Name = "btn_cad_cl_salvar";
			this.btn_cad_cl_salvar.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_cl_salvar.TabIndex = 39;
			this.btn_cad_cl_salvar.Text = "Salvar";
			this.btn_cad_cl_salvar.UseVisualStyleBackColor = true;
			// 
			// btn_cad_cl_novo
			// 
			this.btn_cad_cl_novo.Location = new System.Drawing.Point(532, 288);
			this.btn_cad_cl_novo.Name = "btn_cad_cl_novo";
			this.btn_cad_cl_novo.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_cl_novo.TabIndex = 38;
			this.btn_cad_cl_novo.Text = "Novo";
			this.btn_cad_cl_novo.UseVisualStyleBackColor = true;
			this.btn_cad_cl_novo.Click += new System.EventHandler(this.btn_cad_cl_novo_Click);
			// 
			// text_cad_cl_nome
			// 
			this.text_cad_cl_nome.Location = new System.Drawing.Point(17, 55);
			this.text_cad_cl_nome.Name = "text_cad_cl_nome";
			this.text_cad_cl_nome.Size = new System.Drawing.Size(384, 20);
			this.text_cad_cl_nome.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "Nome completo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(446, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "Data de Nascimento";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(14, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 16);
			this.label7.TabIndex = 47;
			this.label7.Text = "Nacionalidade";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(446, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 45;
			this.label6.Text = "CNPJ/CPF";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 16);
			this.label2.TabIndex = 51;
			this.label2.Text = "Telefone/Celular";
			// 
			// text_cad_cl_email
			// 
			this.text_cad_cl_email.Location = new System.Drawing.Point(17, 230);
			this.text_cad_cl_email.Name = "text_cad_cl_email";
			this.text_cad_cl_email.Size = new System.Drawing.Size(384, 20);
			this.text_cad_cl_email.TabIndex = 50;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 16);
			this.label4.TabIndex = 49;
			this.label4.Text = "E-mail";
			// 
			// mas_cad_cl_cnpj
			// 
			this.mas_cad_cl_cnpj.Location = new System.Drawing.Point(449, 55);
			this.mas_cad_cl_cnpj.Mask = "000.000.000-00";
			this.mas_cad_cl_cnpj.Name = "mas_cad_cl_cnpj";
			this.mas_cad_cl_cnpj.Size = new System.Drawing.Size(384, 20);
			this.mas_cad_cl_cnpj.TabIndex = 54;
			// 
			// mas_cad_cl_telefone
			// 
			this.mas_cad_cl_telefone.Location = new System.Drawing.Point(17, 164);
			this.mas_cad_cl_telefone.Mask = "(99 ) 0 0000-0000";
			this.mas_cad_cl_telefone.Name = "mas_cad_cl_telefone";
			this.mas_cad_cl_telefone.Size = new System.Drawing.Size(384, 20);
			this.mas_cad_cl_telefone.TabIndex = 55;
			// 
			// date_cad_cl_data
			// 
			this.date_cad_cl_data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_cad_cl_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_cad_cl_data.Location = new System.Drawing.Point(449, 113);
			this.date_cad_cl_data.Name = "date_cad_cl_data";
			this.date_cad_cl_data.Size = new System.Drawing.Size(384, 20);
			this.date_cad_cl_data.TabIndex = 56;
			// 
			// gbxEstadoCivil
			// 
			this.gbxEstadoCivil.Location = new System.Drawing.Point(449, 145);
			this.gbxEstadoCivil.Name = "gbxEstadoCivil";
			this.gbxEstadoCivil.Size = new System.Drawing.Size(103, 112);
			this.gbxEstadoCivil.TabIndex = 57;
			this.gbxEstadoCivil.TabStop = false;
			this.gbxEstadoCivil.Text = "Estado Civil";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(586, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 58;
			this.label5.Text = "Observações";
			// 
			// text_cad_cl_obs
			// 
			this.text_cad_cl_obs.Location = new System.Drawing.Point(558, 164);
			this.text_cad_cl_obs.Multiline = true;
			this.text_cad_cl_obs.Name = "text_cad_cl_obs";
			this.text_cad_cl_obs.Size = new System.Drawing.Size(275, 93);
			this.text_cad_cl_obs.TabIndex = 59;
			// 
			// comboBox_nacionalidade
			// 
			this.comboBox_nacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_nacionalidade.FormattingEnabled = true;
			this.comboBox_nacionalidade.Location = new System.Drawing.Point(16, 112);
			this.comboBox_nacionalidade.Name = "comboBox_nacionalidade";
			this.comboBox_nacionalidade.Size = new System.Drawing.Size(384, 21);
			this.comboBox_nacionalidade.TabIndex = 60;
			// 
			// frm_clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(862, 506);
			this.Controls.Add(this.comboBox_nacionalidade);
			this.Controls.Add(this.text_cad_cl_obs);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gbxEstadoCivil);
			this.Controls.Add(this.date_cad_cl_data);
			this.Controls.Add(this.mas_cad_cl_telefone);
			this.Controls.Add(this.mas_cad_cl_cnpj);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.text_cad_cl_email);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_cad_cl_cancelar);
			this.Controls.Add(this.btn_cad_cl_excluir);
			this.Controls.Add(this.btn_cad_cl_salvar);
			this.Controls.Add(this.btn_cad_cl_novo);
			this.Controls.Add(this.text_cad_cl_nome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "frm_clientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Clientes";
			this.Load += new System.EventHandler(this.frm_clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_cad_cl_cancelar;
		private System.Windows.Forms.Button btn_cad_cl_excluir;
		private System.Windows.Forms.Button btn_cad_cl_salvar;
		private System.Windows.Forms.Button btn_cad_cl_novo;
		private System.Windows.Forms.TextBox text_cad_cl_nome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox text_cad_cl_email;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mas_cad_cl_cnpj;
		private System.Windows.Forms.MaskedTextBox mas_cad_cl_telefone;
		private System.Windows.Forms.DateTimePicker date_cad_cl_data;
		private System.Windows.Forms.GroupBox gbxEstadoCivil;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox text_cad_cl_obs;
		private System.Windows.Forms.ComboBox comboBox_nacionalidade;
	}
}