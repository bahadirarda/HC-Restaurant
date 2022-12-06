using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface ICategoryService
    {
        //Add
        Task<string> Create(CreateCategoryDTO model);
        //Delete
        Task<string> Delete(Guid id);
        //Update
        Task<string> Update(UpdateCategoryDTO model);
        //List
        Task<List<CategoryVM>> GetListCategories();
        Task<List<CategoryVM>> GetListDefaultCategories();
        //Find
        Task<UpdateCategoryDTO> GetById(Guid id);
    }
}
