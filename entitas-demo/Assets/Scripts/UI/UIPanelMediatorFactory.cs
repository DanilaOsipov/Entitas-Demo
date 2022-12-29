using System;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public class UIPanelMediatorFactory : IUIPanelMediatorFactory
    {
        private List<IUIMediatorFactoryWithType> _factories = new List<IUIMediatorFactoryWithType>();

        public UIPanelMediatorFactory()
        {
            _factories.Add(new UIMainPanelMediatorFactory());
        }

        public IUIPanelMediator CreateMediator(IUIPanelView panelView, Contexts contexts)
        {
            var factory = _factories
                .FirstOrDefault(e => e.ViewType == panelView.GetType());
            return factory.CreateMediator(panelView, contexts);
        }
    }

    public abstract class UIPanelMediatorFactory<TView> : IUIMediatorFactoryWithType where TView : IUIPanelView
    {
        public Type ViewType => typeof(TView);

        public IUIPanelMediator CreateMediator(IUIPanelView panelView, Contexts contexts)
        {
            return CreateMediatorInternal((TView) panelView, contexts);
        }

        protected abstract IUIPanelMediator CreateMediatorInternal(TView panelView, Contexts contexts);
    }
}