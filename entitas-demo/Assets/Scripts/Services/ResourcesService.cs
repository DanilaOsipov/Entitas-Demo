using UnityEngine;

namespace Services
{
    public class ResourcesService : IAssetsService
    {
        public T[] LoadAssets<T>(string path) where T : Object => Resources.LoadAll<T>(path);
    }
}