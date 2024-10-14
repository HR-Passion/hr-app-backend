using AplicationLayer.DTOs;

namespace InfrastructureLayer.Handlers.Contract
{
    public interface IContractHandler
    {
        /// <summary>
        /// create a contract for a user 
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public Task<bool> CreateContract(ContractDto contract);
    }
}
