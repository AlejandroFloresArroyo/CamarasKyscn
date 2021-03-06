using System.Threading.Tasks;
using AutoMapper;
using CamKyscn.Dtos.Paquete;
using CamKyscn.Entities;

namespace CamKyscn.Services.PaqueteService
{
    public class PaqueteService : IPaqueteService
    {

        private readonly IMapper _mapper;
        public PaqueteService(IMapper mapper)
		{
			this._mapper = mapper;
		}
        public Task<ServiceResponse<AddPaqueteDTO>> AddPaquete(AddPaqueteDTO paquete)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetPaqueteDTO>> GetPaqueteById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}