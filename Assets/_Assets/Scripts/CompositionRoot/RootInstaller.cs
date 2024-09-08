using _Assets.Scripts.Configs;
using _Assets.Scripts.UIs.MainMenu;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace _Assets.Scripts.CompositionRoot
{
    public class RootInstaller : LifetimeScope
    {
        [SerializeField] private ConfigProvider configProvider;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(configProvider);
            builder.Register<SceneService>(Lifetime.Singleton).AsImplementedInterfaces().AsSelf();

            builder.Register<MainMenuController>(Lifetime.Singleton);
        }
    }
}