using AutoMapper;
using ContractsApp.Dto.DtoResponse;
using ContractsApp.Model;
using ContractsApp.Repository.GenericInterfaces;
using ContractsApp.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContractsApp.Service.Services
{
    public class ContractService : IContractService
    {
        //GR = GenericRepository
        private readonly IGenericRepository<Contract> _GRContract;
        private readonly IMapper _IMapper;

        public ContractService(IGenericRepository<Contract> GRContract, IMapper IMapper)
        {
            _GRContract = GRContract;
            _IMapper = IMapper;
        }

        public async Task<ContractDtoRE> Get(int Id)
        {
            try
            {
                var query = _GRContract.Get(x => x.Id == Id && x.Estado == true)
                    .Include(x=>x.Contractitems.Where(ci=>ci.Enabled == true))
                    .ThenInclude(y => y.Item);

                var contractModel = await query.FirstOrDefaultAsync();

                if (contractModel == null) throw new TaskCanceledException("El contrato no existe");

                return _IMapper.Map<ContractDtoRE>(contractModel);
            }
            catch (Exception ex)
            {
                throw new TaskCanceledException("Problemas al obtener el contrato, " + ex.Message);
            }
        }
    }
}
