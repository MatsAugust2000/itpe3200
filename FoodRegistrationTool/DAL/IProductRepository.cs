using FoodRegistrationTool.Models;

namespace FoodRegistrationTool.DAL;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product?> GetProductById(int id);
    Task Create(Product product);
    Task Update(Product product);
    Task<bool> Delete(int id);
    Task<IEnumerable<Producer>> GetAllProducers();
    Task<Producer?> GetProducerById(int id);
    Task CreateProducer(Producer producer);
}