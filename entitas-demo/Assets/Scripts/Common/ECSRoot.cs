using UnityEngine;

namespace Common
{
    public abstract class ECSRoot : MonoBehaviour
    {
        private InitializeSystems _initializeSystems;
        private UpdateSystems _updateSystems;
        private FixedUpdateSystems _fixedUpdateSystems;
        
        protected Contexts _contexts;

        protected virtual void Awake()
        {
            _contexts = Contexts.sharedInstance;
            
            _initializeSystems = GetInitializeSystems();
            _updateSystems = GetUpdateSystems();
            _fixedUpdateSystems = GetFixedUpdateSystems();
        }

        protected virtual void Start() => _initializeSystems.Initialize();

        private void Update() => _updateSystems.Execute();

        private void FixedUpdate() => _fixedUpdateSystems.Execute();

        protected abstract InitializeSystems GetInitializeSystems();
        protected abstract UpdateSystems GetUpdateSystems();
        protected abstract FixedUpdateSystems GetFixedUpdateSystems();
    }
}