using System;

namespace Services
{
    public interface ISceneService
    {
        public void LoadScene(string sceneName);
        event Action<string> OnSceneLoaded;
    }
}