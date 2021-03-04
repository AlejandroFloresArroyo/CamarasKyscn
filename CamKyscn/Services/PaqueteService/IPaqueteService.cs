using System.Threading.Tasks;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;

namespace CamKyscn.Services.PaqueteService
{
    public interface IPaqueteService
    {
        Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteById(int id);
        Task<ServiceResponse<AddPaqueteDTO>> AddPaquete(AddPaqueteDTO paquete);

    }
}