namespace UI
{
    public abstract class UIPanelMediator<T> : IUIPanelMediator where T : IUIPanelView
    {
        private T _panelView;
        private Contexts _contexts;

        protected UIPanelMediator(T panelView, Contexts contexts)
        {
            _contexts = contexts;
            _panelView = panelView;
        }

        public void ShowPanel() => _panelView.Show();

        public void HidePanel() => _panelView.Hide();
    }
}