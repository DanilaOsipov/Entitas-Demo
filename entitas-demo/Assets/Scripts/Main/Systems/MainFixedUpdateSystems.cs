using Common;

namespace Main.Systems
{
    public class MainFixedUpdateSystems : FixedUpdateSystems
    {
        public MainFixedUpdateSystems(Contexts contexts) 
            : base(ApplicationConstants.MAIN_FIXED_UPDATE_SYSTEMS, contexts)
        {
        }
    }
}

// public class Contexts
// {
//     public static Contexts sharedInstance;
// }
//
// public class Feature
// {
//     public Feature(string name)
//     {
//         
//     }
//
//     public void Initialize() { }
//     
//     public void Execute() { }
// }