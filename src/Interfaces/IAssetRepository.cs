using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schematic.Core
{
    public interface IAssetRepository
    {
        Task<int> Create(Asset asset, int userID);
        Task<Asset> Read(int id);
        Task<int> Update(Asset asset, int userID);
        Task<int> Delete(int id, int userID);
    }
}