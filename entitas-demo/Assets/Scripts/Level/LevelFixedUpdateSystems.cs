using Common;

namespace Level
{
    public class LevelFixedUpdateSystems : FixedUpdateSystems
    {
        public LevelFixedUpdateSystems(Contexts contexts)
            : base(ApplicationConstants.LEVEL_FIXED_UPDATE_SYSTEMS, contexts)
        {
        }
    }
}