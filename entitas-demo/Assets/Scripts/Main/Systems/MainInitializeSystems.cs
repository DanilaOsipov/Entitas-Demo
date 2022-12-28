using Common;

namespace Main.Systems
{
    public class MainInitializeSystems : InitializeSystems
    {
        public MainInitializeSystems(Contexts contexts, Services.Services services) 
            : base(ApplicationConstants.MAIN_INITIALIZE_SYSTEMS, contexts)
        {
            
        }
    }
}