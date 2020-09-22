using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelRegisterApp.Models
{
    public class ModelRepository : IModelRepository
    {
        private readonly ModelDbContext _context;

        public ModelRepository(ModelDbContext context)
        {
            this._context = context;
        }

        //입력
        public async Task<Model> AddModelAsync(Model model)
        {
            _context.Models.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
        //삭제
        public async Task DeleteModelAsync(int modelcode)
        {
            var model = await _context.Models.Where(m => m.ModelCode == modelcode).SingleOrDefaultAsync();
            if (model != null)
            {
                _context.Models.Remove(model);
                await _context.SaveChangesAsync();
            }
        }
        //수정
        public async Task<Model> EditModelAsync(Model model)
        {
            _context.Entry<Model>(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }

       //출력
        public async Task<List<Model>> GetModelAsync()
        {
            return await _context.Models.OrderByDescending(m => m.ModelCode).ToListAsync();
        }
       //상세보기
        public async Task<Model> GetModelName(int modelcode)
        {
            return await _context.Models.Where(m => m.ModelCode == modelcode).SingleOrDefaultAsync();
        }
    
    }
}
