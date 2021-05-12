using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentWebMvc.Models;

namespace RentWebMvc.Controllers
{
    public class AlugueisController : Controller
    {
        public IActionResult Index()
        {
			List<Aluguel> list = new List<Aluguel>();
			list.Add(new Aluguel { Id = 0, Logradouro = "Rua de Teste 1", Numero = "01", Bairro = "Bairro de Teste", Complemento = "Complemento de Teste", CEP = "31110-600", Cidade = "BH", Estado = "MG", Alugado = true });
			list.Add(new Aluguel { Id = 1, Logradouro = "Rua de Teste 2", Numero = "02", Bairro = "Bairro de Teste", Complemento = "Complemento de Teste", CEP = "31110-600", Cidade = "BH", Estado = "MG", Alugado = true });

			return View(list);
        }
    }
}