using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelRegisterApp.Models
{
    public interface IModelRepository
    {
        Task<Model> AddModelAsync(Model model);
        Task<List<Model>> GetModelAsync();
        Task<Model> GetModelName(int modelcode);
        Task<Model> EditModelAsync(Model model);
        Task DeleteModelAsync(int modelcode);

    }
}
