﻿using UnityEngine;

namespace UI
{
    public abstract class UIPanelView : MonoBehaviour, IUIPanelView
    {
        public void Show() => gameObject.SetActive(true);

        public void Hide() => gameObject.SetActive(false);
    }
}