using System.Collections.Generic;
using UI;

namespace Services
{
    public interface IUIMediationService : IService
    {
        void AddMediators(IEnumerable<IUIPanelMediator> panelMediators);
        void ShowPanelBy<T>() where T : IUIPanelMediator;
        void HidePanelBy<T>() where T : IUIPanelMediator;
    }
}