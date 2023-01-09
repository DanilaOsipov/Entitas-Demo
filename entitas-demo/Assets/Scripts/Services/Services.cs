namespace Services
{
    public class Services
    {
        public IAssetsService AssetsService { get; set; }
        public ISceneService SceneService { get; set; }
        public PlayerConfigsLibrary PlayerConfigsLibrary { get; set; }
        public IUIMediationService UIMediationService { get; set; }
        public IInputService InputService { get; set; }
    }
}