using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Config/Player")]
    public class PlayerConfig : Config
    {
        [SerializeField] private string _viewPath;

        public string ViewPath => _viewPath;
    }
}