using app_formulario_crud.Models;
using Refit;
using System.Threading.Tasks;

namespace app_formulario_crud.Controllers.Services
{
    public interface ICepApiResponse
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
