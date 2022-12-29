using Common;

namespace Input
{
    public class InputRoot : ECSRoot
    {
        protected override InitializeSystems GetInitializeSystems() => new InputInitializeSystems(_contexts);

        protected override UpdateSystems GetUpdateSystems() => new InputUpdateSystems(_contexts);

        protected override FixedUpdateSystems GetFixedUpdateSystems() => new InputFixedUpdateSystems(_contexts);
    }
}