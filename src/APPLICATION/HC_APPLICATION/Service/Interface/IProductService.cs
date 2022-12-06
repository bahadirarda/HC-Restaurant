using HC_APPLICATION.Models.DTO;
using HC_APPLICATION.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Service.Interface
{
    public interface IProductService
    {
        //Add
        Task<string> Create(CreateProductDTO model);
        //Delete
        Task<string> Delete(Guid id);
        //Update
        Task<string> Update(UpdateProductDTO model);
        //List
        Task<List<ProductVM>> GetListProducts();
        Task<List<ProductVM>> GetListDefaultProducts();
        Task<List<ProductVM>> GetListProductsByCategory(Guid? subCategoryId);
        //Find
        Task<UpdateProductDTO> GetById(Guid id);
    }
}
