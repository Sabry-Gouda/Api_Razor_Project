using classes.shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProJect.WASM.Services
{
    public class ProductService : IService<Product>
    {
        HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient=httpClient;
        }

        public async Task delete(int id)
        {
           await httpClient.DeleteAsync("/api/Products"+id);

        }

        public async Task<List<Product>> getAll()
        {
           List<Product> allproducts= await httpClient.GetFromJsonAsync<List<Product>>("/api/Products/");
            return allproducts;
        }

        public async Task<Product> getById(int id)
        {
           Product pro= await httpClient.GetFromJsonAsync<Product>("/api/Products/"+id);
            return pro;
        }

        public async Task insert(Product item)
        {
            await httpClient.PostAsJsonAsync<Product>("/api/Products/",item);
        }

        public async Task Update(int id, Product item)
        {
          await  httpClient.PutAsJsonAsync<Product>("/api/Products/"+id,item);
        }
    }
}
