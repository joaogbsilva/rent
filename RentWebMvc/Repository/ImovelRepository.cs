using Microsoft.EntityFrameworkCore;
using RentWebMvc.Models;
using RentWebMvc.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentWebMvc.Repository
{
	public class ImovelRepository : IImovelRepository
	{
		private readonly RentWebMvcContext _context;

		public ImovelRepository(RentWebMvcContext context)
		{
			_context = context;
		}

		public void Add(Imovel imovel)
		{
			_context.Add(imovel);
		}

		public void Update(Imovel imovel)
		{
			_context.Update(imovel);
		}

		public void Delete(Imovel imovel)
		{
			_context.Remove(imovel);
		}

		public async Task<int> SaveAsync()
		{
			return await _context.SaveChangesAsync();
		}

		public async Task<List<Imovel>> GetAllImoveisAsync()
		{
			return await _context.Imovel.ToListAsync();
		}

		public async Task<Imovel> GetImovelById(int id)
		{
			return await _context.Imovel
				.FirstOrDefaultAsync(m => m.Id == id);
		}

		public bool ImovelExists(int id)
		{
			return _context.Imovel.Any(e => e.Id == id);
		}
	}
}