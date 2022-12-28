using UnityEngine;

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

    public class UIMainPanelMediator : UIPanelMediator<UIPanelView>
    {
        public UIMainPanelMediator(UIPanelView panelView, Contexts contexts) : base(panelView, contexts)
        {
        }
    }
    
    public interface IUIPanelView
    {
        void Show();
        void Hide();
    }

    public abstract class UIPanelView : MonoBehaviour, IUIPanelView
    {
        public void Show()
        {
        }

        public void Hide()
        {
        }
    }

    public class UIMainPanelView : UIPanelView
    {
    }
}