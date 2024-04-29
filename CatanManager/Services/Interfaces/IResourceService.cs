using CatanManager.Model;

namespace CatanManager.Services.Interfaces
{
    public interface IResourceService
    {

        public List<Resource> GetResources();
        public void AddResource(Resource resource);

    }
}
