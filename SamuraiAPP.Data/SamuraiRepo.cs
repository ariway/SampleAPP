using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using SamuraiAPP.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiAPP.Data
{
    public class SamuraiRepo : ISamurai
    {
        private SamuraiContext _context;

        public SamuraiRepo(SamuraiContext context)
        {
            _context = context;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Samurai>> GetAll()
        {
            var results = await _context.Samurais.OrderBy(s => s.Name).AsNoTracking().ToListAsync();
            return results;
        }

        public async Task<Samurai> GetById(int id)
        {
            var result = await _context.Samurais.FirstOrDefaultAsync(s => s.Id == id);
            if (result == null) throw new Exception($"Data samurai id : {id} Tidak ditemukan");
            return result;
        }

        public async Task<Samurai> Insert(Samurai obj)
        {
            try
            {
                _context.Samurais.Add(obj);
                await _context.SaveChangesAsync();
                return obj;
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Samurai> Update(int id, Samurai obj)
        {
            try
            {
                var updateSamurai = await GetById(id);
                updateSamurai.Name = obj.Name;
                await _context.SaveChangesAsync();
                return updateSamurai;
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
