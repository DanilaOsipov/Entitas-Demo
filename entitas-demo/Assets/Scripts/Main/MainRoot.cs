using Common;
using Configs;
using Main.Systems;
using Services;

namespace Main
{
    public class MainRoot : ECSRoot
    {
        private Services.Services _services;

        protected override void Awake()
        {
            ShowLoadingScreen();
            
            _services = new Services.Services
            {
                AssetsService = new ResourcesService(),
                SceneService = new SceneManagerService(),
                PlayerConfigsLibrary = new PlayerConfigsLibrary(),
                UIMediationService = new UIMediationService()
            };

            base.Awake();
        }

        protected override void Start()
        {
            base.Start();
            LoadPlayerConfigs();
            LoadUIContext();
        }

        protected override InitializeSystems GetInitializeSystems() => new MainInitializeSystems(_contexts, _services);

        protected override UpdateSystems GetUpdateSystems() => new MainUpdateSystems(_contexts);

        protected override FixedUpdateSystems GetFixedUpdateSystems() => new MainFixedUpdateSystems(_contexts);

        private void LoadPlayerConfigs()
        {
            var services = _services;
            var playerConfigs = services.AssetsService.LoadAssets<PlayerConfig>
                (ApplicationConstants.PLAYER_CONFIGS_PATH);
            services.PlayerConfigsLibrary.Initialize(playerConfigs);
        }

        private void LoadUIContext()
        {
            var sceneService = _services.SceneService;
            sceneService.OnSceneLoaded += OnUIContextLoadedHandler;  
            sceneService.LoadScene(ApplicationConstants.UI_CONTEXT_SCENE);
        }

        private void OnUIContextLoadedHandler(string sceneName)
        {
            _services.SceneService.OnSceneLoaded -= OnUIContextLoadedHandler;
            HideLoadingScreen();
        }

        private void ShowLoadingScreen() // TODO
        {
        }

        private void HideLoadingScreen() // TODO
        {
        }
    }
}