using _Assets.Scripts.Services.StateMachine;
using _Assets.Scripts.Services.UIs.StateMachine;
using UnityEngine;

namespace _Assets.Scripts.UIs.MainMenu
{
    public class MainMenuController
    {
        private MainMenuView _mainMenuView;
        private readonly GameStateMachine _gameStateMachine;

        private MainMenuController(GameStateMachine gameStateMachine, UIStateMachine uiStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Init(MainMenuView mainMenuView)
        {
            _mainMenuView = mainMenuView;
            _mainMenuView.PlayButton.onClick.AddListener(Play);
            _mainMenuView.SettingsButton.onClick.AddListener(Settings);
            _mainMenuView.QuitButton.onClick.AddListener(Quit);
        }

        private void Play() => _gameStateMachine.SwitchState(GameStateType.Game);

        private void Settings()
        {
            Debug.Log("Settings");
        }

        private void Quit() => Application.Quit();

        public void Reset()
        {
            _mainMenuView.PlayButton.onClick.RemoveAllListeners();
            _mainMenuView.SettingsButton.onClick.RemoveAllListeners();
            _mainMenuView.QuitButton.onClick.RemoveAllListeners();
            _mainMenuView = null;
        }
    }
}