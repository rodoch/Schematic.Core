using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schematic.Core
{
    public interface IImageAssetRepository
    {
        Task<int> Create(ImageAsset asset, int userID);
        Task<ImageAsset> Read(int id);
        Task<int> Update(ImageAsset asset, int userID);
        Task<int> Delete(int id, int userID);
    }
}