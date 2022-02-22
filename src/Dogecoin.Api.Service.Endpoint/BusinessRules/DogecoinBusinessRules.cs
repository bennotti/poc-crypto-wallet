using Dogecoin.Api.Service.Endpoint.BusinessRules.Interface;
using Dogecoin.Api.Service.Endpoint.Dtos;
using Dogecoin.Api.Service.Endpoint.Wallets.Dogecoin;
using System.Threading.Tasks;

namespace Dogecoin.Api.Service.Endpoint.BusinessRules
{
    public class DogecoinBusinessRules : IDogecoinBusinessRules
    {
        public async Task<ResponseApiBaseDto<DogecoinAddressBalanceResponseDto>> Handle(DogecoinAddressBalanceRequestDto request)
        {
            var dogeWallet = new DogeTestnetWallet();

            var Address = request.Address;
            var Balance = dogeWallet.GetBalance(request.Address).GetAwaiter().GetResult();

            await Task.CompletedTask;

            return new ResponseApiBaseDto<DogecoinAddressBalanceResponseDto>
            {
                Data = new DogecoinAddressBalanceResponseDto
                {
                    Address = Address,
                    Saldo = Balance,
                }
            };
        }
    }
}
