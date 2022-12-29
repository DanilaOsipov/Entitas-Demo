using Common;

namespace UI
{
    public class UIMainPanelMediator : UIPanelMediator<UIMainPanelView>
    {
        public UIMainPanelMediator(UIMainPanelView panelView, Contexts contexts) : base(panelView, contexts)
        {
            _panelView.OnStartButtonClick += OnStartButtonClickHandler; 
        }

        private void OnStartButtonClickHandler()
        {
            var uiMediationService = _contexts.main.uIMediation.Value;
            uiMediationService.HidePanelBy<UIMainPanelMediator>();
            uiMediationService.ShowPanelBy<UILoadingPanelMediator>();

            var sceneService = _contexts.main.sceneService.Value;
            sceneService.OnSceneLoaded += OnLevelContextLoadedHandler;  
            sceneService.LoadScene(ApplicationConstants.LEVEL_CONTEXT_SCENE);
        }

        private void OnLevelContextLoadedHandler(string sceneName)
        {
            var sceneService = _contexts.main.sceneService.Value;
            sceneService.OnSceneLoaded -= OnLevelContextLoadedHandler;
            
            var uiMediationService = _contexts.main.uIMediation.Value;
            uiMediationService.HidePanelBy<UILoadingPanelMediator>();
        }
    }
}