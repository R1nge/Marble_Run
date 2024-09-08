using _Assets.Scripts.Services.MainLoop;
using _Assets.Scripts.Services.StateMachine;
using _Assets.Scripts.Services.UIs;
using _Assets.Scripts.Services.UIs.StateMachine;
using _Assets.Scripts.UIs.MainMenu;
using VContainer;
using VContainer.Unity;

namespace _Assets.Scripts.CompositionRoot
{
    public class GameInstaller : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<UIStatesFactory>(Lifetime.Singleton);
            builder.Register<UIStateMachine>(Lifetime.Singleton);
            builder.Register<UIFactory>(Lifetime.Singleton);

            RegisterFactories(builder);

            builder.Register<GameStatesFactory>(Lifetime.Singleton);
            builder.Register<GameStateMachine>(Lifetime.Singleton);

            RegisterControllers(builder);
        }

        private void RegisterFactories(IContainerBuilder builder)
        {
            builder.Register<MarbleFactory>(Lifetime.Singleton);
        }

        private void RegisterControllers(IContainerBuilder builder)
        {
            builder.Register<MainMenuController>(Lifetime.Singleton);
        }
    }
}