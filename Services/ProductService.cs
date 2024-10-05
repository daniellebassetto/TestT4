
using TestT4.Models;
using TestT4.Repositories;

namespace TestT4.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAll() => _repository.GetAll();
        public Product GetById(int id) => _repository.GetById(id);
        public void Add(Product product) => _repository.Add(product);
        public void Update(Product product) => _repository.Update(product);
        public void Delete(int id) => _repository.Delete(id);
    }
}