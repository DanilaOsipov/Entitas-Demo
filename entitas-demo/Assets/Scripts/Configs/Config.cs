using UnityEngine;

namespace Configs
{
    public class Config : ScriptableObject
    {
        [SerializeField] private string _id;
        
        public string Id => _id;
    }
}