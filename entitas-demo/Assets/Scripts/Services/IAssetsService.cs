using UnityEngine;

namespace Services
{
    public interface IAssetsService
    {
        T[] LoadAssets<T>(string path) where T : Object;
    }
}