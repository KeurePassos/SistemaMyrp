﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMyrp
{
	public class nacionalidade
	{
		public string Sigla { get; set; }
		public string Nome { get; set; }

		public nacionalidade(string sigla, string nome)
		{
			this.Sigla = sigla;
			this.Nome = nome;
		}
	public static List<nacionalidade> Listagem { get; set; }

		static nacionalidade()
		{
			nacionalidade.Listagem = new List<nacionalidade>();
			Listagem.Add(new nacionalidade("AF", "Afeganistão"));
			Listagem.Add(new nacionalidade("ZA", "África do Sul"));
			Listagem.Add(new nacionalidade("AL", "Albânia"));
			Listagem.Add(new nacionalidade("DE", "Alemanha"));
			Listagem.Add(new nacionalidade("AD", "Andorra"));
			Listagem.Add(new nacionalidade("AO", "Angola"));
			Listagem.Add(new nacionalidade("AI", "Anguila"));
			Listagem.Add(new nacionalidade("AG", "Antígua e Barbuda"));
			Listagem.Add(new nacionalidade("SA", "Arábia Saudita"));
			Listagem.Add(new nacionalidade("DZ", "Argélia"));
			Listagem.Add(new nacionalidade("AR", "Argentina"));
			Listagem.Add(new nacionalidade("AM", "Armênia"));
			Listagem.Add(new nacionalidade("AW", "Aruba"));
			Listagem.Add(new nacionalidade("AU", "Austrália"));
			Listagem.Add(new nacionalidade("AT", "Áustria"));
			Listagem.Add(new nacionalidade("AZ", "Azerbaijão"));
			Listagem.Add(new nacionalidade("BS", "Bahamas"));
			Listagem.Add(new nacionalidade("BH", "Bahrein"));
			Listagem.Add(new nacionalidade("BD", "Bangladesh"));
			Listagem.Add(new nacionalidade("BB", "Barbados"));
			Listagem.Add(new nacionalidade("BY", "Bielorrússia"));
			Listagem.Add(new nacionalidade("BE", "Bélgica"));
			Listagem.Add(new nacionalidade("BZ", "Belize"));
			Listagem.Add(new nacionalidade("BJ", "Benin"));
			Listagem.Add(new nacionalidade("BM", "Bermudas"));
			Listagem.Add(new nacionalidade("BO", "Bolívia"));
			Listagem.Add(new nacionalidade("BA", "Bósnia e Herzegovina"));
			Listagem.Add(new nacionalidade("BW", "Botswana"));
			Listagem.Add(new nacionalidade("BR", "Brasil"));
			Listagem.Add(new nacionalidade("BN", "Brunei"));
			Listagem.Add(new nacionalidade("BG", "Bulgária"));
			Listagem.Add(new nacionalidade("BF", "Burkina Faso"));
			Listagem.Add(new nacionalidade("BI", "Burundi"));
			Listagem.Add(new nacionalidade("BT", "Butão"));
			Listagem.Add(new nacionalidade("CV", "Cabo Verde"));
			Listagem.Add(new nacionalidade("KH", "Camboja"));
			Listagem.Add(new nacionalidade("CM", "Camarões"));
			Listagem.Add(new nacionalidade("CA", "Canadá"));
			Listagem.Add(new nacionalidade("QA", "Catar"));
			Listagem.Add(new nacionalidade("KZ", "Cazaquistão"));
			Listagem.Add(new nacionalidade("TD", "Chade"));
			Listagem.Add(new nacionalidade("CL", "Chile"));
			Listagem.Add(new nacionalidade("CN", "China"));
			Listagem.Add(new nacionalidade("CY", "Chipre"));
			Listagem.Add(new nacionalidade("SG", "Cingapura"));
			Listagem.Add(new nacionalidade("CO", "Colômbia"));
			Listagem.Add(new nacionalidade("KM", "Comores"));
			Listagem.Add(new nacionalidade("CG", "Congo"));
			Listagem.Add(new nacionalidade("CD", "Congo (Rep. Dem.)"));
			Listagem.Add(new nacionalidade("KP", "Coreia do Norte"));
			Listagem.Add(new nacionalidade("KR", "Coreia do Sul"));
			Listagem.Add(new nacionalidade("CR", "Costa Rica"));
			Listagem.Add(new nacionalidade("HR", "Croácia"));
			Listagem.Add(new nacionalidade("CU", "Cuba"));
			Listagem.Add(new nacionalidade("DK", "Dinamarca"));
			Listagem.Add(new nacionalidade("DJ", "Djibouti"));
			Listagem.Add(new nacionalidade("DM", "Dominica"));
			Listagem.Add(new nacionalidade("EG", "Egito"));
			Listagem.Add(new nacionalidade("SV", "El Salvador"));
			Listagem.Add(new nacionalidade("AE", "Emirados Árabes Unidos"));
			Listagem.Add(new nacionalidade("EC", "Equador"));
			Listagem.Add(new nacionalidade("ER", "Eritreia"));
			Listagem.Add(new nacionalidade("SK", "Eslováquia"));
			Listagem.Add(new nacionalidade("SI", "Eslovênia"));
			Listagem.Add(new nacionalidade("ES", "Espanha"));
			Listagem.Add(new nacionalidade("US", "Estados Unidos"));
			Listagem.Add(new nacionalidade("EE", "Estônia"));
			Listagem.Add(new nacionalidade("ET", "Etiópia"));
			Listagem.Add(new nacionalidade("FJ", "Fiji"));
			Listagem.Add(new nacionalidade("PH", "Filipinas"));
			Listagem.Add(new nacionalidade("FI", "Finlândia"));
			Listagem.Add(new nacionalidade("FR", "França"));
			Listagem.Add(new nacionalidade("GA", "Gabão"));
			Listagem.Add(new nacionalidade("GM", "Gâmbia"));
			Listagem.Add(new nacionalidade("GH", "Gana"));
			Listagem.Add(new nacionalidade("GE", "Geórgia"));
			Listagem.Add(new nacionalidade("GS", "Geórgia do Sul e Ilhas Sandwich do Sul"));
			Listagem.Add(new nacionalidade("GI", "Gibraltar"));
			Listagem.Add(new nacionalidade("GR", "Grécia"));
			Listagem.Add(new nacionalidade("GD", "Granada"));
			Listagem.Add(new nacionalidade("GL", "Groenlândia"));
			Listagem.Add(new nacionalidade("GP", "Guadalupe"));
			Listagem.Add(new nacionalidade("GU", "Guam"));
			Listagem.Add(new nacionalidade("GT", "Guatemala"));
			Listagem.Add(new nacionalidade("GY", "Guiana"));
			Listagem.Add(new nacionalidade("GF", "Guiana Francesa"));
			Listagem.Add(new nacionalidade("GN", "Guiné"));
			Listagem.Add(new nacionalidade("GQ", "Guiné Equatorial"));
			Listagem.Add(new nacionalidade("GW", "Guiné-Bissau"));
			Listagem.Add(new nacionalidade("HT", "Haiti"));
			Listagem.Add(new nacionalidade("HN", "Honduras"));
			Listagem.Add(new nacionalidade("HK", "Hong Kong"));
			Listagem.Add(new nacionalidade("HU", "Hungria"));
			Listagem.Add(new nacionalidade("YE", "Iémen"));
			Listagem.Add(new nacionalidade("BV", "Ilha Bouvet"));
			Listagem.Add(new nacionalidade("NF", "Ilha Norfolk"));
			Listagem.Add(new nacionalidade("KY", "Ilhas Cayman"));
			Listagem.Add(new nacionalidade("CC", "Ilhas Cocos (Keeling)"));
			Listagem.Add(new nacionalidade("CK", "Ilhas Cook"));
			Listagem.Add(new nacionalidade("FO", "Ilhas Faroe"));
			Listagem.Add(new nacionalidade("FK", "Ilhas Malvinas (Falkland)"));
			Listagem.Add(new nacionalidade("MP", "Ilhas Marianas do Norte"));
			Listagem.Add(new nacionalidade("MH", "Ilhas Marshall"));
			Listagem.Add(new nacionalidade("PN", "Ilhas Pitcairn"));
			Listagem.Add(new nacionalidade("SB", "Ilhas Salomão"));
			Listagem.Add(new nacionalidade("TC", "Ilhas Turcas e Caicos"));
			Listagem.Add(new nacionalidade("VG", "Ilhas Virgens Britânicas"));
			Listagem.Add(new nacionalidade("VI", "Ilhas Virgens dos EUA"));
			Listagem.Add(new nacionalidade("IN", "Índia"));
			Listagem.Add(new nacionalidade("ID", "Indonésia"));
			Listagem.Add(new nacionalidade("IR", "Irã"));
			Listagem.Add(new nacionalidade("IQ", "Iraque"));
			Listagem.Add(new nacionalidade("IE", "Irlanda"));
			Listagem.Add(new nacionalidade("IS", "Islândia"));
			Listagem.Add(new nacionalidade("IL", "Israel"));
			Listagem.Add(new nacionalidade("IT", "Itália"));
			Listagem.Add(new nacionalidade("JM", "Jamaica"));
			Listagem.Add(new nacionalidade("JP", "Japão"));
			Listagem.Add(new nacionalidade("JO", "Jordânia"));
			Listagem.Add(new nacionalidade("KW", "Kuwait"));
			Listagem.Add(new nacionalidade("LA", "Laos"));
			Listagem.Add(new nacionalidade("LV", "Letônia"));
			Listagem.Add(new nacionalidade("LB", "Líbano"));
			Listagem.Add(new nacionalidade("LS", "Lesoto"));
			Listagem.Add(new nacionalidade("LR", "Libéria"));
			Listagem.Add(new nacionalidade("LY", "Líbia"));
			Listagem.Add(new nacionalidade("LI", "Liechtenstein"));
			Listagem.Add(new nacionalidade("LT", "Lituânia"));
			Listagem.Add(new nacionalidade("LU", "Luxemburgo"));
			Listagem.Add(new nacionalidade("MO", "Macau"));
			Listagem.Add(new nacionalidade("MK", "Macedônia do Norte"));
			Listagem.Add(new nacionalidade("MG", "Madagascar"));
			Listagem.Add(new nacionalidade("MY", "Malásia"));
			Listagem.Add(new nacionalidade("MW", "Malawi"));
			Listagem.Add(new nacionalidade("MV", "Maldivas"));
			Listagem.Add(new nacionalidade("ML", "Mali"));
			Listagem.Add(new nacionalidade("MT", "Malta"));
			Listagem.Add(new nacionalidade("MA", "Marrocos"));
			Listagem.Add(new nacionalidade("MQ", "Martinica"));
			Listagem.Add(new nacionalidade("MR", "Mauritânia"));
			Listagem.Add(new nacionalidade("MU", "Maurício"));
			Listagem.Add(new nacionalidade("YT", "Mayotte"));
			Listagem.Add(new nacionalidade("MX", "México"));
			Listagem.Add(new nacionalidade("FM", "Micronésia"));
			Listagem.Add(new nacionalidade("MZ", "Moçambique"));
			Listagem.Add(new nacionalidade("MD", "Moldávia"));
			Listagem.Add(new nacionalidade("MC", "Mônaco"));
			Listagem.Add(new nacionalidade("MN", "Mongólia"));
			Listagem.Add(new nacionalidade("ME", "Montenegro"));
			Listagem.Add(new nacionalidade("MS", "Montserrat"));
			Listagem.Add(new nacionalidade("MM", "Mianmar"));
			Listagem.Add(new nacionalidade("NA", "Namíbia"));
			Listagem.Add(new nacionalidade("NR", "Nauru"));
			Listagem.Add(new nacionalidade("NP", "Nepal"));
			Listagem.Add(new nacionalidade("NI", "Nicarágua"));
			Listagem.Add(new nacionalidade("NE", "Níger"));
			Listagem.Add(new nacionalidade("NG", "Nigéria"));
			Listagem.Add(new nacionalidade("NU", "Niue"));
			Listagem.Add(new nacionalidade("NO", "Noruega"));
			Listagem.Add(new nacionalidade("OM", "Omã"));
			Listagem.Add(new nacionalidade("NL", "Países Baixos"));
			Listagem.Add(new nacionalidade("PW", "Palau"));
			Listagem.Add(new nacionalidade("PA", "Panamá"));
			Listagem.Add(new nacionalidade("PG", "Papua-Nova Guiné"));
			Listagem.Add(new nacionalidade("PK", "Paquistão"));
			Listagem.Add(new nacionalidade("PY", "Paraguai"));
			Listagem.Add(new nacionalidade("PE", "Peru"));
			Listagem.Add(new nacionalidade("PF", "Polinésia Francesa"));
			Listagem.Add(new nacionalidade("PL", "Polônia"));
			Listagem.Add(new nacionalidade("PR", "Porto Rico"));
			Listagem.Add(new nacionalidade("PT", "Portugal"));
			Listagem.Add(new nacionalidade("KE", "Quênia"));
			Listagem.Add(new nacionalidade("KG", "Quirguistão"));
			Listagem.Add(new nacionalidade("KI", "Quiribati"));
			Listagem.Add(new nacionalidade("GB", "Reino Unido"));
			Listagem.Add(new nacionalidade("CF", "República Centro-Africana"));
			Listagem.Add(new nacionalidade("CZ", "República Tcheca"));
			Listagem.Add(new nacionalidade("DO", "República Dominicana"));
			Listagem.Add(new nacionalidade("RO", "Romênia"));
			Listagem.Add(new nacionalidade("RW", "Ruanda"));
			Listagem.Add(new nacionalidade("RU", "Rússia"));
			Listagem.Add(new nacionalidade("EH", "Saara Ocidental"));
			Listagem.Add(new nacionalidade("WS", "Samoa"));
			Listagem.Add(new nacionalidade("AS", "Samoa Americana"));
			Listagem.Add(new nacionalidade("SH", "Santa Helena"));
			Listagem.Add(new nacionalidade("LC", "Santa Lúcia"));
			Listagem.Add(new nacionalidade("SM", "San Marino"));
			Listagem.Add(new nacionalidade("ST", "São Tomé e Príncipe"));
			Listagem.Add(new nacionalidade("VC", "São Vicente e Granadinas"));
			Listagem.Add(new nacionalidade("SN", "Senegal"));
			Listagem.Add(new nacionalidade("SL", "Serra Leoa"));
			Listagem.Add(new nacionalidade("RS", "Sérvia"));
			Listagem.Add(new nacionalidade("SC", "Seicheles"));
			Listagem.Add(new nacionalidade("SG", "Singapura"));
			Listagem.Add(new nacionalidade("SY", "Síria"));
			Listagem.Add(new nacionalidade("SO", "Somália"));
			Listagem.Add(new nacionalidade("LK", "Sri Lanka"));
			Listagem.Add(new nacionalidade("SZ", "Suazilândia"));
			Listagem.Add(new nacionalidade("SD", "Sudão"));
			Listagem.Add(new nacionalidade("SS", "Sudão do Sul"));
			Listagem.Add(new nacionalidade("SE", "Suécia"));
			Listagem.Add(new nacionalidade("CH", "Suíça"));
			Listagem.Add(new nacionalidade("SR", "Suriname"));
			Listagem.Add(new nacionalidade("TH", "Tailândia"));
			Listagem.Add(new nacionalidade("TW", "Taiwan"));
			Listagem.Add(new nacionalidade("TJ", "Tajiquistão"));
			Listagem.Add(new nacionalidade("TZ", "Tanzânia"));
			Listagem.Add(new nacionalidade("TG", "Togo"));
			Listagem.Add(new nacionalidade("TK", "Tokelau"));
			Listagem.Add(new nacionalidade("TO", "Tonga"));
			Listagem.Add(new nacionalidade("TT", "Trinidad e Tobago"));
			Listagem.Add(new nacionalidade("TN", "Tunísia"));
			Listagem.Add(new nacionalidade("TM", "Turcomenistão"));
			Listagem.Add(new nacionalidade("TR", "Turquia"));
			Listagem.Add(new nacionalidade("TV", "Tuvalu"));
			Listagem.Add(new nacionalidade("UA", "Ucrânia"));
			Listagem.Add(new nacionalidade("UG", "Uganda"));
			Listagem.Add(new nacionalidade("UY", "Uruguai"));
			Listagem.Add(new nacionalidade("UZ", "Uzbequistão"));
			Listagem.Add(new nacionalidade("VU", "Vanuatu"));
			Listagem.Add(new nacionalidade("VA", "Vaticano"));
			Listagem.Add(new nacionalidade("VE", "Venezuela"));
			Listagem.Add(new nacionalidade("VN", "Vietnã"));
			Listagem.Add(new nacionalidade("WF", "Wallis e Futuna"));
			Listagem.Add(new nacionalidade("ZM", "Zâmbia"));
			Listagem.Add(new nacionalidade("ZW", "Zimbábue"));
		}
	}
}
