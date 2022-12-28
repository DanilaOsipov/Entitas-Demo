using Entitas;

namespace Main.Systems
{
    public class ServiceRegistrationSystem : IInitializeSystem
    {
        private Contexts _contexts;
        private Services.Services _services;

        public ServiceRegistrationSystem(Contexts contexts, Services.Services services)
        {
            _services = services;
            _contexts = contexts;
        }

        public void Initialize()
        {
            var mainContext = _contexts.main;
            
            mainContext.ReplaceSceneService(_services.SceneService);
        }
    }
}