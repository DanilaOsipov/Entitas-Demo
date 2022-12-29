using Common;

namespace Level
{
    public class LevelRoot : ECSRoot
    {
        protected override InitializeSystems GetInitializeSystems() => new LevelInitializeSystems(_contexts);

        protected override UpdateSystems GetUpdateSystems() => new LevelUpdateSystems(_contexts);

        protected override FixedUpdateSystems GetFixedUpdateSystems() => new LevelFixedUpdateSystems(_contexts);
    }
}