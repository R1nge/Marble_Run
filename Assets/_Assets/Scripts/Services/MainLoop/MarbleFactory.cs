using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay.Marble;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace _Assets.Scripts.Services.MainLoop
{
    public class MarbleFactory
    {
        [Inject] private ConfigProvider _configProvider;
        [Inject] private IObjectResolver _objectResolver;
        
        public Marble Create(float x, float y, float z)
        {
            return _objectResolver.Instantiate(_configProvider.GameConfig.Marble, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}