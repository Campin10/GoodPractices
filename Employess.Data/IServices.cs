using System.Threading.Tasks;

namespace Employess.Data
{
    public interface IServices
    {
        Task<ResponseServices> CallService(string Config);
    }
}


