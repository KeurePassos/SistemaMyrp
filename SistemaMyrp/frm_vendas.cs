using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMyrp
{
		public partial class frm_vendas : Form
		{
			public frm_vendas()
			{
				InitializeComponent();
			}

			private void frm_vendas_Load(object sender, EventArgs e)
			{
				// Inicializa os componentes necessários, se houver
				AlterarEstadoDosCampos(false);
			}

			// Função para adicionar um novo produto
			private void btn_venda_mais_Click(object sender, EventArgs e)
			{
				AdicionarProduto();
			}

			// Função para remover informações dos campos
			private void btn_rem_prod_Click(object sender, EventArgs e)
			{
				LimparCamposProduto();
			}

			// Função para inicializar uma nova venda
			private void btn_venda_novo_Click(object sender, EventArgs e)
			{
				LimparCamposVenda();
				AlterarEstadoDosCampos(true);
				comboBox_destinatario.Focus();
			}

			// Função para emitir a venda
			private void btn_venda_emitir_Click(object sender, EventArgs e)
			{
				if (TodosCamposPreenchidos() || string.IsNullOrWhiteSpace(comboBox_destinatario.Text))
				{
					// Código para emitir a venda
					MessageBox.Show("Venda emitida com sucesso!");
					LimparCamposVenda();
					AlterarEstadoDosCampos(false);
				}
				else
				{
					MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
				}
			}

			// Função para excluir a venda
			private void btn_venda_excluir_Click(object sender, EventArgs e)
			{
				if (MessageBox.Show("Deseja realmente excluir esta venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					// Código para excluir a venda
					MessageBox.Show("Venda excluída com sucesso!");
					LimparCamposVenda();
					AlterarEstadoDosCampos(false);
				}
			}

			// Função para cancelar a venda
			private void btn_venda_cancelar_Click(object sender, EventArgs e)
			{
				if (MessageBox.Show("Deseja cancelar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					LimparCamposVenda();
					AlterarEstadoDosCampos(false);
				}
			}

			// Adiciona um novo produto à lista
			private void AdicionarProduto()
			{
				// Adiciona o produto à lista de produtos na venda
				// Atualiza o valor total da venda
			}

			// Limpa os campos relacionados ao produto
			private void LimparCamposProduto()
			{
				comboBox_prod.SelectedIndex = -1;
				text_quantidade.Clear();
				text_valor_unitario.Clear();
				text_valor_total.Clear();
			}

			// Limpa todos os campos da venda
			private void LimparCamposVenda()
			{
				comboBox_destinatario.SelectedIndex = -1;
				LimparCamposProduto();
				text_acrescimo.Clear();
				text_desconto.Clear();
				text_valor_total_venda.Clear();
				// Limpa a seleção de pagamento
			}

			// Verifica se todos os campos obrigatórios estão preenchidos
			private bool TodosCamposPreenchidos()
			{
				return !string.IsNullOrWhiteSpace(comboBox_destinatario.Text) &&
					   !string.IsNullOrWhiteSpace(text_quantidade.Text) &&
					   !string.IsNullOrWhiteSpace(text_valor_unitario.Text) &&
					   !string.IsNullOrWhiteSpace(text_valor_total.Text) &&
					   !string.IsNullOrWhiteSpace(text_acrescimo.Text) &&
					   !string.IsNullOrWhiteSpace(text_desconto.Text) &&
					   !string.IsNullOrWhiteSpace(text_valor_total_venda.Text) &&
					   (venda_pagamento.SelectedIndex >= 0);
			}

			// Atualiza o valor total do produto
			private void AtualizarValorTotalProduto()
			{
				if (decimal.TryParse(text_quantidade.Text, out decimal quantidade) &&
					decimal.TryParse(text_valor_unitario.Text, out decimal valorUnitario))
				{
					text_valor_total.Text = (quantidade * valorUnitario).ToString("F2");
				}
			}

			// Atualiza o valor total da venda
			private void AtualizarValorTotalVenda()
			{
				// Implementar a lógica para somar todos os valores totais dos produtos e considerar acréscimos e descontos
				decimal total = 0;
				// Somar os valores totais dos produtos

				if (decimal.TryParse(text_acrescimo.Text, out decimal acrescimo))
				{
					total += acrescimo;
				}

				if (decimal.TryParse(text_desconto.Text, out decimal desconto))
				{
					total -= desconto;
				}

				text_valor_total_venda.Text = total.ToString("F2");
			}

			// Habilita ou desabilita os campos
			private void AlterarEstadoDosCampos(bool estado)
			{
				comboBox_destinatario.Enabled = estado;
				comboBox_prod.Enabled = estado;
				text_quantidade.Enabled = estado;
				text_valor_unitario.Enabled = estado;
				text_valor_total.Enabled = estado;
				text_acrescimo.Enabled = estado;
				text_desconto.Enabled = estado;
				venda_pagamento.Enabled = estado;
				btn_venda_emitir.Enabled = estado;
				btn_venda_cancelar.Enabled = estado;
			}
		}
	}

