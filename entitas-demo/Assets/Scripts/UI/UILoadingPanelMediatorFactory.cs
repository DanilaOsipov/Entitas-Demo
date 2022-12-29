namespace UI
{
    public class UILoadingPanelMediatorFactory : UIPanelMediatorFactory<UILoadingPanelView>
    {
        protected override IUIPanelMediator CreateMediatorInternal(UILoadingPanelView panelView, Contexts contexts)
        {
            return new UILoadingPanelMediator(panelView, contexts);
        }
    }
}