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
	public partial class frm_produtos : Form
	{
		public frm_produtos()
		{
			InitializeComponent();
		}

		private void frm_produtos_Load(object sender, EventArgs e)
		{
			AlterarEstadoDosCampos(false); // Inicialmente, desabilita os campos
		}

		// Função para limpar os campos
		private void LimparCampos()
		{
			text_codigo.Clear();
			text_descricao.Clear();
			text_codigo_gtin.Clear();
			text_unidade_medida.Clear();
			text_valor.Clear();
			text_quant_estoque.Clear();
		}

		// Função para habilitar/desabilitar os campos
		private void AlterarEstadoDosCampos(bool estado)
		{
			text_codigo.Enabled = estado;
			text_descricao.Enabled = estado;
			text_codigo_gtin.Enabled = estado;
			text_unidade_medida.Enabled = estado;
			text_valor.Enabled = estado;
			text_quant_estoque.Enabled = estado;
			btn_cad_prod_salvar.Enabled = estado;
			btn_cad_prod_cancelar.Enabled = estado;
		}

		// Função para verificar se todos os campos foram preenchidos
		private bool PreencheuTodosOsCampos()
		{
			return !(string.IsNullOrWhiteSpace(text_codigo.Text) ||
					 string.IsNullOrWhiteSpace(text_descricao.Text) ||
					 string.IsNullOrWhiteSpace(text_codigo_gtin.Text) ||
					 string.IsNullOrWhiteSpace(text_unidade_medida.Text) ||
					 string.IsNullOrWhiteSpace(text_valor.Text) ||
					 string.IsNullOrWhiteSpace(text_quant_estoque.Text));
		}

		// Função para exibir mensagens
		private void ExibirMensagem(string mensagem, string titulo = "Informação")
		{
			MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// Função para confirmar ações
		private bool ConfirmarAcao(string mensagem)
		{
			return MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}

		// Função do botão "Novo"
		private void btn_cad_prod_novo_Click(object sender, EventArgs e)
		{
			LimparCampos();
			AlterarEstadoDosCampos(true);
			text_codigo.Focus(); // Define o foco no campo de código
		}

		// Função do botão "Salvar"
		private void btn_cad_prod_salvar_Click(object sender, EventArgs e)
		{
			if (PreencheuTodosOsCampos())
			{
				// Código para salvar o produto no banco de dados ou lista
				// Produto novoProduto = new Produto(...); 
				// salvar no banco de dados ...

				ExibirMensagem("Produto cadastrado com sucesso!");
				LimparCampos();
				AlterarEstadoDosCampos(false);
			}
			else
			{
				ExibirMensagem("Por favor, preencha todos os campos obrigatórios.");
			}
		}

		// Função do botão "Excluir"
		private void btn_cad_prod_excluir_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(text_codigo.Text))
			{
				if (ConfirmarAcao("Deseja realmente excluir este produto?"))
				{
					// Código para excluir o produto do banco de dados

					ExibirMensagem("Produto excluído com sucesso!");
					LimparCampos();
					AlterarEstadoDosCampos(false);
				}
			}
			else
			{
				ExibirMensagem("Nenhum produto selecionado para exclusão.");
			}
		}

		// Função do botão "Cancelar"
		private void btn_cad_prod_cancelar_Click(object sender, EventArgs e)
		{
			if (ConfirmarAcao("Deseja cancelar as alterações?"))
			{
				LimparCampos();
				AlterarEstadoDosCampos(false);
			}
		}
	}
}