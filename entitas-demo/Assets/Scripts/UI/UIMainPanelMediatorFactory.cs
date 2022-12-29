namespace UI
{
    public class UIMainPanelMediatorFactory : UIPanelMediatorFactory<UIMainPanelView>
    {
        protected override IUIPanelMediator CreateMediatorInternal(UIMainPanelView panelView, Contexts contexts)
        {
            return new UIMainPanelMediator(panelView, contexts);
        }
    }
}