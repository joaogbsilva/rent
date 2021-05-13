using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentWebMvc.Models
{
	public class Imovel
	{		
		public int Id { get; set; }
		[Required(ErrorMessage = "O campo Rua é obrigatório")] public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		[Required(ErrorMessage = "O campo Bairro é obrigatório")] public string Bairro { get; set; }
		[Required(ErrorMessage = "O campo CEP é obrigatório")]	public string CEP { get; set; }
		[Required(ErrorMessage = "O campo Cidade é obrigatório")] public string Cidade { get; set; }
		[Required(ErrorMessage = "O campo Estado é obrigatório")] public string Estado { get; set; }
		public bool Alugado { get; set; }
	}
}
