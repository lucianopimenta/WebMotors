using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebMotorsTeste.Core.Interface
{
    public interface IRest
    {
        Task<T> GetAsync<T>(string psApi, Dictionary<string, string> poHeaders = null) where T : class;
        Task<string> GetAsync(string psApi, Dictionary<string, string> poHeaders = null);
        Task<T> PostAsync<T, C>(string psApi, C poObj, Dictionary<string, string> poHeaders = null) where T : class where C : class;
        Task<string> PostAsync<T>(string psApi, T poObj, Dictionary<string, string> poHeaders = null) where T : class;
        Task<T> DeleteAsync<T>(string psApi, int piId, Dictionary<string, string> poHeaders = null) where T : class;
        Task<string> DeleteAsync(string psApi, int piId, Dictionary<string, string> poHeaders = null);
        Task<string> PutAsync<T>(string psApi, T poObj, Dictionary<string, string> poHeaders = null) where T : class;
        Task<T> PutAsync<T, C>(string psApi, C poObj, Dictionary<string, string> poHeaders = null) where T : class where C : class;
    }
}
