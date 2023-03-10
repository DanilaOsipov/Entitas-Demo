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

            mainContext.ReplaceAssetsService(_services.AssetsService);
            mainContext.ReplaceSceneService(_services.SceneService);
            mainContext.ReplacePlayerConfigs(_services.PlayerConfigsLibrary);
            mainContext.ReplaceUIMediation(_services.UIMediationService);
            
            var inputContext = _contexts.input;
            
            inputContext.ReplaceInputService(_services.InputService);
        }
    }
}