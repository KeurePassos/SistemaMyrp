using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaMyrp.Cad_Cliente;

namespace SistemaMyrp
{
	public partial class frm_clientes : Form
	{
		public frm_clientes()
		{
			InitializeComponent();
			AtualizarComboBoxNacionalidade();
			CriarControleEstadosCivis();

		}

		private void Informar(string mensagem)
		{
			MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private bool Confirmar(string pergunta)
		{
			return MessageBox.Show(pergunta, "Confirmação", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes;
		}

		private void AtualizarComboBoxNacionalidade()
		{
			comboBox_nacionalidade.DataSource = nacionalidade.Listagem;
			comboBox_nacionalidade.DisplayMember = "";
			comboBox_nacionalidade.DisplayMember = "Nome";
			comboBox_nacionalidade.ValueMember = "Sigla";
			comboBox_nacionalidade.SelectedIndex = -1;
		}

		private void CorrigirTabStop(object sender, EventArgs e)
		{
			((RadioButton)sender).TabStop = true;
		}

		// Método para corrigir a tabulação dos RadioButtons
		private void CriarControleEstadosCivis()
		{
			// Limpa o grupo de RadioButtons antes de adicionar novos (caso já tenha sido criado antes)
			gbxEstadoCivil.Controls.Clear();

			int iRB = 0;
			var estadosCivis = Enum.GetValues(typeof(EnumEstadoCivil));

			// Adiciona RadioButtons para cada estado civil
			foreach (var ec in estadosCivis)
			{
				RadioButton rb = new RadioButton()
				{
					Text = ec.ToString(),
					Location = new Point(10, (iRB + 1) * 27),  // Define a posição vertical
					Width = 85,  // Define a largura
					TabStop = true,
					TabIndex = iRB,  // Define a ordem de tabulação
					Tag = ec  // Armazena o valor do Enum como Tag
				};

				// Corrige a tabulação quando o RadioButton ganha foco
				rb.TabStopChanged += CorrigirTabStop;

				// Adiciona o RadioButton ao grupo de controles de estado civil
				gbxEstadoCivil.Controls.Add(rb);
				iRB++;
			}
		}

		// Método para ler o estado civil selecionado
		private EnumEstadoCivil? LerEstadoCivil()
		{
			foreach (Control control in gbxEstadoCivil.Controls)
			{
				RadioButton rb = control as RadioButton;
				if (rb != null && rb.Checked)
				{
					return (EnumEstadoCivil)rb.Tag;  // Retorna o valor do Enum armazenado no Tag
				}
			}
			return null;  // Se nenhum RadioButton estiver selecionado
		}

		// Método para marcar o estado civil em um RadioButton
		private void MarcarEstadoCivil(EnumEstadoCivil estadoCivil)
		{
			foreach (Control control in gbxEstadoCivil.Controls)
			{
				RadioButton rb = control as RadioButton;
				if (rb != null && (EnumEstadoCivil)rb.Tag == estadoCivil)
				{
					rb.Checked = true;  // Marca o RadioButton correspondente
					return;
				}
			}
		}

		private bool PreencheuTodosOsCampos()
		{
			if (String.IsNullOrWhiteSpace(text_cad_cl_nome.Text)) return false;
			if (String.IsNullOrWhiteSpace(mas_cad_cl_cnpj.Text)) return false;
			if (String.IsNullOrWhiteSpace(mas_cad_cl_telefone.Text)) return false;
			if (String.IsNullOrWhiteSpace(text_cad_cl_obs.Text)) return false;
			if (date_cad_cl_data.Value.Date == DateTime.Now.Date) return false;
			if (LerEstadoCivil() == null) return false;
			if (comboBox_nacionalidade.SelectedIndex < 0) return false;

			return true;

		}

		private void LimparCampos()
		{
			text_cad_cl_nome.Clear();
			mas_cad_cl_cnpj.Clear();
			text_cad_cl_email.Clear();
			mas_cad_cl_telefone.Clear();
			text_cad_cl_obs.Clear();
			date_cad_cl_data.Value = DateTime.Now.Date;
			foreach (var control in gbxEstadoCivil.Controls)
			{
				(control as RadioButton).Checked = false;
			}
			comboBox_nacionalidade.SelectedIndex = -1;

		}
		private bool PossuiValorNaoSalvos()
		{
			if (cbxCliente.SelectedIndex < 0)
			{
				if (!String.IsNullOrWhiteSpace(text_cad_cl_nome.Text)) return true;
				if (!String.IsNullOrWhiteSpace(mas_cad_cl_cnpj.Text)) return true;
				if (!String.IsNullOrWhiteSpace(mas_cad_cl_telefone.Text)) return true;
				if (!String.IsNullOrWhiteSpace(text_cad_cl_obs.Text)) return true;
				if (date_cad_cl_data.Value.Date != DateTime.Now.Date) return true;
				if (LerEstadoCivil() != null) return true;
				if (comboBox_nacionalidade.SelectedIndex > 0) return true;
			}
			else
			{
				Cliente cliente = cbxCliente.SelectedItem as Cliente;
				if (text_cad_cl_nome.Text.Trim() != cliente.Nome) return true;
				if (mas_cad_cl_cnpj.Text != cliente.CNPJ.ToString()) return true;
				if (mas_cad_cl_telefone.Text != cliente.Telefone.ToString()) return true;
				if (text_cad_cl_obs.Text != cliente.Observação) return true;
				if (date_cad_cl_data.Value.Date != cliente.DataNascimento) return true;
				if (LerEstadoCivil() != cliente.EstadoCivil) return true;
				if (comboBox_nacionalidade.SelectedValue.ToString() != cliente.Nacionalidade) return true;
			}
			return false;
		}
		private void AlterarEstadoDosCampos(bool estado)
		{
			text_cad_cl_nome.Enabled = estado;
			mas_cad_cl_cnpj.Enabled = estado;
			mas_cad_cl_telefone.Enabled = estado;
			text_cad_cl_obs.Enabled = estado;
			date_cad_cl_data.Enabled = estado;
			gbxEstadoCivil.Enabled = estado;
			comboBox_nacionalidade.Enabled = estado;
			btn_cad_cl_salvar.Enabled = estado;
			btn_cad_cl_cancelar.Enabled = estado;
		}

		private void HabilitarCampos()
		{
			AlterarEstadoDosCampos(true);
		}

		// Função do botão "Novo"
		private void btn_cad_cl_novo_Click(object sender, EventArgs e)
		{
			LimparCampos();
			HabilitarCampos();
			cbxCliente.SelectedIndex = -1; // Deselect any selected client
			text_cad_cl_nome.Focus(); // Set the focus to the name field
		}

		// Função do botão "Salvar"
		private void btn_cad_cl_salvar_Click(object sender, EventArgs e)
		{
			if (PreencheuTodosOsCampos())
			{
				// Criação de um novo objeto Cliente
				Cliente cliente = new Cliente(
					text_cad_cl_nome.Text.Trim(),
					long.Parse(mas_cad_cl_cnpj.Text),
					date_cad_cl_data.Value,
					comboBox_nacionalidade.SelectedValue.ToString(),
					LerEstadoCivil().Value,
					text_cad_cl_email.Text.Trim(),
					int.Parse(mas_cad_cl_telefone.Text),
					text_cad_cl_obs.Text.Trim()
				);

				// Simula a gravação no banco de dados (adapte conforme necessário)
				// cliente.Save();

				Informar("Cliente cadastrado com sucesso!");
				LimparCampos();
				AlterarEstadoDosCampos(false); // Desabilita os campos após o salvamento
			}
			else
			{
				Informar("Por favor, preencha todos os campos obrigatórios.");
			}
		}

		// Função do botão "Excluir"
		private void btn_cad_cl_excluir_Click(object sender, EventArgs e)
		{
			if (cbxCliente.SelectedIndex >= 0)
			{
				if (Confirmar("Tem certeza de que deseja excluir o cliente selecionado?"))
				{
					// Excluir o cliente do banco de dados (adapte conforme necessário)
					// cliente.Delete();

					Informar("Cliente excluído com sucesso!");
					LimparCampos();
					AlterarEstadoDosCampos(false);
				}
			}
			else
			{
				Informar("Nenhum cliente selecionado para exclusão.");
			}
		}

		// Função do botão "Cancelar"
		private void btn_cad_cl_cancelar_Click(object sender, EventArgs e)
		{
			if (PossuiValorNaoSalvos())
			{
				if (Confirmar("Há alterações não salvas. Deseja realmente cancelar?"))
				{
					LimparCampos();
					AlterarEstadoDosCampos(false);
				}
			}
			else
			{
				LimparCampos();
				AlterarEstadoDosCampos(false);
			}
		}

		private void frm_clientes_Load(object sender, EventArgs e)
		{

		}
	}
}
	
