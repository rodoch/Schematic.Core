using System.Collections.Generic;

namespace Schematic.Core
{
    public interface IResourceRepository<T, TResourceFilter>
    {
        int Create(T resource, int userID);
        T Read(int id);
        bool Update(T resource, int userID);
        bool Delete(int id, int userID);
        List<T> List(TResourceFilter filter);
    }
}