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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void btn_cad_prod_Click(object sender, EventArgs e)
		{
			frm_produtos frmProdutos = new frm_produtos();
			frmProdutos.Show();
		}

		private void btn_cad_clientes_Click(object sender, EventArgs e)
		{
			frm_clientes frmClientes = new frm_clientes();
			frmClientes.Show();
		}

		private void btn_vendas_Click(object sender, EventArgs e)
		{
			frm_vendas frmVendas = new frm_vendas();
			frmVendas.Show();
		}

		private void btn_sair_menu_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}