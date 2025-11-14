
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        Task<bool> saveChanges();
        Task<IEnumerable<Platform>> getAllPlatforms();
        Task<Platform> getPlatformById(int id);     
        Task <Platform> getPlatformByIdAsNoTracking(int id);
        Task createPlatform(Platform newPlatform); 


    }
}