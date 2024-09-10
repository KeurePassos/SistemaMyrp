using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMyrp
{
	public class Cad_Cliente
	{
		public enum EnumEstadoCivil
		{
			Casado,
			Divorciado,
			Solteiro,
			Víuvo
		}
		public class Cliente
		{

			public string Nome { get; set; }
			public long Cnpj { get; }
			public long CNPJ { get; set; }
			public DateTime DataNacimento { get; set; }
			public string Nacionalidade { get; set; }
			public EnumEstadoCivil EstadoCivil {get; set;}
			public string Email { get; set; }
			public int Telefone { get; set; }
			public string Observação { get; set; }
			public DateTime DataNascimento { get; internal set; }

			public Cliente(string nome, long cNPJ, DateTime dataNacimento, string nacionalidade,
				EnumEstadoCivil estadoCivil, string email, int telefone, string observações)
			{
				this.Nome = nome;
				this.Cnpj = cNPJ;
				this.DataNacimento = dataNacimento;
				this.Nacionalidade = nacionalidade;
				this.EstadoCivil = estadoCivil;
				this.Email = email;
				this.Telefone = telefone;
				this.Observação = observações;
			}
		}
	}
}