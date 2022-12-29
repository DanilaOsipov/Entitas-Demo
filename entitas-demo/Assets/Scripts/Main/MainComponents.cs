using Entitas;
using Entitas.CodeGeneration.Attributes;
using Services;

[Unique] public class AssetsService : IComponent { public IAssetsService Value; }
[Unique] public class SceneService : IComponent { public ISceneService Value; }
[Unique] public class PlayerConfigs : IComponent { public PlayerConfigsLibrary Value; }
[Unique] public class UIMediation : IComponent { public IUIMediationService Value; }