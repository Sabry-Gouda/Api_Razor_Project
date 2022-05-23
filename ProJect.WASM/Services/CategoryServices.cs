using classes.shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProJect.WASM.Services
{
    public class CategoryServices : IService<Category>
    {
        HttpClient httpClient;
        public CategoryServices(HttpClient httpClient)
        {
            this.httpClient=httpClient;

        }

        public async Task delete(int id)
        {
            await httpClient.DeleteAsync("/api/Categories/"+id);

        }

        public async Task<List<Category>> getAll()
        {
            List<Category> allcats = await httpClient.GetFromJsonAsync<List<Category>>("/api/Categories/");
            return allcats;
        }

        public async Task<Category> getById(int id)
        {
            Category cate = await httpClient.GetFromJsonAsync<Category>("/api/Categories/"+id);
            return cate; ;
        }

        public async Task insert(Category item)
        {
            await httpClient.PostAsJsonAsync<Category>("/api/Categories/", item);

        }

        public async Task Update(int id, Category item)
        {
            await httpClient.PutAsJsonAsync<Category>("/api/Categories/"+id, item);

        }
    }
}
