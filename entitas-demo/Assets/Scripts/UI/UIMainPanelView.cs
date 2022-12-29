using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIMainPanelView : UIPanelView
    {
        [SerializeField] private Button _startButton;

        public event Action OnStartButtonClick = delegate { };
        
        private void Awake() => _startButton.onClick.AddListener(OnStartButtonClickHandler);

        private void OnDestroy() => _startButton.onClick.RemoveListener(OnStartButtonClickHandler);

        private void OnStartButtonClickHandler() => OnStartButtonClick();
    }
}