using System.Collections.Generic;
using System.Linq;
using UI;

namespace Services
{
    public class UIMediationService : IUIMediationService
    {
        private List<IUIPanelMediator> _panelMediators = new List<IUIPanelMediator>();
        
        public void AddMediators(IEnumerable<IUIPanelMediator> panelMediators)
        {
            _panelMediators.AddRange(panelMediators);
        }

        public void ShowPanelBy<T>() where T : IUIPanelMediator
        {
            var uiPanelMediator = GetMediatorBy<T>();
            uiPanelMediator.ShowPanel();
        }

        public void HidePanelBy<T>() where T : IUIPanelMediator
        {
            var uiPanelMediator = GetMediatorBy<T>();
            uiPanelMediator.HidePanel();
        }

        public void HideAllPanels() => _panelMediators.ForEach(e => e.HidePanel());

        private IUIPanelMediator GetMediatorBy<T>() where T : IUIPanelMediator
        {
            return _panelMediators.FirstOrDefault(e => e.GetType() == typeof(T));
        }
    }
}