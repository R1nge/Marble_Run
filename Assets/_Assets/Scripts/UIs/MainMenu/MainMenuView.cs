using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace _Assets.Scripts.UIs.MainMenu
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        public Button PlayButton => playButton;
     
        [SerializeField] private Button settingsButton;
        public Button SettingsButton => settingsButton;
        
        [SerializeField] private Button quitButton;
        public Button QuitButton => quitButton;

        [Inject] private MainMenuController _mainMenuController;

        private void Start() => _mainMenuController.Init(this);

        private void OnDestroy() => _mainMenuController.Reset();
    }
}