using Api.Applicartion.EmailSender;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Api.Domain.UnitOfWork;
using MediatR;

namespace Api.Applicartion.Products
{
    public class ProductsService
    {
        private readonly IProductRespository _repository;
        private readonly IUnitOfWork _unit;
        private readonly IMediator _mediator;

        public ProductsService(IProductRespository repository, IUnitOfWork unit, IMediator mediator)
        {
            _repository = repository;
            _unit = unit;
            _mediator = mediator;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Add(Product product)
        {
            _repository.Add(product);
            await _unit.SaveChangesAsync();
            var request = new EmailNotificationRequest("eduin1178gmail.com", "Saludos", product.Name);
            await _mediator.Send(request);    
        }
    }
}
