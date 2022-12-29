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
            
        }
    }
}