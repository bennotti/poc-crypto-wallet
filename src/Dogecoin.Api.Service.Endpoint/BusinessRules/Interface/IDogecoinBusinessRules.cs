using Dogecoin.Api.Service.Endpoint.Dtos;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint.BusinessRules.Interface
{
    public interface IDogecoinBusinessRules: IApiBusinessRules
    {
        Task<ResponseApiBaseDto<DogecoinAddressBalanceResponseDto>> Handle(DogecoinAddressBalanceRequestDto request);
    }
}
