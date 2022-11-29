using System.Threading.Tasks;
using WPF.RetailManager.Models;

namespace WPF.RetailManager.Helper
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}