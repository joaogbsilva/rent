using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentWebMvc.Models;
using RentWebMvc.Repository.Interfaces;

namespace RentWebMvc.Controllers
{
	public class ImoveisController : Controller
	{
		private readonly IImovelRepository _imovelRepo;

		public ImoveisController(IImovelRepository imovelRepo)
		{
			_imovelRepo = imovelRepo;
		}

		// GET: Imovels
		public async Task<IActionResult> Index()
		{
			return View(await _imovelRepo.GetAllImoveisAsync());
		}

		// GET: Imovels/Details/5
		public async Task<IActionResult> Details(int id)
		{

			var imovel = await _imovelRepo.GetImovelById(id);
			if (imovel == null)
			{
				return NotFound();
			}

			return View(imovel);
		}

		// GET: Imovels/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Imovels/Create        
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Logradouro,Numero,Complemento,Bairro,CEP,Cidade,Estado,Alugado")] Imovel imovel)
		{
			if (ModelState.IsValid)
			{
				_imovelRepo.Add(imovel);
				await _imovelRepo.SaveAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(imovel);
		}

		// GET: Imovels/Edit/5
		public async Task<IActionResult> Edit(int id)
		{
			var imovel = await _imovelRepo.GetImovelById(id);
			if (imovel == null)
			{
				return NotFound();
			}
			return View(imovel);
		}

		// POST: Imovels/Edit/5        
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Logradouro,Numero,Complemento,Bairro,CEP,Cidade,Estado,Alugado")] Imovel imovel)
		{
			if (id != imovel.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_imovelRepo.Update(imovel);
					await _imovelRepo.SaveAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!_imovelRepo.ImovelExists(imovel.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(imovel);
		}

		// GET: Imovels/Delete/5
		public async Task<IActionResult> Delete(int id)
		{
			var imovel = await _imovelRepo.GetImovelById(id);
			if (imovel == null)
			{
				return NotFound();
			}

			return View(imovel);
		}

		// POST: Imovels/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var imovel = await _imovelRepo.GetImovelById(id);
			_imovelRepo.Delete(imovel);
			await _imovelRepo.SaveAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}