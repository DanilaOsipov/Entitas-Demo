using Common;

namespace Input
{
    public class InputFixedUpdateSystems : FixedUpdateSystems
    {
        public InputFixedUpdateSystems(Contexts contexts)
            : base(ApplicationConstants.INPUT_FIXED_UPDATE_SYSTEMS, contexts)
        {
        }
    }
}