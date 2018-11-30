using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schematic.Core
{
    public interface IResourceRepository<T, TResourceFilter>
    {
        Task<int> Create(T resource, int userID);
        Task<T> Read(int id);
        Task<int> Update(T resource, int userID);
        Task<int> Delete(int id, int userID);
        Task<List<T>> List(TResourceFilter filter);
    }
}