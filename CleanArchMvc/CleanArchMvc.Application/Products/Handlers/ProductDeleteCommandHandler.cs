using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using MediatR;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class ProductDeleteCommandHandler : IRequestHandler<ProductDeleteCommand, Product>
    {
        private readonly IProductRepository _productRepository;

        public ProductDeleteCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository?? throw new ArgumentException(nameof(productRepository));
        }
        public async Task<Product> Handle(ProductDeleteCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                throw new ApplicationException($"Error could not be found.");
            }
            else
            {
                return await _productRepository.RemoveAsync(product);
            }
        }
    }

}
