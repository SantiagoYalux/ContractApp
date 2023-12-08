using ContractsApp.Dto.DtoResponse;
using ContractsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsApp.Service.Interfaces
{
    public interface IContractService
    {
        Task<ContractDtoRE> Get(int Id);
    }
}
