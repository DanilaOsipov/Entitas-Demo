using System;

namespace UI
{
    public interface IUIMediatorFactoryWithType : IUIPanelMediatorFactory
    {
        Type ViewType { get; }
    }
}