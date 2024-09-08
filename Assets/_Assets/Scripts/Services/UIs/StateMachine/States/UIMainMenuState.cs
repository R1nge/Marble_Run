using Cysharp.Threading.Tasks;
using UnityEngine;

namespace _Assets.Scripts.Services.UIs.StateMachine.States
{
    public class UIMainMenuState : IAsyncState
    {
        private readonly UIFactory _uiFactory;
        private readonly UIStateMachine _uiStateMachine;
        private GameObject _ui;

        public UIMainMenuState(UIFactory uiFactory, UIStateMachine uiStateMachine)
        {
            _uiFactory = uiFactory;
            _uiStateMachine = uiStateMachine;
        }

        public async UniTask Enter()
        {
            _ui = _uiFactory.CreateUI(UIStateType.MainMenu);
        }

        public async UniTask Exit()
        {
            Object.Destroy(_ui);
        }
    }
}