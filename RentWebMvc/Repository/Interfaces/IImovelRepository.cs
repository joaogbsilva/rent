using RentWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentWebMvc.Repository.Interfaces
{
	public interface IImovelRepository
	{
		void Add(Imovel imovel);
		void Update(Imovel imovel);
		void Delete(Imovel imovel);
		Task<int> SaveAsync();
		Task<List<Imovel>> GetAllImoveisAsync();
		Task<Imovel> GetImovelById(int id);
		bool ImovelExists(int id);
	}
}