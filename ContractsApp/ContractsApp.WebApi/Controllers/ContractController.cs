using ContractsApp.Dto.DtoResponse;
using ContractsApp.Dto.GenericResponseApi;
using ContractsApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContractsApp.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _IContractService;

        public ContractController(IContractService IContractService)
        {
            _IContractService = IContractService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int ID)
        {
            if (ID <= 0)
                return BadRequest("Debe proporcionar un ID válido");

            ApiRE<ContractDtoRE> dataResponse = new();

            try
            {
                dataResponse.Data = await _IContractService.Get(ID);
                dataResponse.Message = "Ok";
                dataResponse.Sucess = true;
            }
            catch (Exception ex)
            {
                dataResponse.Message = ex.Message;
                return NotFound(dataResponse);
            }

            return Ok(dataResponse);
        }
    }
}
