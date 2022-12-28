using UnityEngine;

namespace Services
{
    public interface IAssetsService : IService
    {
        T[] LoadAssets<T>(string path) where T : Object;
    }
}