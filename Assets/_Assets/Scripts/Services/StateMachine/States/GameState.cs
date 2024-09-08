using _Assets.Scripts.Services.MainLoop;
using _Assets.Scripts.Services.Scenes;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class GameState : IAsyncState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneService _sceneService;
        private readonly MarbleFactory _marbleFactory;

        public GameState(GameStateMachine stateMachine, SceneService sceneService, MarbleFactory marbleFactory)
        {
            _stateMachine = stateMachine;
            _sceneService = sceneService;
            _marbleFactory = marbleFactory;
        }

        public async UniTask Enter()
        {
            //await _sceneService.LoadSceneAsync(SceneType.Level1, LoadSceneMode.Single);
            _marbleFactory.Create(0, 0, 0);
        }

        public async UniTask Exit() { }
    }
}