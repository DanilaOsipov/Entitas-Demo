using Common;
using Configs;
using Services;
using UnityEngine;

namespace Main
{
    public class MainRoot : MonoBehaviour
    {
        private Contexts _contexts;
        private Services.Services _services;
        
        private void Awake()
        {
            ShowLoadingScreen();
            
            _contexts = Contexts.sharedInstance;

            _services = new Services.Services
            {
                AssetsService = new ResourcesService(),
                SceneService = new SceneManagerService(),
                PlayerConfigsLibrary = new PlayerConfigsLibrary()
            };

            LoadPlayerConfigs();
            LoadUIContext();
        }

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

        private void ShowLoadingScreen()
        {
        }

        private void HideLoadingScreen()
        {
        }
    }
}