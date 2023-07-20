using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public  interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int? id);
        Task<ProductDTO> GetProductCategoryAsync(int? id);
        Task Add(ProductDTO productDTO);
        Task Update(ProductDTO productDTO);
        Task Delete(int? id);
    }
}
