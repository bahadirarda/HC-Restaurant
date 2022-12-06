using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface ISubCategoryService
    {
        //Add
        Task<string> Create(CreateSubCategoryDTO model);
        //Delete
        Task<string> Delete(Guid id);
        //Update
        Task<string> Update(UpdateSubCategoryDTO model);
        //List
        Task<List<SubCategoryVM>> GetListSubCategories();

        Task<List<SubCategoryVM>> GetListDefaultSubCategories();
        //Find
        Task<UpdateSubCategoryDTO> GetById(Guid id);
    }
}
