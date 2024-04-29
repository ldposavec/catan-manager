using CatanManager.Model;
using CatanManager.Services.Interfaces;

namespace CatanManager.Services
{
    public class ResourceService : IResourceService
    {
        private List<Resource> _resources = new()
        {
            new Resource {Name = "wheat", Code = "wt" },
            new Resource {Name = "ore", Code = "o" },
            new Resource {Name = "sheep", Code = "s" },
            new Resource {Name = "wood", Code = "wd" },
            new Resource {Name = "brick", Code = "b" },
        };


        public List<Resource> GetResources()
        {
            return _resources;
        }


        public void AddResource(Resource resource)
        {
            _resources.Add(resource);

        }
    }
}
