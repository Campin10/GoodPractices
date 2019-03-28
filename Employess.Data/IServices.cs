using System.Threading.Tasks;

namespace Employess.Data
{
    public interface IServices
    {
        Task<ResponseServices> CallService(dynamic Json, string Config);
    }
}


