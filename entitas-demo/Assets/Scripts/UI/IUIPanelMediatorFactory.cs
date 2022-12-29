namespace UI
{
    public interface IUIPanelMediatorFactory
    {
        IUIPanelMediator CreateMediator(IUIPanelView panelView, Contexts contexts);
    }
}